# Banking Application KU ( FastBank - Never has been faster to do banking )

Kingston University London - Penryn Road Campus™ 

All rights reserved by ® Kopil Kaiser

Banking Application for Coursework 2 

Developer: Kopil Kaiser

Student Id: K2360182

Module Title: Software Architecture and Programming Modules 

Module Code: C17250

***
# Instructions to make sure Applicaiton runs on your device:

1. Run the "BankingWebApp.sln" in "BankingWebApp" folder. After the project has been loaded successfully please follow the following instructions.

1. Make sure you are connected to the internet

**Creating the database is mandatory**
Follow the following steps on creating the database:

1. MenuBar at top -> Tools -> NuGet Package Manager -> Package Manager Console 

1. Open "Package Manager Console" in "Microsoft Visual Studio"

1. First command to (makes sure you name the migration in double quotes): 

	- add-migration "Initial_Migration"

1. Second command to run:

    - update-database

1. this will ensure the .mdf database is created for Microsoft SQL Server database in the following directory "C:\Users\[userName]\K2360182_FastBankApp.mdf". It is needed to use the app.

1. Please check to see if the database "K2360182_FastBankApp.mdf" has been created successfully.
***

# Technologies used in developing the application:

Microsoft Documentation Link: [Entity Framework Core](https://learn.microsoft.com/en-us/ef/core/)
1. [ASP Net Core 8.0 MVC](https://learn.microsoft.com/en-us/aspnet/core/mvc/overview?view=aspnetcore-8.0#aspnet-core-mvc) 
 Web Application which includes
	- Pages (UI) powered by the latest Razer engine (.cshtml) files which is a combination of HTML and C#,
 	- Microsoft Dependency Injection Framework to handle dependencies,
  	- [NLog 5.2]([url](https://github.com/nlog/nlog/wiki)) Logging Framework for ASP.NET Core which includes File, Database, Console and Debug logging. This makes sure the application is diagnosed and any problems occurring can be traced back to source

1. Microsoft.EntityFrameworkCore 8.0.0 - Object Relational Mapper (ORM). It is a very powerful which helps to implement Code First database. If dev has adequate MySQL knowledge he can structure and establish and fully functional Relational Database. I've used [Microsoft SQL Server](https://learn.microsoft.com/en-us/sql/relational-databases/databases/databases?view=sql-server-ver16) database. 
	- Microsoft.EntityFrameworkCore.SqlServer 8.0.0
 	- Microsoft.EntityFrameworkCore.Tools 8.0.0
  	- Microsoft.EntityFrameworkCore.Relational 8.0.0
   	- Microsoft.EntityFrameworkCore.Abstractions 8.0.0
   	- Microsoft.EntityFrameworkCore.Design 8.0.0
  
1. [AutoMapper.Extensions.Microsoft.DependencyInjection 12.0.1](https://github.com/AutoMapper/AutoMapper.Extensions.Microsoft.DependencyInjection)
   
1. [Google Map JavaScript API -Application Programming Interface](https://developers.google.com/maps/documentation/javascript/overview)

1. [Bootstrap 5.3.2: includes CSS3, HTML5, JavaScript ES13 (ECMAScript 13th Edition), PopperJS 1.16.1](https://getbootstrap.com/docs/5.3/getting-started/introduction/)

1. [Font Awesome 6.5.1](https://fontawesome.com/download)
1. [JQuery 3.7.1](https://api.jquery.com/)

1. [X.PagedList.Mvc.Core 8.4.7](https://github.com/dncuug/X.PagedList), Successor of [PagedList](https://github.com/troygoode/PagedList)
