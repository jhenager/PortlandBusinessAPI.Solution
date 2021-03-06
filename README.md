**<h1 align = "center"> Portland Businesses API**

**<h3 align="center">API made for Epicodus to demonstrate understanding of API creation in ASP.net core mvc using SQL with Entity framework and Swagger Documentation**

**ABOUT**

</p>

_This API is designed to collect and display all of Portland, Oregon's finest restaurants and shops. It can be utilized with a front-end application such as .NET MVC, or queried independently._


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

First we are going to start a localhost server in the PortlandBusiness project folder. In the command line enter:
```
dotnet watch run
```

Once the project has built, Open Postman and Click on the plus sign in the middle of the page (or the plus sign that says "New" in the corner).
<br>

#### **GET Request**
To get all of either the Restaurants or Shops in this API and view them enter "http://localhost5000/api/restaurants" or "http://localhost5000/api/shops" respectively into the search bar with "GET" selected on the dropdown. Results will look like:
```
[
  {
    "restaurantId": 1,
    "name": "Ground Kontrol",
    "type": "Bar",
    "description": "Downtown Arcade Bar"
  },
  {
    "restaurantId": 2,
    "name": "Laurelhurst Market",
    "type": "Steakhouse",
    "description": "Restaurant and Deli providing fine meats"
  },
  {
    "restaurantId": 3,
    "name": "Soro Soro",
    "type": "Dessert",
    "description": "Korean desserts and coffee drinks"
  },
  ```
  #### **GET ID Request**
To get one particular Restaurant or Shop in this API and view them enter "http://localhost5000/api/restaurants/1" or "http://localhost5000/api/shops/1" respectively into the search bar with "GET" selected on the dropdown. The "1" in the url can be replaced with any other number to retrieve the object with that ID. Click Send, results will look like:
```
  {
    "restaurantId": 1,
    "name": "Ground Kontrol",
    "type": "Bar",
    "description": "Downtown Arcade Bar"
  },
  ```
  #### **Post Request**
To add an entry to either the Restaurants or Shops in this API enter "http://localhost5000/api/restaurants" or "http://localhost5000/api/shops" respectively into the search bar with "Post" selected on the dropdown. Before clicking send, click on the tab marked body, the click on the radio button that saws raw. Paste the following into the body, replace the values with the values you wish and click send.
```
{
  "restaurantId": 0,
  "name": "string",
  "type": "string",
  "description": "string"
}
```

#### **Put Request**
To edit an entry in either Restaurants or Shops in this API enter "http://localhost5000/api/restaurants/1" or "http://localhost5000/api/shops/1" respectively into the search bar with "Put" selected on the dropdown. Replace the "1" with the id of the entry you would like to edit. Before clicking send, click on the tab marked body, the click on the radio button that saws raw. Paste the following into the body, replace the values with the values you wish and click send.
```
{
  "restaurantId": 0,
  "name": "string",
  "type": "string",
  "description": "string"
}
```

#### **Delete Request**
To add an entry to either the Restaurants or Shops in this API enter "http://localhost5000/api/restaurants/1" or "http://localhost5000/api/shops/1" respectively into the search bar with "Delete" selected on the dropdown.  Replace the "1" with the id of the entry you would like to delete. Click send to delete the entry.
<br>

## **Viewing Swagger Documentation**
To view all of the API's endpoint documentation with swagger, first make sure a live server is running. If it isn't, navigate into the PortlandBusiness project folder in the command line and enter:
```
dotnet watch run
```
Then in your web browser, navigate to "http://localhost5000/swagger"
<br>
Click on each tab and experiment with the "try it out" button to see how the different endpoints function.

## **QUESTIONS AND CONCERNS**

_Questions, comments and concerns can be directed to James Henager (jameschenager@gmail.com)_

<br>

## **Technologies Used**

_**Written in:** [Visual Studio Code](https://code.visualstudio.com/)_

_**Database Mgmt:** [MySql Workbench](https://www.mysql.com/products/workbench/)_

<br>