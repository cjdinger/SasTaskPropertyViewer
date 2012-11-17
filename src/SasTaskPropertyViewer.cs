using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Xml;

using SAS.Shared.AddIns;
using SAS.Tasks.Toolkit.Controls;

namespace SASPress.Examples
{
    /// <summary>
    /// This windows form inherits from the TaskForm class, which
    /// includes a bit of special handling for SAS Enterprise Guide.
    /// </summary>
    public partial class SasTaskPropertyViewer : SAS.Tasks.Toolkit.Controls.TaskForm
    {
        #region Initialization
        List<string> tempfiles = new List<string>();

        public SasTaskPropertyViewer(SAS.Shared.AddIns.ISASTaskConsumer3 consumer)
        {
            InitializeComponent();

            // provide a handle to the SAS Enterprise Guide application
            this.Consumer = consumer;
        }
    
        protected override void OnLoad(EventArgs e)
        {
            RefreshProjectContent();
            base.OnLoad(e);
        }
        #endregion

        #region Event handlers
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                RefreshProjectContent();
            }
            catch 
            {
                MessageBox.Show("Cannot refresh the content for this project.  Close this task and try again.");
                btnCancel_Click(null, null);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            // clean up temp files if we created any
            // by viewing task state externally
            foreach (string file in tempfiles)
            {
                try
                {
                    if (System.IO.File.Exists(file))
                        System.IO.File.Delete(file);
                }
                catch { }
            }
            this.Close();
        }
        #endregion

        #region Load project content and process flows
        // Load the list of Process Flows for the project
        // And then load the list of items within
        // the first selected process flow
        private void RefreshProjectContent()
        {
            // get a handle to the project, and 
            // then the list of process flows
            ISASProject project = Consumer.GetProject();
            
            // get the list of process flows from the project
            // and bind the list as a data source for the 
            // combo box
            List<ISASProjectProcessFlow> flows = project.ProcessFlows;
            cmbProcessFlows.DisplayMember = "Name";
            cmbProcessFlows.DataSource = flows;
            cmbProcessFlows.SelectedIndex = 0;
        }

        // when the selected flow changes, update the list 
        // of tasks
        private void OnSelectedFlowChanged(object sender, EventArgs e)
        {
            // get the current selected process flow
            ISASProjectProcessFlow flow = cmbProcessFlows.SelectedItem as ISASProjectProcessFlow;

            // update the label, and bind the ListBox data source
            // to the list of tasks
            lblTasks.Text = string.Format("Tasks in \"{0}\"", flow.Name);
            lbTasks.DisplayMember = "Name";

            // get this list of tasks in the flow, and remove
            // THIS task if it's in the list.
            List<ISASProjectTask> tasks = flow.GetTasks();
            if (tasks.Contains(Consumer.GetThisTask()))
                tasks.Remove(Consumer.GetThisTask());
            lbTasks.DataSource = tasks;
        }

        // when the selected task changes, update the properties
        // area with the info about the task
        private void OnSelectedTaskChanged(object sender, EventArgs e)
        {
            ISASProjectTask task = lbTasks.SelectedItem as ISASProjectTask;
            ISASProjectItem item = lbTasks.SelectedItem as ISASProjectItem;
            if (task != null && item!=null)
            {
                // hide the No Task panel
                panelNoTask.Visible = false;
                panelNoTask.SendToBack();

                // set up the values for the properties
                gbProperties.Text = string.Format("Properties for \"{0}\"", 
                    item.Name);
                pbTaskIcon.Image = item.GetIcon(false).ToBitmap();
                lblLastModified.Text = string.Format("Last modified: {0}",
                    item.DateModified.ToShortDateString());
                lblModifiedBy.Text = string.Format("By: {0}",
                    item.ModifiedByUserId);
                lblTaskType.Text = task.TaskType;
                txtInternal.Text = task.InternalState;
                btnViewText.Enabled = !string.IsNullOrEmpty(task.InternalState);
                btnViewXml.Enabled = !string.IsNullOrEmpty(task.InternalState);
            }
            else
            {
                gbProperties.Text = "No selected task";
                panelNoTask.Visible = true;
                panelNoTask.BringToFront();
            }

        }
        #endregion

        #region Event handlers for viewing XmlState
        // view the contents of the InternalState
        // in an external application.
        // To do this, first write the contents to an external
        // file, and then use Process.Start to launch it.
        private void btnViewExternal_Click(object sender, EventArgs e)
        {
            try
            {
                string ext = ".txt";
                // if it's the "View Text" button, save to a 
                // text file
                if (sender == btnViewText) 
                    ext = ".txt";
                // else save to XML file
                else 
                    ext = ".xml";

                // create a TEMP file with the proper extension
                string newFile = System.IO.Path.GetTempFileName();
                string xmlFile = string.Format("{0}.{1}", newFile,ext);
                System.IO.File.Move(newFile, xmlFile);

                // Note: some XML content might have encoding= in the XML header
                // and the default encoding won't be quite right
                System.IO.File.WriteAllText(xmlFile, txtInternal.Text, Encoding.Default);
                tempfiles.Add(xmlFile);
                System.Diagnostics.Process.Start(xmlFile);
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Unable to create external file: {0}",ex.Message), "Error");
            }

        }
        #endregion

    }
}
