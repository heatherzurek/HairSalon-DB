# _Hair Salon_

#### _A web application where you can add stylists, and add that stylists specific clients_

#### By _**Heather Zurek**_

## Description

| Behavior | Input | Output |
| ------------- |:-------------:| -----:|
| Add a new Stylist | "Dwight" | "Dwight" will added to database and list |
| Add a new Client | "Jim" | "Jim" will be added to the database and client light for "Dwight" |
| View list of Stylists | Select stylist name from list to view | "Dwight" |
| View list of that Stylists clients | Select clients name from stylist list to view | "Jim" |

## Setup with importing SQL files

* _Clone this repo to your home machine_
* _Start MAMP_
* _Start Servers_
* _Click Open WebStart page_
* _On the webpage that opens, click Tools and choose PHPMYADMIN_
* _Create new database named heather_zurek_
* _Select the Import tab_
* _Select the heather_zurek.sql file and click Go_
* _Navigate the terminal to the HairSalon directory_
* _enter $ dotnet run_
* _Open browser to localhost:5000 to use the app_

## Setup Database Instructions

* _Open terminal_
* _Run mysql -uroot -proot_
* _CREATE DATABASE 'heather_zurek'_
* _CREATE TABLE `stylists`_
* _(`name` varchar(255),`id` int(11))_
* _CREATE TABLE `clients`_
* _(`name` varchar(255), `id` int(11),`stylist_id` int(11))_


## Known Bugs

_No Known Bugs🐛🐞_

## Support and contact details

_If you have any questions or concerns please contact me at heather.zurek@gmail.com_

## Technologies Used

_C#, SQL, HTML, CSS, BOOTSTRAP_

### License

*GPL*

Copyright (c) 2019 **_Heather Zurek_**
