# fluent_api
In this project, I want to explain Fluent API._There are two main ways you can configure EF to use something other than conventions, 
namely annotations or EFs fluent API. The code first fluent API is most commonly accessed by overriding the OnModelCreating method on your derived DbContext.
### Project Overview
In this project, I used Visual Studio 2019, Entity Framework 6.4.4 and for the data access
I use code first approach. I wanted to create an e-commerce database which is similar to Nortwind.
If you want to see how it looks please follow the steps below.

**1.** Open the  fluent_api directory.<br>
**2.** In the fluent_api directory, open the fluent_api.sln in Visual Studio. <br>
**3.** Open the ApplicationDbContext in the Context directory.<br>
**4.** You will see **public ApplicationDbContext() => Database.Connection.ConnectionString = @"Server=`write your server name here` ; Database = FluentApiECommerceDb ; Integrated Security=True;";** .<br>
**5.** Open your Package Manager Console. Firstly write `enable-migrations` and secondly write `update-database`.<br>
**6.** Open your Microsoft SQL Server Management Studio. You will see FluentApiECommerceDb.<br>
#### DataBase Diagram
<img src="//fluentapi_ecommercedb.png" alt="alt text"/>

#### Additional Information
I hope will like this project. If you are having trouble using this project, please open a new issue and describe your problem. Liked the project? Just give it a star.