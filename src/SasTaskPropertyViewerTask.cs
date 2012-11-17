using System;
using System.Text;
using SAS.Shared.AddIns;
using SAS.Tasks.Toolkit;

namespace SASPress.Examples
{
    // unique identifier for this task
    [ClassId("5b43aafc-5169-4392-8d39-6419f1d582c2")]
    // location of the task icon to show in the menu
    [IconLocation("SASPress.Examples.task.ico")]
    // this task has no input data
    [InputRequired(InputResourceType.None)]
    public class SasTaskPropertyViewerTask : SAS.Tasks.Toolkit.SasTask
    {

        #region Initialization
        public SasTaskPropertyViewerTask()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            // 
            // SasTaskPropertyViewerTask
            // 
            this.GeneratesReportOutput = false;
            this.GeneratesSasCode = false;
            this.RequiresData = false;
            this.TaskCategory = "SAS Press Examples";
            this.TaskDescription = "View the contents of tasks in your project file";
            this.TaskName = "Task Property Viewer";

        }
        #endregion

        #region overrides
        /// <summary>
        /// Show the task user interface
        /// </summary>
        /// <param name="Owner"></param>
        /// <returns>whether to cancel the task, or run now</returns>
        public override ShowResult Show(System.Windows.Forms.IWin32Window Owner)
        {
            // this creates the window to show the project/task properties
            SasTaskPropertyViewer dlg = new SasTaskPropertyViewer(this.Consumer);
            // NOTE: the Show() call (instead of ShowDialog()) 
            // opens the task window in a MODELESS state, which allows you
            // to continue to interact with the project while this window
            // is showing.
            dlg.Show(Owner);
            return ShowResult.Canceled;
        }

        #endregion

    }
}
