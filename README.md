# Live Coding Editor

A simple web application for rendering HTML examples and saving them to database :dart:
The user interface is quite simple and consist of 4 buttons, text area to write and frame to render the HTML.
Buttons works as follow:
 - RUN: You can see how your code looks as HTML.
 - SAVE: Saves your code to the database and creates a shareable link you can send to your friends and coworkers. If you already saved your example the button will instead EDIT    your current database entry.
 - CHECK ORIGINAL: Checks if the current code in the text area matches an example already existing in the database.
 - COPY URL: Copies the current URL from your address bar to the clipboard for easier share.

## :hammer_and_pick: **Built With**

- MS Visual Studio 2019
- MS SQL Server Management Studio 2017
- ASP.NET Core 5.0
- Entity Framework (EF) Core 5.0
- Microsoft SQL Server Express
- ASP.NET MVC
- Dependency Injection
- Bootstrap Responsive Design
- HTML5
- CSS
- Google API


## :gear: **Application Configurations**

### 1. The Connection string 
is in `appsettings.json`. If you don't use SQLEXPRESS, you should replace `Server=.\\SQLEXPRESS;` with `Server=.;`

### 2. Database Backup
is included in the repository as a script named 'LiveCodingEditorSqlCreate.sql'


## :v: **Show your opinion**

Give a :star: if you like this project


## **License**
This project is licensed under the MIT License - see the LICENSE.md file for details!
