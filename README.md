# Project_8_CMPS358
CMPS 358 Programming Project #8


Project Description:


1. Work the tutorial as given in “10e_AnotherDatabaseTutorial_world.pdf”.


2. When the tutorial is complete, create additional static methods in class Program as follows:

(a) Create a static method that uses LINQ and / or extensions to find then list all countries in a continent
entered or chosen by the user. The countries are to be listed in alphabetical order.

(b) Create a static method that uses LINQ and / or extensions to find then list the country, continent,
region and country code of all countries that begin with the letter entered by the user.

(c) Create a static method that uses LINQ and / or extensions to find and then list information about a
city. The user is to enter the name of city to be listed. Every instance of a city with the entered
name is to be displayed, including the city name, population, district, country and country code. (For
instance, there is a London in the United Kingdom and in Canada.)


Tip: One possible part of the solution is to create a private method that returns the name of a
country when passed the country code.


3. Comment out the code in method Main as created for the tutorial.


4. Create a menu driven system that starts when the project is launched and continues until the user elects
to stop. The menu driven system allows the user to choose from a menu to manipulate the data stored in
the database by selecting to call the methods as implemented in step #2 and in the tutorial.


Example Run:


1 - List Cities by Country

2 - List Countries by Continent

3 - List Countries by First Letter

4 - List Information for a City

0 - Exit


(User Input: 1)


Enter Country: Ireland

Cities in Ireland

Cork

Dublin


1 - List Cities by Country

2 - List Countries by Continent

3 - List Countries by First Letter

4 - List Information for a City

0 - Exit

(User Input): 2

Enter the continent: Oceania

American Samoa

Australia

Christmas Island

Cocos (Keeling) Islands

Cook Islands

Fiji Islands

French Polynesia

Guam

Kiribati

Marshall Islands

Micronesia, Federated States of

Nauru

New Caledonia

New Zealand

Niue

Norfolk Island

Northern Mariana Islands

Palau

Papua New Guinea

Pitcairn

Samoa

Solomon Islands

Tokelau

Tonga

Tuvalu

United States Minor Outlying Islands

Vanuatu

Wallis and Futuna


1 - List Cities by Country

2 - List Countries by Continent

3 - List Countries by First Letter

4 - List Information for a City

0 - Exit

(User Input): 3

Enter the first letter of countries to list: Z

Zambia, Continent: Africa, Region: Eastern Africa, code: ZMB

Zimbabwe, Continent: Africa, Region: Eastern Africa, code: ZWE


1 - List Cities by Country

2 - List Countries by Continent

3 - List Countries by First Letter

4 - List Information for a City

0 - Exit

(User Input): 4 

Enter City (case counts): London

City: London

Population: 7285000

District: England

Country: United Kingdom

CountryCode: GBR

City: London

Population: 339917

District: Ontario

Country: Canada

CountryCode: CAN


1 - List Cities by Country

2 - List Countries by Continent

3 - List Countries by First Letter

4 - List Information for a City

0 - Exit

(User Input): 0

Bye!

General requirements:

• At the top of each file containing your C# code, insert the following comments:

// your-name

// your-ulid

// CMPS 358

// project #the-number-of-the-project


Submitting


When the project is complete and runs correctly, clean the project, zip the project folder into a zip
archive, name the zip archive “p8_your-ulid.zip” and upload it in Moodle
