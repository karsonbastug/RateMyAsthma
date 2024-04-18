# Changes for Joshua Meadows
## Database Changes
Our database had to be changed, so you will have to re-create the tables and re-insert their tables. The links to which are provided below:
<br>
[Database Table Changes](https://github.com/karsonbastug/Assignment3/blob/main/FinalDatabaseCreation.sql)
<br>
[New Data Entries](https://github.com/karsonbastug/Assignment3/blob/main/FinalDataInsert.sql)
<br>
## Stored Procedure Changes 
Our stored procedures have udnergone A LOT of changes. You will have to drop the old ones and create our new ones, but don't worry! The links to which are provided below, which comments telling you whether you will have to drop and re-create or if its a new stored procedure you can just simply create.
<br>
[KarsonNewStoredProcedures](https://github.com/karsonbastug/Assignment3/blob/main/KarsonBastugSps.sql)
<br>
[ChaseNewStoredProcedures](https://github.com/karsonbastug/Assignment3/blob/main/ChaseBakerSps.sql)
<br>
[NoahNewStoredProcedures](https://github.com/karsonbastug/Assignment3/blob/main/NoahStalnakerSps.sql)

## Assignment 5 - Who Did What?

### Karson Bastug
   - Link 1
   - Link 2
     
<br>

### Chase Baker
   - [ACustomSearchWebPage](https://github.com/karsonbastug/RateMyAsthma/blob/master/RateMyAsthma/Pages/ACustomSearch.cshtml)
   - [AReviewWebPage](https://github.com/karsonbastug/RateMyAsthma/blob/master/RateMyAsthma/Pages/AReview.cshtml)
     
<br>

### Noah Stalnaker
   - Link 1
   - Link 2
     


<br>
<br>
<--------------------------------------------------------------------------------------------------------------------->

# Project Guide

1. Project Intro and Status
2. Project Overview
3. Deployment Guide
   - Setting up the Database
   - Cloning the Repository
   - Configuring the Application
   - Testing and Troubleshooting
   - Pitfalls
5. Note For Developer
6. API Documentaiton

<--------------------------------------------------------------------------------------------------------------------->
# 1. Project Intro and Status
This website was created by Chase Baker, Karson Bastug, and Noah Stalnaker for MIST 353 at West Virginia University in Spring of 2024. As of April 2024, it is not no longer being worked on.

# 2. Project Overview
Our website, titled "Rate My Asthma", utilizes MS Visual Studio and MS SQL Server Management to create a website where users rate how bad their asthma was in certain cities across the United States. Users can leave reviews, or customize what other reviews they see. By allowing users to rate and see other reviews on how bad their asthma was in certain cities, users can better plan to manage their health and happiness.

<--------------------------------------------------------------------------------------------------------------------->

# 3. Deployment Guide

## Setting up the Database

1. We all created separate stored proecdures, all of which will need to be made. But first, connect to the SQL Server instance on the VM using SQL Server Management Studio (SSMS).
   - Create a new database for your application, and name is "Asthma"
   - [SQL Tables For Database](https://github.com/karsonbastug/Assignment3/blob/main/FinalDatabaseCreation.sql)
   - [SQL Data For Tables](https://github.com/karsonbastug/Assignment3/blob/main/FinalDataInsert.sql)
   - [KarsonNewStoredProcedures](https://github.com/karsonbastug/Assignment3/blob/main/KarsonBastugSps.sql)
   - [ChaseNewStoredProcedures](https://github.com/karsonbastug/Assignment3/blob/main/ChaseBakerSps.sql)
   - [NoahNewStoredProcedures](https://github.com/karsonbastug/Assignment3/blob/main/NoahStalnakerSps.sql)

## Cloning the Repository

1. Clone the repository of your Visual Studio website to your local machine.
   - Ensure the repository includes necessary files.

## Configuring the Application

1. Update the database connection string in the application's configuration files.
   - Make any other necessary configuration changes.

## Testing and Troubleshooting

1. Access the application URL in a web browser.
   - Test all functionality, including database interactions.
   - Monitor logs and error messages for issues.
   - Seek help from online resources if needed.

## Pitfalls

1. Make sure everything is copied 1-1 except the connection strings
   - Pay close attention to the stored procedures and their entity tables, any modification to the SP select statement and it will not work
2. Dependent on your local machine if not running a VM
3. Make sure to configure files in the right order (Pages first, then API)

<--------------------------------------------------------------------------------------------------------------------->

# 4. Note For Developers

For anyone interested in working on this/taking it over, its important to consider:
1. The cities users are able to review are dependent on if they are in the database
     - The "request a city" button does not store that information anywhere
     - Consider allowing users to input a city, or use an external API
2. There is a hard coded limit on how many reviews can be displayed (5)
     - Consider exploring options like displaying reviews with a drop down, displaying 1 reivew at a time with an option for a next arrow, etc.
3. Adding a username/password system so people can keep track of their own reviews
     - Be mindful of privacy, as you are using health data

<--------------------------------------------------------------------------------------------------------------------->

# 5. API Documentation
[Link to API Documentation](AsthmaAPI/README.md)


