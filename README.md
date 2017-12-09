# MVC5-and-EntityFramework6-C-Sharp

https://docs.microsoft.com/en-us/aspnet/mvc/overview/getting-started/database-first-development/creating-the-web-application

1. Create a MVC Project.
2. Install Entity Framework 6 into your app.
3. RC Model, add, new item, select Data in the left pane and ADO.NET Entity Data Model from the options in the center pane. Name the new model file MikesModel, Add, select EF Designer from database.

4a. LC New SQL Connection, Server Name: MIKESDELL\SQLEXPRESS, Windows Authentication, DataBase Name: mike, Test Ok, save connection settings in WebConfig as mikeEntities, next, select your table name "EmployeeViewModel" in DataBase, Finish.
4b. The models are generated from the database tables, and a diagram is displayed that shows the properties and relationships between the tables.
4c. The Models folder now includes many new files related to the models that were generated from the database. The MikesModel.Context.cs file contains a class that derives from the DbContext class, and provides a property for each model class that corresponds to a database table. The Course.cs, Enrollment.cs, and Student.cs files contain the model classes that represent the databases tables. You will use both the context class and the model classes when working with scaffolding.

5. Before proceeding with this tutorial, build the project. In the next section, you will generate code based on the data models, but that section will not work if the project has not been built.
//-------------------------

EF Database First with ASP.NET MVC: Generating Views.

6a. To maintain consistency in your project, you will add the new controller to the existing Controllers folder. Right-click the Controllers folder, and select Add – New Scaffolded Item.

6b. Select the: "MVC5 Controller with views using Entity Framework option", This option will generate the controller and views for updating, deleting, creating and displaying the data in your model.

6c. Select "EmployeeViewModel(MVCEmployeeViewModel1.Models)" for the model class, and select the "mikeEntities(MVCEmployeeViewModel1.Models)" for the context class. Keep the controller name as "EmployeeViewModelsController", add. After the code generation process is complete, you will see a new controller and views in your project.

7. To make it easier for you to navigate to your new view, you can add a hyperlink to the Index views for it: "EmployeeViewModels". Open the file at Views/Home/Index.cshtml, which is the home page for your site. Add the following code below the jumbotron.

<div>
    @Html.ActionLink("List of Employees", "Index", "EmployeeViewModels")    
</div>

8. Done!
