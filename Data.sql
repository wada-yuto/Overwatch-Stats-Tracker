/******************
 * Insert Data
 ******************/
BULK INSERT Championship.Character
FROM 'C:\Users\yutow\Desktop\CIS560Project\Characters.csv'
WITH
 (
     ROWTERMINATOR='\n',
     FIELDTERMINATOR=','
 );

BULK INSERT Championship.Player
FROM 'C:\Users\yutow\Desktop\CIS560Project\Players.csv'
WITH
 (
     ROWTERMINATOR='\n',
     FIELDTERMINATOR=','
 );

BULK INSERT Championship.Team
FROM 'C:\Users\yutow\Desktop\CIS560Project\Team.csv'
WITH
 (
     ROWTERMINATOR='\n',
     FIELDTERMINATOR=','
 );
 

BULK INSERT Championship.Tournament
FROM 'C:\Users\yutow\Desktop\CIS560Project\Tournament.csv'
WITH
 (
     ROWTERMINATOR='\n',
     FIELDTERMINATOR=','
 );

BULK INSERT Championship.PlayerGame
FROM 'C:\Users\yutow\Desktop\CIS560Project\PlayerGame.csv'
WITH
 (
     ROWTERMINATOR='\n',
     FIELDTERMINATOR=','
 );

SELECT * FROM Championship.[PlayerGame]
