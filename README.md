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
* Install [Postman](https://www.postman.com/)

## **SETUP**


copy this url to clone this project to your local system:
```html
https://github.com/jhenager/PortlandBusiness.Solution.git
```

<br>

Once copied, select "Clone Repository" from within VSCode & paste the copied link.

<br>

With the project open to the root directory, navigate to the production directory with the following command in your terminal.
```js 
cd PortlandBusiness
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
First, you will need to update the username and password in the appsettings.json file to match your local username and password. Replace the word "root" with your username, and the word "epicodus" with your password. Be sure to leave the "u" and "p" in there as they stand for username and password respectively.
<br>
Because the project already has migrations and seeded data, all you will need to do is update the database.

```
dotnet ef database update
```


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
## **Using Postman to query the database**

## **QUESTIONS AND CONCERNS**

_Questions, comments and concerns can be directed to James Henager (jameschenager@gmail.com)_

<br>

## **Technologies Used**

_**Written in:** [Visual Studio Code](https://code.visualstudio.com/)_

_**Database Mgmt:** [MySql Workbench](https://www.mysql.com/products/workbench/)_

<br>