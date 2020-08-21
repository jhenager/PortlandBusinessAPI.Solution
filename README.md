**<h1 align = "center"> Portland Businesses API**

**<h3 align="center">API made for Epicodus to demonstrate understanding of API creation in ASP.net core mvc using SQL with Entity framework and Swagger Documentation**

**ABOUT**

</p>

_This API is designed to catal_


## **REQUIREMENTS**

* Install [Git v2.62.2+](https://git-scm.com/downloads/)
* Install [.NET version 3.1 SDK v2.2+](https://dotnet.microsoft.com/download/dotnet-core/2.2)
* Install [Visual Studio Code](https://code.visualstudio.com/)
* Install [MySql Workbench](https://www.mysql.com/products/workbench/)

## **SETUP**


copy this url to clone this project to your local system:
```html
https://github.com/jhenager/DrSneuss.Solution.git
```

<br>

Once copied, select "Clone Repository" from within VSCode & paste the copied link.

<br>

With the project open to the root directory, navigate to the production directory with the following command in your terminal.
```js 
cd DrSneuss
```

Then, install the necessary packages with the following command
```js 
dotnet restore 
```

Finally, you can start the program with this command.
```js 
dotnet run 
```
## **Setting up the database**
<br>
Next we will need to setup our MySql database for the application to work.
<br>
One method is to directly import the 'james_henager.sql' file included in the repo to MySQL workbench.
<br>
The other option is to open MySql Workbench and select "Create a new Sql Tab for Executing Queries" at the very top left of the page. Then paste this information onto the page:
<br>

```
CREATE DATABASE `james_henager` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci */;
USE DATABASE `james_henager`
CREATE TABLE `Engineers` (
  `EngineerId` int(11) NOT NULL AUTO_INCREMENT,
  `EngineerName` longtext,
  PRIMARY KEY (`EngineerId`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
CREATE TABLE `MachineEngineer` (
  `MachineEngineerId` int(11) NOT NULL AUTO_INCREMENT,
  `MachineId` int(11) NOT NULL,
  `EngineerId` int(11) NOT NULL,
  PRIMARY KEY (`MachineEngineerId`),
  KEY `IX_MachineEngineer_EngineerId` (`EngineerId`),
  KEY `IX_MachineEngineer_MachineId` (`MachineId`),
  CONSTRAINT `FK_MachineEngineer_Engineers_EngineerId` FOREIGN KEY (`EngineerId`) REFERENCES `engineers` (`EngineerId`) ON DELETE CASCADE,
  CONSTRAINT `FK_MachineEngineer_Machines_MachineId` FOREIGN KEY (`MachineId`) REFERENCES `machines` (`MachineId`) ON DELETE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
CREATE TABLE `Machines` (
  `MachineId` int(11) NOT NULL AUTO_INCREMENT,
  `MachineName` longtext,
  `Date` datetime(6) NOT NULL DEFAULT '0001-01-01 00:00:00.000000',
  `MachineError` longtext,
  PRIMARY KEY (`MachineId`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
```
#### **Then, you need to update your username and password in the appsettings.json file.**

_by default these are set to user:root and an empty password. if you are unsure, refer to the settings for your MySqlWorkbench._


<br>

<br>

## **PROTECTING YOUR DATA**

#### **Step 1: From within VSCode in the root project directory, we will create a .gitignore file**

# For ![l-top](https://github.com/ryanoasis/nerd-fonts/wiki/screenshots/v1.0.x/mac-pass-sm.png)
```js 
touch .gitignore 
```

# For ![l-top](https://github.com/ryanoasis/nerd-fonts/wiki/screenshots/v1.0.x/windows-pass-sm.png)

```js 
ni .gitignore 
```

#### Step 2: Add the following to your .gitignore file (this protects your sensitive data). 
**DO NOT PROCEED UNTIL YOU DO!**


```
node_modules/
.DS_store
dist/
appsettings.json
bin/
obj/
```

#### Step 3: **To commit your .gitignore file enter the following commands**

```js
git add .gitignore
```
```js
git commit -m "protect data"
```


## **QUESTIONS AND CONCERNS**

_Questions, comments and concerns can be directed to James Henager (jameschenager@gmail.com)_

<br>

## **Technologies Used**

_**Written in:** [Visual Studio Code](https://code.visualstudio.com/)_

_**Database Mgmt:** [MySql Workbench](https://www.mysql.com/products/workbench/)_

<br>