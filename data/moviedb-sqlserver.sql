CREATE TABLE [Movie] (
  [Id] int PRIMARY KEY,
  [Title] nvarchar(255),
  [ReleaseDate] datetime,
  [DirectorId] int,
  [StudioId] int
)
GO

CREATE TABLE [MovieCast] (
  [MovieId] int,
  [ActorId] int,
  [Role] nvarchar(255)
)
GO

CREATE TABLE [Actor] (
  [Id] int PRIMARY KEY,
  [Name] nvarchar(255)
)
GO

CREATE TABLE [Director] (
  [Id] int PRIMARY KEY,
  [Name] nvarchar(255)
)
GO

CREATE TABLE [Studio] (
  [Id] int PRIMARY KEY,
  [Name] nvarchar(255),
  [FoundedYear] int
)
GO

ALTER TABLE [Movie] ADD FOREIGN KEY ([DirectorId]) REFERENCES [Director] ([Id])
GO

ALTER TABLE [Movie] ADD FOREIGN KEY ([StudioId]) REFERENCES [Studio] ([Id])
GO

ALTER TABLE [MovieCast] ADD FOREIGN KEY ([MovieId]) REFERENCES [Movie] ([Id])
GO

ALTER TABLE [MovieCast] ADD FOREIGN KEY ([ActorId]) REFERENCES [Actor] ([Id])
GO
