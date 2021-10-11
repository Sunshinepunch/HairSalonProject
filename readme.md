# _{Friday Week 8 - Store Vendor System}

### By _{Becket Harvey}_


#### _Technologies Used_
C#
.NET 5
NuGet
ASP.NET Core
Entity Framework Core
MySql
MySql Workbench

## Description _This project instructs the user to make a database for a fictional hair salon to track hair stylists and clients. They can then utilize MySql and the Entity Framework Core to add/edit/delete clients and stylists in an MVC application in order to experiment with database commands!_



## Setup/Installation Requirements
-Download and install .NET 5 (https://dotnet.microsoft.com/download/dotnet/5.0)

-Download a text code editor (VS Code is my preferred choice)

-Download install and complete setup for MySql Community Server and MySql Workbench
(https://dev.mysql.com/downloads/file/?id=484914)

Open the HairSalon.Solutions folder in your preferred text editor
To install required packages, navigate to the terminal and type the following commands:
dotnet add package Microsoft.EntityFrameworkCore -v 5.0.0
dotnet add package Pomelo.EntityFrameworkCore.MySql -v 5.0.0-alpha.2
dotnet add package Microsoft.EntityFrameworkCore.Proxies -v 5.0.0
Create a file named "appsettings.json" in the HairSalon directory
add the following code to the appsettings.json file:
{
  "ConnectionStrings": {
      "DefaultConnection": "Server=localhost;Port=3306;database=brandon_eads;uid=root;pwd=[YOUR-PASSWORD-HERE];"
  }
}
replace [YOUR-PASSWORD-HERE] with your unique MySql password
Launch the MySql server:
In the terminal, run the command "$ mySql -uroot -p[YOUR-PASSWORD-HERE]", replacing [YOUR-PASSWORD-HERE] with your unique MySql password
To Import the required database:
Open MySql Workbench
Select your preferred server(default is root)
In the "Navigator > Administration" window, select "Data Import/ Restore"
In "Import Options", select "Import From Self-Contained File"
Navigate to "HairSalon.Solutions/brandon_eads.sql" in the search input
Under "Default Schema to be Imported to" select the "New" button
Enter "brandon_eads" and click "OK"
Navigate to the "Import Progress" tab and click "Start Import" in the bottom right corner of the window
Reopen the "Navigator>Schemas" tab, Right click and select "refresh all" to see the imported database
To Restore, build, and run the project:
Navigate to the HairSalon.Solutions/HairSalon folder in the command line or terminal
Run the command "dotnet restore" to restore the project dependencies
Run the command "dotnet build" to build and compile the project
Run the command "dotnet run" to build and compile the project


## Known Bugs
* _Email if you find any!_

## License
_{MIT}_ This is open source for anyone to use and I am not responsible for any problems resulting from its use or implementation

## Contact Information
* Find me on Github under SunshinePunch!