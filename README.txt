At the root level of the file, you will find the following:
    -Data.sql
    -Procedures.sql
    -Tables.sql
    -CSV
    -ApexProjectApplication
    -BACPAC

Tables.sql contains sql code that creates table in database
Data.sql contains sql code that imports data from CSV into the Tables
Procedures.sql contais 4 aggredated queries and 4 INSERT/UPDATE statements

CSV Folder contains all the CSV files that are used in Data.sql to import data into the table
ApexProjectApplication Folder contains the C# Desktop Application Solution 
BACPAC Folder contains OverwatchDB.bacpac file, which can be used to import our database into any local machine