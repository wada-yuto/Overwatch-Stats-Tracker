/*********************
 * Query
 *********************/

--Show tournament winner
CREATE PROCEDURE FindTournamentWinner
    @TournamentID INT
AS

    SELECT TOP 1
        COUNT(*) AS TournamentWinner, Winner
    FROM TournamentGame
    WHERE TournamentID = @TournamentID
    GROUP BY Winner
    ORDER BY COUNT(*) DESC

EXECUTE FindTournamentWinner @TournamentID = 1;
GO;

--Show player who used specific "Character" with highest win percentage

CREATE PROCEDURE CharacterWinPercentage
    @CharacterName NVARCHAR(32)
AS

WITH
    TournemantRecordsCTE(Wins, Loss, TeamID, TeamName, Player1, Player2, Player3, Player4, Player5)
    AS
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
CREATE PROCEDURE TeamAvereageKillPerGame
AS

    WITH
        PlayerCTE(TotalKills, PlayerID, TotalGames, PlayerName)
        AS
        (
            SELECT SUM(Kills) AS TotalKills, P.PlayerID, COUNT(PlayerGameID) AS TotalGames,
                P.PlayerName
            FROM PlayerGame PG
                INNER JOIN Player P ON P.PlayerID = PG.PlayerID
            GROUP BY P.PlayerID, P.PlayerName
            --Return average kills Return number of games (total)
        )
    SELECT T.TeamName, T.Coach, FORMAT(CAST(SUM(CT.TotalKills) AS FLOAT)/CAST(SUM(CT.TotalGames) AS FLOAT), 'N2') AS [KillAverage],
        CAST((substring(T.Record, 1, CHARINDEX('-', T.Record) -1)) AS FLOAT) AS Wins,
        CAST((substring(T.Record, CHARINDEX('-', T.Record) + 1 ,3)) AS FLOAT) AS Loss
    FROM PlayerCTE CT
        INNER JOIN Team T ON T.Player1 = CT.PlayerID
            OR T.Player2 = CT.PlayerID OR T.Player3 = CT.PlayerID
            OR T.Player4 = CT.PlayerID OR T.Player5 = CT.PlayerID
    GROUP BY T.TeamName, T.Coach, T.Record
    ORDER BY KillAverage DESC


EXECUTE TeamAvereageKillPerGame;
GO;

-- SELECT * FROM TournamentGame TG WHERE TG.Map = 'Nepal';
-- Rank team with highest win percentage on specific map

CREATE PROCEDURE RankMapWinPercentage @MapName NVARCHAR(32)
AS
    
    SELECT T.TeamName,
        FORMAT(CAST((COALESCE(FirstTeam.FirstWins, 0) + COALESCE(SecondTeam.SecondWins, 0)) AS FLOAT)/
        CAST((COALESCE(FirstTeam.FirstGames, 0) + COALESCE(SecondTeam.SecondGames, 0)) AS FLOAT), 'P2') AS [WinPercentage]
    FROM
        (
            SELECT Team1, COUNT(*) AS FirstGames, SUM(CASE WHEN Team1 = Winner THEN 1 ELSE 0 END) AS FirstWins
            From TournamentGame
            WHERE Map = @MapName
            GROUP BY Team1
    ) FirstTeam 
    FULL JOIN
    (
        SELECT Team2, COUNT(*) AS SecondGames , SUM(CASE WHEN Team2 = Winner THEN 1 ELSE 0 END) AS SecondWins
        FROM TournamentGame
        WHERE Map = @MapName
        GROUP BY Team2
    )
        SecondTeam ON FirstTeam.Team1 = SecondTeam.Team2
        INNER JOIN Team T ON FirstTeam.Team1 = T.TeamID OR 
        SecondTeam.Team2 = T.TeamID
    ORDER BY WinPercentage DESC 
    GO;

EXECUTE RankMapWinPercentage @MapName = 'Nepal';
GO;


--Rank Player by kills per game in specific tournament
CREATE PROCEDURE RankKillsPerGameTournament
    @TournamentID INT
AS
    SELECT RANK() OVER(ORDER BY FORMAT((SUM(PG.Kills)/COUNT(PG.PlayerGameID)), 'N2') DESC) AS RANK,
        P.PlayerName, P.Main,
        FORMAT((SUM(PG.Kills)/COUNT(PG.PlayerGameID)), 'N2') AS KillsPerGame
    FROM PlayerGame PG
        INNER JOIN Player P ON P.PlayerID = PG.PlayerID
    WHERE PG.PlayerGameID BETWEEN ((@TournamentID - 1) * 7000) + 1 AND (@TournamentID * 7000)
    GROUP BY P.PlayerID, P.PlayerName, P.Main


EXECUTE RankKillsPerGameTournament @TournamentID; 
GO;



--Update Email
CREATE PROCEDURE UpdatePlayerEmail
    @PlayerName NVARCHAR(32),
    @Email NVARCHAR(32)
AS
UPDATE Player
    SET Email = @Email
    WHERE PlayerName = @PlayerName

EXECUTE UpdatePlayerEmail @PlayerName = 'Gator', @Email = 'gator2@gmail.com';
GO;


--Add New Player
CREATE PROCEDURE AddNewPlayer
    @PlayerName NVARCHAR(32),
    @TotalKills INT,
    @Main NVARCHAR(32),
    @Role NVARCHAR(32),
    @Email NVARCHAR(32)
AS
INSERT INTO Player
    (PlayerName, TotalKills, Main, Role, Email)
VALUES
    (@PlayerName, @TotalKills, @Main, @Role, @Email);

EXECUTE AddNewPlayer @PlayerName = 'BigToe', @TotalKills = '200', @Main = 'Moira', @Role = 'Support', @Email = 'yutowada04@gmail.com';
EXECUTE AddNewPlayer @PlayerName = 'Pumpkin', @TotalKills = '900', @Main = 'Mercy', @Role = 'Support', @Email = 'pumpkin@gmail.com';
EXECUTE AddNewPlayer @PlayerName = 'Joe', @TotalKills = '1000', @Main = 'Cassidy', @Role = 'DPS', @Email = 'joe@gmail.com';
EXECUTE AddNewPlayer @PlayerName = 'patch', @TotalKills = '1475', @Main = 'Echo', @Role = 'DPS', @Email = 'patch@gmail.com';
EXECUTE AddNewPlayer @PlayerName = 'tanky', @TotalKills = '1589', @Main = 'Zarya', @Role = 'Tank', @Email = 'tanky@gmail.com';
GO;

--Add new Teams

CREATE PROCEDURE AddNewTeam
    @Coach NVARCHAR(32),
    @Record NVARCHAR(32),
    @TeamName NVARCHAR(32),
    @Player1 INT,
    @Player2 INT,
    @Player3 INT,
    @Player4 INT,
    @Player5 INT
AS
INSERT INTO Team
    (Coach, Record, TeamName, Player1, Player2, Player3, Player4, Player5)
VALUES
    (@Coach, @Record, @TeamName, @Player1, @Player2, @Player3, @Player4, @Player5);

SET IDENTITY_INSERT [Team] ON;


EXECUTE AddNewTeam @Coach = 'Sour Patch Kids', @Record = '60-54', @TeamName = 'Kansas State Wildcats', @Player1 = 101, @Player2 = 102,  @Player3 = 103, @Player4 = 104, @Player5 = 105
GO;
--Update the winner on TournamentGame
CREATE PROCEDURE EditWinnerTournamentGame
    @TournamentID INT,
    @Team1ID INT,
    @Team2ID INT,
    @Winner NVARCHAR(32)
AS
    UPDATE TournamentGame
    SET Winner = @Winner
    WHERE ((Team1 = @Team1ID AND Team2 = @Team2ID) OR (Team1 = @Team2ID AND Team2 = @Team1ID)) AND TournamentID = @TournamentID
