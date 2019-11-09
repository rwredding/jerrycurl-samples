CREATE TABLE [Customer] (
  [Id] int IDENTITY(1, 1),
  [AddressId] int,
  [CreatedDate] datetime NOT NULL,
  [Email] nvarchar(255) NOT NULL,
  [Password] nvarchar(255) NOT NULL,
  [Name] nvarchar(255) NOT NULL,
  CONSTRAINT PK_Customer PRIMARY KEY (Id)
)
GO

CREATE TABLE [CustomerAddress] (
  [Id] int IDENTITY(1, 1),
  [Street] nvarchar(255) NOT NULL,
  [City] nvarchar(255) NOT NULL,
  [Country] nvarchar(255) NOT NULL,
  CONSTRAINT PK_CustomerAddress PRIMARY KEY (Id)
)
GO

CREATE TABLE [Order] (
  [Id] int IDENTITY(1, 1),
  [CustomerId] int NOT NULL,
  [AddressId] int NOT NULL,
  [CreatedDate] datetime NOT NULL,
  [CompletedDate] datetime,
  CONSTRAINT PK_Order PRIMARY KEY (Id)
)
GO

CREATE TABLE [Product] (
  [Id] int IDENTITY(1, 1),
  [Name] nvarchar(255) NOT NULL,
  [Price] decimal NOT NULL,
  CONSTRAINT PK_Product PRIMARY KEY (Id)
)
GO

CREATE TABLE [OrderLine] (
  [Id] int IDENTITY(1, 1),
  [OrderId] int NOT NULL,
  [ProductId] int NOT NULL,
  [Units] int NOT NULL,
  CONSTRAINT PK_OrderLine PRIMARY KEY (Id)
)
GO

ALTER TABLE [Order] ADD CONSTRAINT FK_Order_Customer FOREIGN KEY ([CustomerId]) REFERENCES [Customer] ([Id])
GO

ALTER TABLE [Order] ADD CONSTRAINT FK_Order_CustomerAddress FOREIGN KEY ([AddressId]) REFERENCES [CustomerAddress] ([Id])
GO

ALTER TABLE [OrderLine] ADD CONSTRAINT FK_OrderLine_Order FOREIGN KEY ([OrderId]) REFERENCES [Order] ([Id])
GO

ALTER TABLE [OrderLine] ADD CONSTRAINT FK_OrderLine_Product FOREIGN KEY ([ProductId]) REFERENCES [Product] ([Id])
GO

ALTER TABLE [Customer] ADD CONSTRAINT FK_Customer_CustomerAddress FOREIGN KEY ([AddressId]) REFERENCES [CustomerAddress] ([Id])
GO
