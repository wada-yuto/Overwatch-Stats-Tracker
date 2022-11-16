/*********************
 * Query
 *********************/

 --Show tournament winner
DECLARE @TournamentID AS INT = 3;

SELECT TOP 1 COUNT(*) AS TournamentWinner, TG.Winner
FROM Championship.TournamentGame TG
WHERE TG.TournamentID = @TournamentID
GROUP BY TG.Winner
ORDER BY COUNT(*) DESC


--Show player who used specific "Character" with highest win percentage
DECLARE @CharacterName AS NVARCHAR(32) = 'Moira';

WITH TournemantRecordsCTE(Wins, Loss, TeamID, TeamName, Player1, Player2, Player3, Player4, Player5) AS
(
    SELECT CAST((substring(T.record, 1, CHARINDEX('-', t.record) -1)) AS INT) AS Wins,
    CAST((substring(T.record, CHARINDEX('-', t.record) + 1 ,3)) AS INT) AS Loss,
    T.TeamID, T.TeamName, T.Player1, T.Player2, T.Player3, T.Player4, T.Player5
    FROM Championship.Team T
)
SELECT CT.Wins/(CT.Wins+CT.Loss) AS 'Win Percentage'
FROM TournemantRecordsCTE CT
    INNER JOIN Championship.Player P ON CT.Player1 = P.PlayerID 
    OR CT.Player2 = P.PlayerID OR CT.Player3 = P.PlayerID 
    OR CT.Player4 = P.PlayerID OR CT.Player5 = P.PlayerID
WHERE P.Main = @CharacterName
GROUP BY P.PlayerID, CT.TeamID
GO


--Show player ranked by Total Kills for current team