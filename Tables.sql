USE [WideWorldImporters]; -- Your database here.
/*********************
 * Drop Tables
 *********************/
IF SCHEMA_ID(N'Championship') IS NULL
   EXEC(N'CREATE SCHEMA [Championship];');
GO

GO
/******************
 * Create Tables
 ******************/
CREATE TABLE Championship.Player
(
    PlayerID INT NOT NULL IDENTITY PRIMARY KEY,
    PlayerName NVARCHAR(32) NOT NULL,
    TotalKills INT,
    Main NVARCHAR(32) NOT NULL,
    Email NVARCHAR(32) NOT NULL
    UNIQUE(PlayerName, Email)
);
CREATE TABLE Championship.Character
(
    CharacterID INT NOT NULL IDENTITY PRIMARY KEY,
    Email NVARCHAR(32) NOT NULL,
    WinPercentage INT NOT NULL
    UNIQUE(Email)
);
CREATE TABLE Championship.PlayerGame
(
    PlayerGameID INT NOT NULL IDENTITY PRIMARY KEY,
    Kills INT NOT NULL,
    CharacterID INT NOT NULL FOREIGN KEY
        REFERENCES Championship.CHARACTER(CharacterID),
    PlayerID INT NOT NULL FOREIGN KEY
        REFERENCES Championship.Player(PlayerID)
    UNIQUE(CharacterID, PlayerID)
);
CREATE TABLE Championship.Team
(
    TeamID INT NOT NULL IDENTITY PRIMARY KEY,
    Coach NVARCHAR(32) NOT NULL,
    Record NVARCHAR(32) NOT NULL,
    TeamName NVARCHAR(32) NOT NULL,
    Player1 INT NOT NULL FOREIGN KEY
        REFERENCES Championship.Player(PlayerID),
    Player2 INT NOT NULL FOREIGN KEY
        REFERENCES Championship.Player(PlayerID),
    Player3 INT NOT NULL FOREIGN KEY
        REFERENCES Championship.Player(PlayerID),
    Player4 INT NOT NULL FOREIGN KEY
        REFERENCES Championship.Player(PlayerID),
    Player5 INT NOT NULL FOREIGN KEY
        REFERENCES Championship.Player(PlayerID)
    UNIQUE(Coach, TeamName)
);
CREATE TABLE Championship.TournamentGame
(
    TournamentGameID INT NOT NULL IDENTITY PRIMARY KEY,
    Map NVARCHAR(32) NOT NULL,
    Team1 INT NOT NULL FOREIGN KEY
        REFERENCES Championship.Team(TeamID),
    Team2 INT NOT NULL FOREIGN KEY
        REFERENCES Championship.Team(TeamID),
    Winner INT NOT NULL
);
CREATE TABLE Championship.Tournament
(
    TournamentID INT NOT NULL IDENTITY PRIMARY KEY,
    TeamNumber INT NOT NULL,
    TeamID INT NOT NULL FOREIGN KEY
        REFERENCES Championship.Team(TeamID),
    UNIQUE(TeamNumber)
);