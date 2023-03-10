# _Hair Salon_

#### By _Geoffrey Gao_

#### _An application that helps to track stylists and clients at a hair salon_

## Technologies Used

* _C#_
* _ASP.Net Core MVC_
* _Entity Framework Core_
* _MySQL_

## Description

_This application contains a website that allows a user to track stylists and clients at a hair salon. The application contains functionality to add, view, and delete stylists and clients. The application allows users to assign clients to stylists. The project also includes search functionality to filter stylists and clients.  The project demonstrates solid understanding of the new concepts from the Databases with C# section including MVC,  One-to-many relationships, SQL, and Entity Framework Core._

## Setup/Installation Requirements

### Database Installation
_Use the `geoffrey_gao.sql` file located in the top level of this repo to create a new database in MySQL Workbench with the name `geoffrey_gao`._

### Run this project
* _Clone this repository_
* _Open your shell (e.g., Terminal or GitBash) and navigate into the "HairSalon" production directory_
  - _Within the production directory "HairSalon", create a new file called `appSettings.json`. Within this file, put in the following code, replacing the `uid` and `pwd` values with your own username and password for MySQL_
```JSON
{
  "ConnectionStrings": {
      "DefaultConnection": "Server=localhost;Port=3306;database=to_do_list_with_ef_core;uid=root;pwd=epicodus;"
  }
}
```
  - _In the terminal, run the program with `dotnet watch run` to start the project in development mode with a watcher_
  - _If the application does not automatically launch, open the browser to [https://localhost:5001](https://localhost:5001)_

## Known Bugs

* _N/A_

## License

_MIT_

Copyright (c) _2023_ _Geoffrey Gao_