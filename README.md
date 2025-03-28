# Internet Service Provider Database Project

This project requires setting up a database in Microsoft SQL Server (MSSQL) and configuring your development environment with specific NuGet packages and tools. Follow the steps below to get started.

## Database Setup

1. **Create the Database**  
   - Open Microsoft SQL Server Management Studio (SSMS) or your preferred SQL client.  
   - Run the SQL query provided in the file `InternetServiceProviderDB - create objects.sql` to create the necessary database objects (tables, etc.).  

2. **Load Data into the Database**  
   - After creating the database objects, execute the script in `InternetServiceProviderDB - load data.sql` to populate the database with initial data.

## Project Configuration

### Step 1: Install NuGet Packages
To add the required dependencies to your project, follow these steps:

1. In Visual Studio, open the **Solution Explorer**.  
2. Right-click on your project name and select **Manage NuGet Packages**.  
3. Install the following packages one by one:  
   - Search for `rdlc` and install the first package that appears.  
   - Search for `Microsoft.SqlServer.Types` and install version **14.0.314.76**.  
   - Search for `Microsoft.ReportingServices.ReportViewerControl.Winforms` and install version **150.1652.0**.  

4. After installation, a `packages` directory will appear in your project folder.

### Step 2: Add ReportViewer Control to Toolbox
To use the ReportViewer control in your project, add it to the Visual Studio Toolbox:

1. In Visual Studio, go to **View -> Toolbox** to open the Toolbox window.  
2. Locate the **General** category in the Toolbox.  
3. Right-click on **General** and select **Choose Items**.  
4. In the dialog that appears, click **Browse**.  
5. Navigate to your project’s `packages` directory and locate the file `Microsoft.ReportViewer.WinForms.dll`.  
6. Select the DLL and click **Open** to add the ReportViewer control to the Toolbox.

## Next Steps
Once the database is set up and the NuGet packages and ReportViewer control are configured, you’re ready to start working on the project. Ensure all dependencies are correctly referenced in your solution before proceeding.
