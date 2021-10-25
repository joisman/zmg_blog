## Zemoga Blog
_A test app for Zemoga by Joisman Jiménez_

This is a test blog application for Zemoga developed in ASP.NET Core. The main function of this solution is to give the ability to the user to manage the posts in the blog. It's required to install **Visual Studio** or **Visual Studio Code** and **.NET Core 5 SDK** to build and run this application.
#### Total developing time: 22 hours 

## Knowing the file structure
This solution is developed in .**NET Core 5** with **EntityFramework Core** and uses **MSSQL Server** as database engine and contains 5 projects, as is:
- **Zmg.Blog.API**: (api/main project) API Project with Swagger Documentation.
- Zmg.Blog.Repository: Class library with all the repository 
- Zmg.Blog.Domain: Class library with the domain classes used in the whole application
- Zmg.Blog.BL: Class library with DTOs and Models. References Zmg.Blog.Repository.
- **Zmg.Blog.Web**: (web/main Project) UI Project  

## After you clone the code
Once the code is on your PC, you'll need to build the project in order to restore the **Nuget** packages. Then you should create the database by running the **Update-Database** command in the **Package Manager Console**. Make sure that any of the main projects is selected as the startup project. After the successful database creation, you're ready to start using the application.

## User Credentials
You can use the application with any of the following users. Depending on the role, you'll be able to run some actions on the application:
- **blogeditor** /Editor
- **blogwriter** / Writer
- **blogadmin** / Admin
>For all the users, the password is **password**

## Postman Collection
You can find a postman collection file called **zmg.blog.postman_collection** with the most common (and required) requests for the API. After you import it, you'll be able to see the following request tree:

![request tree](https://user-images.githubusercontent.com/43049155/138659632-a4b5445e-c38c-481b-8a2b-74c5742ab6c1.png)

You can use the credentials mentioned above in the body of **Login** request. 

![image](https://user-images.githubusercontent.com/43049155/138659684-d4f26713-ac87-4cd9-bf36-d94f47d9f787.png)

If the login is successful, you will get a response with the session token (JWT) and postman will set an environment variable called **token**, so you don't need to paste the token on every request you send.

![image](https://user-images.githubusercontent.com/43049155/138659738-d8590b09-020c-4d01-ac72-f8fdf9f014bc.png)

![image](https://user-images.githubusercontent.com/43049155/138659772-1a7482d1-eca9-4547-b87a-f4f2ec0ae2d8.png)


## Resources and references
- https://medium.com/swlh/securing-your-net-core-3-api-using-identity-93d6426d6311
- https://dev.to/moe23/step-by-step-repository-pattern-and-unit-of-work-with-asp-net-core-5-3l92
- https://docs.microsoft.com/en-us/ef/core/modeling/data-seeding
- https://www.c-sharpcorner.com/article/authentication-and-authorization-in-asp-net-core-web-api-with-json-web-tokens/

