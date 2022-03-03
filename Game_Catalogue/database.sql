CREATE DATABASE [GAMECATALOGUE];
USE [GAMECATALOGUE];

CREATE TABLE [Genres]
(
[id_genre] INT NOT NULL IDENTITY,
[name] VARCHAR(255) NOT NULL,
CONSTRAINT [pk_genre_id] PRIMARY KEY ([id_genre])
);


CREATE TABLE [Games]
(
[id_game] INT NOT NULL IDENTITY,
[name] VARCHAR(255) NOT NULL,
[opinion] TEXT NULL,
[state] VARCHAR(20) NOT NULL CHECK ([state] IN('Playing','Played','Plan to play')),
[id_genre] INT NOT NULL,
CONSTRAINT [pk_games_id] PRIMARY KEY ([id_game]), 
CONSTRAINT [fk_games_id_genre] FOREIGN KEY ([id_genre]) REFERENCES [Genres]([id_genre])
);

CREATE TABLE [Users] 
(
    [id] INT NOT NULL PRIMARY KEY IDENTITY,
    [email] VARCHAR(100) NOT NULL UNIQUE,
    [username] VARCHAR(50) NOT NULL UNIQUE,
    [password] VARCHAR(255) NOT NULL,
    [created_at] DATETIME DEFAULT CURRENT_TIMESTAMP
);

Create table [Users_games]
(
[user_id] INT NOT NULL, 
[game_id] INT NOT NULL,
constraint fk_usersgames_user Foreign key ([user_id]) references users([id]),
constraint fk_usersgames_game Foreign key ([game_id]) references games([id_game])
);






