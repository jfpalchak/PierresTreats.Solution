# _Pierre's Sweet and Savory Treats_

#### By _Joey Palchak_

#### _A C# / ASP.NET Core MVC application using Entity Framework Core, MySQL, and Authentication & Authorization with Identity._

## Technologies Used

* C#
* .NET 6
* ASP.NET Core MVC
* Entity Framework Core
* Entity Framework Core CLI Tools
* Entity Framework Core Identity
* MySQL
* MySQL Workbench

## Description

_Pierre's Sweet and Savory Treats_ is an MVC web application that allows authenticated users to create, update, read, and delete Treat and Flavor objects to the application's database. 

Any user, whether they have registered an account or not, is able to navigate the site to read all available entries for Treats and Flavors. However, unless the user registers and logs in to their own account through the site's interface, the user will not be able to create, update, or delete any objects in the application.

<img src="https://github.com/jfpalchak/PierresTreats.Solution/blob/main/Pierres/wwwroot/img/splash.png" alt="Pierre's splash page"/>

To create, update, or delete objects in the web application, a user can take the following steps:
  1. Navigate to _Account_, found in the site's navigation bar.
  2. Select _Register_.
  3. Follow the site's instructions by entering an email and password to register an account with.
  4. Once an account has been successfully registered and the user has been redirected back to the _Account_ page, select _Log In_.
  5. Enter the same credentials that were previously used to create the newly registered account.
  6. Once successfully logged in, the user will now have access to create, update, and delete functionality throughout the site.

<img src="https://github.com/jfpalchak/PierresTreats.Solution/blob/main/Pierres/wwwroot/img/login.png" alt="Pierre's login page"/>

## Setup/Installation Requirements

### Install Tools
This project assumes you have MySQL Server and MySQL Workbench installed on your system. _If you do not have these tools installed_, follow along with the installation steps for the the necessary tools introduced in the series of lessons found here on [LearnHowToProgram](https://full-time.learnhowtoprogram.com/c-and-net/getting-started-with-c/installing-and-configuring-mysql).

For Entity Framework Core, we'll use a tool called `dotnet-ef` to reference the project's migrations and update our database accordingly. To install this tool globally, run the following command in your terminal:

```
$ dotnet tool install --global dotnet-ef --version 6.0.0
```

Optionally, you can run the following command to verify that EF Core CLI tools are correctly installed:

```
$ dotnet ef
```

### Install and Run the Project

Assuming you've completed the required steps above:

1. Copy the **[URL](https://github.com/jfpalchak/PierresTreats.Solution.git)** provided for this repository.
2. Open Terminal.
3. Change your working directory to where you want the cloned directory.
4. In your terminal, type `git clone` and use the copied URL from Step 1. Or, copy the following git command:
```bash
$ git clone https://github.com/jfpalchak/PierresTreats.Solution.git
```
5. Open your terminal and navigate to this project's production directory, labeled `Pierres`.
6. Within the production directory of the project, create a file called `appsettings.json` and add the following code to it:
   ```json
    {
      "ConnectionStrings": {
          "DefaultConnection": "Server=localhost;Port=3306;database=[DATABASE];uid=[USERNAME];pwd=[PASSWORD];"
      }
    }
   ```
7. Next, make sure to update the connection string with your own choice of naming for the `[DATABASE]`, as well as your own system's values for `[USERNAME]` and `[PASSWORD]` when logging in to MySQL. Don't forget to replace the brackets `[]` as well!
8. With `appsettings.json` properly configured, in the command line, run the following command to reference the project's migrations and re-create the application's database:

   ```
   $ dotnet ef database update
   ```
9.  Then, in the command line, run the following command to compile and run the web application in development mode with a watcher:
   
```bash
$ dotnet watch run
```
> Optionally, you can run `dotnet build` to compile this web app without running it.

10. Open your browser to https://localhost:5001 to navigate and use the web application. 
> If you cannot access localhost:5001 it is likely because you have not configured a .NET developer security certificate for HTTPS.

## Known Bugs

* If any bugs are discovered, please contact the author.

## License

MIT License

Copyright (c) _10/20/2023_ _Joey Palchak_

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.