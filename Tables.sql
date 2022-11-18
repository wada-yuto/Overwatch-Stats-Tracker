USE [WideWorldImporters]; -- Your database here.
/*********************
 * Drop Tables
 *********************/
IF SCHEMA_ID(N'Championship') IS NULL
   EXEC(N'CREATE SCHEMA [Championship];');
GO

DROP TABLE IF EXISTS TournamentGame;
DROP TABLE IF EXISTS Tournament;
DROP TABLE IF EXISTS Team;
DROP TABLE IF EXISTS PlayerGame;
DROP TABLE IF EXISTS Character;
DROP TABLE IF EXISTS Player;

GO 
/******************
 * Create Tables
 ******************/
CREATE TABLE Player
(
    PlayerID INT NOT NULL IDENTITY PRIMARY KEY,
    PlayerName NVARCHAR(32) NOT NULL,
    TotalKills INT,
    Main NVARCHAR(32) NOT NULL,
    Role NVARCHAR(32) NOT NULL,
    Email NVARCHAR(32) NOT NULL
    UNIQUE(PlayerName, Email)
);
CREATE TABLE Character
(
    CharacterID INT NOT NULL IDENTITY PRIMARY KEY,
    Name NVARCHAR(32) NOT NULL
    UNIQUE(Name)
);
CREATE TABLE PlayerGame
(
    PlayerGameID INT NOT NULL IDENTITY PRIMARY KEY,
    Kills INT NOT NULL,
    CharacterID INT NOT NULL FOREIGN KEY
        REFERENCES CHARACTER(CharacterID),
    PlayerID INT NOT NULL FOREIGN KEY
        REFERENCES Player(PlayerID)
);
CREATE TABLE Team
(
    TeamID INT NOT NULL IDENTITY PRIMARY KEY,
    Coach NVARCHAR(32) NOT NULL,
    Record NVARCHAR(32) NOT NULL,
    TeamName NVARCHAR(32) NOT NULL,
    Player1 INT NOT NULL FOREIGN KEY
        REFERENCES Player(PlayerID),
    Player2 INT NOT NULL FOREIGN KEY
        REFERENCES Player(PlayerID),
    Player3 INT NOT NULL FOREIGN KEY
        REFERENCES Player(PlayerID),
    Player4 INT NOT NULL FOREIGN KEY
        REFERENCES Player(PlayerID),
    Player5 INT NOT NULL FOREIGN KEY
        REFERENCES Player(PlayerID)
    UNIQUE(Coach, TeamName)
);
CREATE TABLE Tournament
(
    TournamentID INT NOT NULL IDENTITY PRIMARY KEY,
    TeamNumber INT NOT NULL
);
CREATE TABLE TournamentGame
(
    TournamentGameID INT NOT NULL IDENTITY PRIMARY KEY,
    Map NVARCHAR(32) NOT NULL,
    Team1 INT NOT NULL FOREIGN KEY
        REFERENCES Team(TeamID),
    Team2 INT NOT NULL FOREIGN KEY
        REFERENCES Team(TeamID),
    Winner INT NOT NULL FOREIGN KEY
        REFERENCES Team(TeamID),
    TournamentID INT NOT NULL FOREIGN KEY
        REFERENCES Tournament(TournamentID)
);
