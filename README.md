# SAS custom task example: SAS Task Property Viewer
***
This repository contains one of a series of examples that accompany
_Custom Tasks for SAS Enterprise Guide using Microsoft .NET_ 
by [Chris Hemedinger](http://support.sas.com/hemedinger).

This particular example goes with
**Chapter 10: For the Workbench: A SAS Task Property Viewer**.  It was built using C# 
with Microsoft Visual Studio 2010.  It should run in SAS Enterprise Guide 4.3 and later.

## About this example
This example uses support for new APIs that were added in 
SAS Enterprise Guide 4.2.  These APIs allow the active task to "see" what 
elements are within the active project file.  Because it's 
specific to SAS Enterprise Guide project files, this task does not 
work within the SAS Add-In for Microsoft Office.
An overview of these APIs is contained in 
**Chapter 4, "Meet the Custom Task APIs"**.  Specifically, the APIs 
that allow you a view of within the project are:

#### SAS.Shared.AddIns.ISASProject
Provides access to basic project file information such as its name and the date it was created.  
#### SAS.Shared.AddIns.ISASProcessFlow
Provides access to the contents of a process flow.  
#### SAS.Shared.AddIns.ISASProjectTask
Represents an individual task within a process flow. 
 
The example shows how to use these interfaces to 
navigate your project contents and access information about the 
individual tasks within the project.
