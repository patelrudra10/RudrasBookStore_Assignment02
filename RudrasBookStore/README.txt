Assignment 02
Rudra Patel (0779707)

I created the Part 01 on 22nd but my Github Repo was deleted so it was not on Git
so Andrew was upset, so I created again on 2022-03-26

2022-03-26
1230
Started my project and named it as "RudrasBookStore" with ASP.NET(Model View Controller) with individual
accounts authentication.
1232
Reviewed the files that are created in my project.
1245
Opened the startup.cs and modified the line 35 as per instructed by Andrew.
1245
Started reviewing the Startup.cs as per instructed by Andrew.
1248
Created Git Repository and named it as RudrasBookStore and checked thrice that it is visible or not.
Last time Git repo was not created and my project got ruined and Andrew was upset with me.
1250
Now I started debugging and run my app after putting breakpoint in "HomeController.cs" and it runs.
1255
I changed the theme from the site bootswatch.com, took bootstrap of style named "Journal" and replace with 
my project's bootstrap.
1256
Replaced the site.css by the css provided by Andrew on blackboard.
1300
Modified the link to bootstrap.css in Layout.cshtml
Modified navbar to dark and bg to primary in Layout.cshtml
Removed the "text-dark" from line 23 in Layout.cshtml
Added and additional footer class in Layout.cshtml
1303
Modified the LoginPartial.cshtml, removed "text-dark" from line 9,20,23
1306
Ran the project and it works.
1310
Added third party tools which were provided by Andrew in Layout.cshtml
Added css in the head section of the file and scripts in the footer.
Added dropdown menu in Layout.cshtml
1312
Added three new project to the main project named RudrasBooksStore.DataAccess, RudrasBooksStore.Models, RudrasBooksStore.Utility
1315
Moved the Data folder to RudrasBooksStore.DataAccess Project
Added NuGetPackages named Core.Realtional and Core.SqlServer
1318
Deleted the migrations folder from the data folder.
1320
Added new NuGetPackages named Identity.Framework
1321
Modified the namespace of ApplicationDbContext.cs as per instructed by Andrew.
1322
Deleted the all the default classes from all the new three projects that were added to main project.
1322
Added project refrence to main project of DataAccess and Models Projects.
1323
Renamed the Model folder to ViewModel
1324
Modified the ErrorViewModel.cs as per instructed
1330
Added refrence of DataAccess project in Startup.cs file errors
1331
Added a new class to Utility Project named SD.cs
Modified the class property to public static.
1332
Added new project refrence of Utility project to main project
1335 
In DataAccess project added the project refrence of Models and Utility project.
1340
Added new area named "Customer"
1342
Changed the routes in Startup.cs as we created Customer Area 
Moved the HomeController.cs to the Area>Customer>Controller
1345
Defined the HomeController.cs to explicite that controller is in Customer Area
1348
Copied the ViewStart.cshtml and ViewImport.cshtml to Area folder.
1350
Modified the ViewStart.cshtml as per instructed by Andrew.
1351
I ran the application and horrah it works

2022-03-29
PART-02 started

0930
Started reviewing the appsettings.json file and change the database as per instructed by Andrew.
0934
Added Default Migration named "RudrasBooks.DataAccess.Migrations.AddDefaultIdenityMigration"
0939
After adding thr Migration in .DataAccess Project I reviewed it, and run my application and its running.
Completed first section of part 02.

1800
Created Repository folder and inside it a new folder named IRepository folder inside the migrations and modified according to Andrew's instructions
Added new interface in IRepository folder named "IRepository.cs"
1805
Modified according to Andrew's instructions
1810
Started implementing the class and the repository
1813
Modified the code to create constructors and DI
1825
Created individual Repos for category named as Category.cs and ICategory.cs
1830
Modified the Category Repository
Also Modified ICategory interface according to Andrew.
1835
After modifying builded my project and there is no error.
1840
Added UnitOfWork for multiple repos
Added a new interface named ISP_Call.cs that extends IDisposable.



