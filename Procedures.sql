/*********************
 * Query
 *********************/

 --Show tournament winner
DECLARE @TournamentID AS INT = 3;


SELECT TOP 1 COUNT(*) AS TournamentWinner, Winner
FROM TournamentGame
WHERE TournamentID = @TournamentID
GROUP BY Winner
ORDER BY COUNT(*) DESC
GO;

--Show player who used specific "Character" with highest win percentage

CREATE PROCEDURE CharacterWinPercentage @CharacterName NVARCHAR(32)
AS

    WITH TournemantRecordsCTE(Wins, Loss, TeamID, TeamName, Player1, Player2, Player3, Player4, Player5) AS
    (
        SELECT CAST((substring(Record, 1, CHARINDEX('-', Record) -1)) AS FLOAT) AS Wins,
        CAST((substring(Record, CHARINDEX('-', Record) + 1 ,3)) AS FLOAT) AS Loss,
        TeamID, TeamName, Player1, Player2, Player3, Player4, Player5
        FROM Team T
    )
    SELECT CT.Wins, CT.Loss, PlayerName, CT.TeamName, FORMAT(CT.Wins/(CT.Wins + CT.Loss), 'P2') AS [WinPercentage]
    FROM TournemantRecordsCTE CT
        INNER JOIN Player P ON CT.Player1 = PlayerID
        OR CT.Player2 = PlayerID OR CT.Player3 = PlayerID
        OR CT.Player4 = PlayerID OR CT.Player5 = PlayerID
    WHERE Main = @CharacterName
    ORDER BY WinPercentage DESC
GO;


EXECUTE CharacterWinPercentage @CharacterName = 'Baptiste';
GO;

--Rank Team Average kills per game
-- CREATE PROCEDURE TeamAvereageKillPerGame
-- AS

--     WITH PlayerCTE() AS
--     (
--         SELECT
--         FROM PlayerGame
--             INNER JOIN Player ON Player.PlayerID = PlayerGame.PlayerID

--         --Return average kills Return number of games (total)
--     )
--     SELECT
--     FROM PlayerCTE CT
--         INNER JOIN Team ON T.Player1 = CT.PlayerID
--         OR T.Player2 = CT.PlayerID OR T.Player3 = CT.PlayerID
--         OR T.Player4 = CT.PlayerID OR T.Player5 = T.PlayerID

-- RANK() OVER (
-- [PARTITION BY expression, ]
-- ORDER BY expression (ASC | DESC) );

-- Rank team with highest win percentage on specific map

-- CREATE PROCEDURE RankMapWinPercentage
-- AS

--Rank Player by kills per game in specific tournament
-- CREATE PROCEDURE RankKillsPerGameTournament
-- AS


    



--Update Email
CREATE PROCEDURE UpdatePlayerEmail @PlayerName NVARCHAR(32), @Email NVARCHAR(32)
AS
    UPDATE Player
    SET Email = @Email
    WHERE PlayerName = @PlayerName

EXECUTE UpdatePlayerEmail @PlayerName = 'Gator', @Email = 'gator2@gmail.com';
GO;


--Add New Player
CREATE PROCEDURE AddNewPlayer @PlayerName NVARCHAR(32), @TotalKills INT, 
    @Main NVARCHAR(32), @Role NVARCHAR(32), @Email NVARCHAR(32)
AS
    INSERT INTO Player (PlayerName, TotalKills,  Main, Role, Email)
    VALUES (@PlayerName, @TotalKills, @Main, @Role, @Email);

EXECUTE AddNewPlayer @PlayerName = 'BigToe', @TotalKills = '200', @Main = 'Moira', @Role = 'Support', @Email = 'yutowada04@gmail.com';
EXECUTE AddNewPlayer @PlayerName = 'Pumpkin', @TotalKills = '900', @Main = 'Mercy', @Role = 'Support', @Email = 'pumpkin@gmail.com';
EXECUTE AddNewPlayer @PlayerName = 'Joe', @TotalKills = '1000', @Main = 'Cassidy', @Role = 'DPS', @Email = 'joe@gmail.com';
EXECUTE AddNewPlayer @PlayerName = 'patch', @TotalKills = '1475', @Main = 'Echo', @Role = 'DPS', @Email = 'patch@gmail.com';
EXECUTE AddNewPlayer @PlayerName = 'tanky', @TotalKills = '1589', @Main = 'Zarya', @Role = 'Tank', @Email = 'tanky@gmail.com';
GO;


--Add new Teams

CREATE PROCEDURE AddNewTeam @Coach NVARCHAR(32), @Record NVARCHAR(32), @TeamName NVARCHAR(32), 
    @Player1 INT, @Player2 INT, @Player3 INT, @Player4 INT, @Player5 INT 
AS
    INSERT INTO Team(Coach, Record, TeamName, Player1, Player2, Player3, Player4, Player5)
    VALUES (@Coach, @Record, @TeamName, @Player1, @Player2, @Player3, @Player4, @Player5);

SET IDENTITY_INSERT [Team] ON;


EXECUTE AddNewTeam @Coach = 'Sour Patch Kids', @Record = '60-54', @TeamName = 'Kansas State Wildcats', @Player1 = 101, @Player2 = 102,  @Player3 = 103, @Player4 = 104, @Player5 = 105
GO;
--Update the winner on TournamentGame
CREATE PROCEDURE EditWinnerTournamentGame @TournamentID INT, @Team1Name NVARCHAR(32), @Team2Name NVARCHAR(32), @Winner NVARCHAR(32)
AS
    UPDATE TournamentGame
    SET Winner = @Winner
    WHERE ((Team1 = @Team1Name AND Team2 = @Team2Name) OR (Team1 = @Team2Name AND Team2 = @Team1Name)) AND TournamentID = @TournamentID
