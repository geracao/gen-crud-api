<div id="top"></div>

# gen crud api

## About this project
Web API for the CRUD (Create, Read, Update and Delete) functionality of the [gen-crud-web project](https://github.com/geracao/gen-crud-web).

##### Technologies: 
- [C#](https://docs.microsoft.com/en-us/dotnet/csharp/)
- [Postgresql 14](https://www.postgresql.org)
- [ASP.NET Core 6](https://docs.microsoft.com/pt-br/aspnet/core/?view=aspnetcore-6.0)

## How to run
##### 1. Downloads & Dependencies:
- Download [.NET 6.0](https://dotnet.microsoft.com/en-us/download/dotnet/6.0) and [.NET Core 3.1](https://dotnet.microsoft.com/en-us/download/dotnet/3.1)
- Download [Postgresql 14](https://www.postgresql.org/download/) and the database [bdmembro.sql](https://drive.google.com/uc?export=download&id=1CBMw3bkuhSYfq3T0mT8TFVS2RZp5u1YJ)
- Download [VS Code](https://code.visualstudio.com/) and [C# Extension for VS Code](https://marketplace.visualstudio.com/items?itemName=ms-dotnettools.csharp)

##### 2. Setting up the database:
- Open up pgAdmin 4 and determine your credentials.
- Right click databases under PostgreSQL 14 and create one.
- Right click your database and Restore, in the Filename field input the path to the bdmembro.sql file and click restore.
- If asked for a proper binary path, select File > Preferences > Paths > Binary Paths > Scroll down to PostgreSQL 14 and input the path to the bin folder (Default: C:\Program Files\PostgreSQL\14\bin).

##### 3. Clone and Run:
```bash
git clone https://github.com/geracao/gen-crud-api.git
```
- Input your Postgresql (password and port) credentials in the appsettings.Development.json file 
- Run the project.
- Insert /swagger at the end of the URL to view the API.
- Works in conjunction with this [web project](https://github.com/geracao/gen-crud-web).
- Enjoy.

## :memo: License
This project is under the MIT license. See the [LICENSE](./LICENSE) file for more details.

<p align="right">(<a href="#top">back to top</a>)</p>
