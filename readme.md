Service Management + Azure Diagnostics Demo (Pre-deploy)
========================================================

Here simply want to demonstrate how simple it is to update an existing role deployment, using the Staging slot which is provided for every cloud service.


1.	Review the DiagnosticsDemo solution. Whats of particular interest in this solution is the initialization of the Azure DiagnosticsMonitor on the RoleEntryPoint.
2.	Open the cloud project configuration page for the WebRole, and highlight how the Diagnostics module is baked in all Azure projects. The module is enabled by default, and includes a standard connection string, which by default will use the local dev fabric.
3.	An Azure Storage account should be provisioned, and configured here.
4.	Azure storage provide a single, consolated, highly availably place to store all diagnostics data for an entire cloud solution.
5.	Imagine having to reconcile the local log files across 100 running instances of a web role, for example – this would not be feasibility, and indeed a nightmare.
6.	Open WebRole.cs (RoleEntryPoint), and walkthrough the OnStart code.
7.	Highlight the concept of a “Startup Task”, which will create a custom Windows EventLog Source, called “FooSource”. Point out where a startup task is defined in the csdef, and the ability to elevate its execution privilege.
8.	Startup tasks are a useful extensibility point, for running in customizations to the default Cloud Service VM images (e.g. registry settings, registering custom components, running MSI installers, etc).
9.	Highlight the csdef and cscfg defaults for defining the default instance count and VM size. Ensure that the instance count is set to 2 or more for this demo.
10.	Because this solution has been pre-deployed, will make a code change to highlight how the update cycle works with Cloud Services.
11.	Update style.css (102), change the background color to something that will stand out.
12.	Deploy to the solution using VS Publish. Ensure that the Staging slot is used (wait 5 minutes).
13.	In the meantime…
14.	The Diagnostic Demo solution is currently running in the production slot. Let browse to it load balanced DNS.
15.	
16.	Use DiagnosticsDemo.v2.0
