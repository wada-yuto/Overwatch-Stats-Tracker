/******************
 * Insert Data
 ******************/
BULK INSERT Championship.Character
FROM 'C:\Users\yutow\Desktop\CIS560Project\CSV\Characters.csv'
WITH
 (
     ROWTERMINATOR='\n',
     FIELDTERMINATOR=','
 );

BULK INSERT Championship.Player
FROM 'C:\Users\yutow\Desktop\CIS560Project\CSV\Players.csv'
WITH
 (
     ROWTERMINATOR='\n',
     FIELDTERMINATOR=','
 );

BULK INSERT Championship.Team
FROM 'C:\Users\yutow\Desktop\CIS560Project\CSV\Team.csv'
WITH
 (
     ROWTERMINATOR='\n',
     FIELDTERMINATOR=','
 );
 

BULK INSERT Championship.Tournament
FROM 'C:\Users\yutow\Desktop\CIS560Project\CSV\Tournament.csv'
WITH
 (
     ROWTERMINATOR='\n',
     FIELDTERMINATOR=','
 );

BULK INSERT Championship.PlayerGame
FROM 'C:\Users\yutow\Desktop\CIS560Project\CSV\PlayerGame.csv'
WITH
 (
     ROWTERMINATOR='\n',
     FIELDTERMINATOR=','
 );

BULK INSERT Championship.TournamentGame
FROM 'C:\Users\yutow\Desktop\CIS560Project\CSV\TournamentGame.csv'
WITH
 (
     ROWTERMINATOR='\n',
     FIELDTERMINATOR=','
 );

SELECT * FROM Championship.[TournamentGame]
