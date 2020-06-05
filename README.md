# Ticket-Management-System
TMS - Ticket Managemente System - Sistema para avaliação vaga backend BuildOne


> Management System to create, edit, delete and resolve tickets.


# Future Improvements

These are a list of future improvements:

* Implement a authentication method to ensure that the user logged in will just see and edit only its tickes.
* Use the authentication to ensure that only Key-users could resolve tickets.
* Insert a fiedl to make possible to users upload images with errors helping TI specialist resolve tickets.
* Create a method to warn (alerts) about tickets open for a while.
* Improve de front-end with UI/UX techniques


## Installation

.NET 3.1.202

```
https://dotnet.microsoft.com/download/dotnet-core/3.1
```

Docker

```
https://hub.docker.com/editions/community/docker-ce-desktop-windows/
```

MS-SQL Image

```
docker pull microsoft/mssql-server-linux:2017-latest
```

Docker Run

```
docker run -e 'ACCEPT_EULA=Y' -e 'MSSQL_SA_PASSWORD=Passw0rd' -p 1433:1433 --name sqlserver1 -d microsoft/mssql-server-linux:2017-latest
```

Docker Start

```
docker start sqlserver1
```

## Using Azure Data Studio

Creating Database

```
USE master
GO
IF NOT EXISTS (
    SELECT [name]
        FROM sys.databases
        WHERE [name] = N'TicketManagementSystem'
)
CREATE DATABASE TicketManagementSystem
GO
```

Creating Table

```
IF OBJECT_ID('[dbo].[Tickets]', 'U') IS NOT NULL
DROP TABLE [dbo].[Tickets]
GO

CREATE TABLE [dbo].[Tickets](

[Id] [int] IDENTITY (1,1) NOT NULL,
[Title] [varchar] (256) NOT NULL,
[Description] [varchar] (1024) NULL,
[EnteredOn] [date] NOT NULL,
[Email] [varchar] NOT NULL,
[Priority] [varchar] (10) NOT NULL,
[Status] [varchar] (10) NOT NULL

);
GO
```

Creating User

```
USE master

GO

CREATE LOGIN webapp WITH PASSWORD=N'Passw0rd!', DEFAULT_DATABASE=TicketManagementSystem

GO

ALTER LOGIN webapp ENABLE

GO

USE TicketManagementSystem

GO

CREATE USER webapp FOR LOGIN webapp
EXEC sp_addrolemember 'db_owner', 'webapp'

GO
```

Running dotnet

```
dotnet run
```

Access localhost

```
http://localhost:5000
```


## Built With

* [ASP.NET Core 3.1.202](https://dotnet.microsoft.com/download/dotnet-core/3.1)
* [Visual Studio Code](https://code.visualstudio.com/)
* [Azure Data Studio](https://docs.microsoft.com/pt-br/sql/azure-data-studio/download-azure-data-studio?view=sql-server-ver15)
* [SQL Server](https://www.microsoft.com/pt-br/sql-server/sql-server-downloads)
* [Entity Framework](https://docs.microsoft.com/pt-br/ef/)


## Personal Inofrmation

João Guilherme Guimarães Almeida

Contact:

* [LinkedIn](https://www.linkedin.com/in/jo%C3%A3o-g-g-almeida/ "LinkeId")
* [Github](https://github.com/jggalmeida "Github Profile")
* [E-mail](mailto:j.g.almeida@hotmail.com)
