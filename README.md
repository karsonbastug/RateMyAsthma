# Changes for Chase/Noah

## Database Changes

The database schema had to be changed. Because it involved changing Primary Keys, the tables will have to be remade. This sounds bad but its really easy. In the database creation tab I added the code, just simple run the drop table in the ordered listed, then rebuild the tables, and re-insert the data. There is also a lot of new data to be inserted. Additionnaly, if any of your SP run the line (table).WID, the .WID needs to be changed to .LID.







## [Project Proposal](https://github.com/karsonbastug/RateMyAsthma/blob/master/RateMyAsthma/Proposal.md)

## [API Documentation](AsthmaAPI/README.md)

### Karson Bastug SP Change Notice
There has been an additional Stored Procedure created, named GetCity1. Additionally, GetRatingsForHighTemp has been modified. You will have to drop then recreate the stored procedure, which that command is commented out to make it easy.

[NewStoredProcedures](https://github.com/karsonbastug/Assignment3/blob/main/KarsonBastugSps.sql)


