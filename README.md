# inventory-managment-system-university-project
## Technology stack:
#### .NET Framework v4.7.2
#### Entity Framework 6(Database First)
#### MS Sql

## ER Diagram:
![image](https://user-images.githubusercontent.com/47367245/83940807-d0cbcf80-a7f7-11ea-8b66-2ca60da7ce6c.png)\

Inventory management system is a large and complex system. The project consists of several modules. There are basically 2 management systems. A normal company can order the products they want by registering themselves and the products can be ordered and confirmed by the admin. The MS Sql server was used as the database and the Entity Framework to connect to the database.
## Login Page:
![image](https://user-images.githubusercontent.com/47367245/83322001-44ecfd00-a265-11ea-984a-2993943680eb.png)\
In the opening window of the program we are greeted by an entry. Directs to the appropriate forms based on the information entered. There are 2 main forms. Intended for 1st user and intended for 2nd admin. The role of each registered user is user.
## Registeration:
![image](https://user-images.githubusercontent.com/47367245/83322025-71a11480-a265-11ea-9a03-e9befd32ce2d.png)\
By filling in all the information shown in the image, a suitable user is created in the database.
## Admin Panel:
![image](https://user-images.githubusercontent.com/47367245/83322060-bb89fa80-a265-11ea-8e66-5d54a8c12025.png)\
There is user information on the top left of the admin panel. There are 5 best-selling and latest-sold products in the middle. At the bottom right there is a daily changing currency table with API. Below you can see the User, Product and invoice number.
## Product:
![image](https://user-images.githubusercontent.com/47367245/83322072-d5c3d880-a265-11ea-83d7-9bd0b84c9f5c.png)\
It is possible to manage products in this window. You can add new products, change or delete existing ones. It is possible to perform a real-time search in the upper right.
## Users:
![image](https://user-images.githubusercontent.com/47367245/83322091-f3913d80-a265-11ea-9544-fe861d3ed08b.png)
![image](https://user-images.githubusercontent.com/47367245/83322096-fc820f00-a265-11ea-9895-24ecdba41171.png)\
On this page, the admin can change and view some of the users' information. In the window on the right, each user can change his name, password, e-mail and profile picture.
## Orders:
![image](https://user-images.githubusercontent.com/47367245/83322117-1facbe80-a266-11ea-90d5-3412b8730e93.png)\
Here the admin can select and order products for any company, but a normal user can only create an order for the registered company. When creating an order, money in other currencies is converted into AZN based on the daily currency.\
![image](https://user-images.githubusercontent.com/47367245/83322125-3c48f680-a266-11ea-8948-d3ca59b01eab.png)\
This window is for managing orders. The background of pre-created invoice orders is green, and you cannot re-create and delete them invoice. (Error)
## Invoice:
![image](https://user-images.githubusercontent.com/47367245/83322147-5f73a600-a266-11ea-9246-b153d89c4fc6.png)\
Such a window opens when an invoice is created from any order. You can choose any product from the right. When an invoice is created, the product table is subtracted from the total number of products sold to the number sold.\
![image](https://user-images.githubusercontent.com/47367245/83322159-71eddf80-a266-11ea-8eb3-ecf6c2178afa.png)\
Here you can look at created invoices and invoice products. You can send or print the Invoice spreadsheet as an Excel file to the login user.
## Categories:
![image](https://user-images.githubusercontent.com/47367245/83322174-8631dc80-a266-11ea-85be-f977db6cc5e6.png)\
In this window you can add and edit categories.
## User Page:
![image](https://user-images.githubusercontent.com/47367245/83322185-98137f80-a266-11ea-85f4-44c86fb30c80.png)\
This page is for regular users only. Here the user can see his order number and create a new order.

