IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20201126022833_initial')
BEGIN
    CREATE TABLE [AspNetRoles] (
        [Id] nvarchar(450) NOT NULL,
        [Name] nvarchar(256) NULL,
        [NormalizedName] nvarchar(256) NULL,
        [ConcurrencyStamp] nvarchar(max) NULL,
        CONSTRAINT [PK_AspNetRoles] PRIMARY KEY ([Id])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20201126022833_initial')
BEGIN
    CREATE TABLE [AspNetUsers] (
        [Id] nvarchar(450) NOT NULL,
        [UserName] nvarchar(256) NULL,
        [NormalizedUserName] nvarchar(256) NULL,
        [Email] nvarchar(256) NULL,
        [NormalizedEmail] nvarchar(256) NULL,
        [EmailConfirmed] bit NOT NULL,
        [PasswordHash] nvarchar(max) NULL,
        [SecurityStamp] nvarchar(max) NULL,
        [ConcurrencyStamp] nvarchar(max) NULL,
        [PhoneNumber] nvarchar(max) NULL,
        [PhoneNumberConfirmed] bit NOT NULL,
        [TwoFactorEnabled] bit NOT NULL,
        [LockoutEnd] datetimeoffset NULL,
        [LockoutEnabled] bit NOT NULL,
        [AccessFailedCount] int NOT NULL,
        CONSTRAINT [PK_AspNetUsers] PRIMARY KEY ([Id])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20201126022833_initial')
BEGIN
    CREATE TABLE [Product] (
        [ProductID] int NOT NULL IDENTITY,
        [Name] nvarchar(max) NULL,
        [Description] nvarchar(max) NULL,
        [Price] decimal(18,2) NOT NULL,
        [ImageName] nvarchar(max) NULL,
        CONSTRAINT [PK_Product] PRIMARY KEY ([ProductID])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20201126022833_initial')
BEGIN
    CREATE TABLE [Upgrade] (
        [UpgradeID] int NOT NULL IDENTITY,
        [UpgradeName] nvarchar(max) NULL,
        [UpgradeCategory] nvarchar(max) NULL,
        [UpgradePrice] int NOT NULL,
        CONSTRAINT [PK_Upgrade] PRIMARY KEY ([UpgradeID])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20201126022833_initial')
BEGIN
    CREATE TABLE [AspNetRoleClaims] (
        [Id] int NOT NULL IDENTITY,
        [RoleId] nvarchar(450) NOT NULL,
        [ClaimType] nvarchar(max) NULL,
        [ClaimValue] nvarchar(max) NULL,
        CONSTRAINT [PK_AspNetRoleClaims] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_AspNetRoleClaims_AspNetRoles_RoleId] FOREIGN KEY ([RoleId]) REFERENCES [AspNetRoles] ([Id]) ON DELETE CASCADE
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20201126022833_initial')
BEGIN
    CREATE TABLE [AspNetUserClaims] (
        [Id] int NOT NULL IDENTITY,
        [UserId] nvarchar(450) NOT NULL,
        [ClaimType] nvarchar(max) NULL,
        [ClaimValue] nvarchar(max) NULL,
        CONSTRAINT [PK_AspNetUserClaims] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_AspNetUserClaims_AspNetUsers_UserId] FOREIGN KEY ([UserId]) REFERENCES [AspNetUsers] ([Id]) ON DELETE CASCADE
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20201126022833_initial')
BEGIN
    CREATE TABLE [AspNetUserLogins] (
        [LoginProvider] nvarchar(128) NOT NULL,
        [ProviderKey] nvarchar(128) NOT NULL,
        [ProviderDisplayName] nvarchar(max) NULL,
        [UserId] nvarchar(450) NOT NULL,
        CONSTRAINT [PK_AspNetUserLogins] PRIMARY KEY ([LoginProvider], [ProviderKey]),
        CONSTRAINT [FK_AspNetUserLogins_AspNetUsers_UserId] FOREIGN KEY ([UserId]) REFERENCES [AspNetUsers] ([Id]) ON DELETE CASCADE
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20201126022833_initial')
BEGIN
    CREATE TABLE [AspNetUserRoles] (
        [UserId] nvarchar(450) NOT NULL,
        [RoleId] nvarchar(450) NOT NULL,
        CONSTRAINT [PK_AspNetUserRoles] PRIMARY KEY ([UserId], [RoleId]),
        CONSTRAINT [FK_AspNetUserRoles_AspNetRoles_RoleId] FOREIGN KEY ([RoleId]) REFERENCES [AspNetRoles] ([Id]) ON DELETE CASCADE,
        CONSTRAINT [FK_AspNetUserRoles_AspNetUsers_UserId] FOREIGN KEY ([UserId]) REFERENCES [AspNetUsers] ([Id]) ON DELETE CASCADE
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20201126022833_initial')
BEGIN
    CREATE TABLE [AspNetUserTokens] (
        [UserId] nvarchar(450) NOT NULL,
        [LoginProvider] nvarchar(128) NOT NULL,
        [Name] nvarchar(128) NOT NULL,
        [Value] nvarchar(max) NULL,
        CONSTRAINT [PK_AspNetUserTokens] PRIMARY KEY ([UserId], [LoginProvider], [Name]),
        CONSTRAINT [FK_AspNetUserTokens_AspNetUsers_UserId] FOREIGN KEY ([UserId]) REFERENCES [AspNetUsers] ([Id]) ON DELETE CASCADE
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20201126022833_initial')
BEGIN
    CREATE TABLE [Order] (
        [OrderID] int NOT NULL IDENTITY,
        [OrderPrice] nvarchar(max) NULL,
        [UserID] nvarchar(max) NULL,
        [ProductID] int NOT NULL,
        [OrderDate] datetime2 NOT NULL,
        CONSTRAINT [PK_Order] PRIMARY KEY ([OrderID]),
        CONSTRAINT [FK_Order_Product_ProductID] FOREIGN KEY ([ProductID]) REFERENCES [Product] ([ProductID]) ON DELETE CASCADE
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20201126022833_initial')
BEGIN
    CREATE TABLE [UpgradePJT] (
        [UpgradePJTID] int NOT NULL IDENTITY,
        [OrderID] int NOT NULL,
        [UpgradeID] int NOT NULL,
        CONSTRAINT [PK_UpgradePJT] PRIMARY KEY ([UpgradePJTID]),
        CONSTRAINT [FK_UpgradePJT_Order_OrderID] FOREIGN KEY ([OrderID]) REFERENCES [Order] ([OrderID]) ON DELETE CASCADE,
        CONSTRAINT [FK_UpgradePJT_Upgrade_UpgradeID] FOREIGN KEY ([UpgradeID]) REFERENCES [Upgrade] ([UpgradeID]) ON DELETE CASCADE
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20201126022833_initial')
BEGIN
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'ProductID', N'Description', N'ImageName', N'Name', N'Price') AND [object_id] = OBJECT_ID(N'[Product]'))
        SET IDENTITY_INSERT [Product] ON;
    INSERT INTO [Product] ([ProductID], [Description], [ImageName], [Name], [Price])
    VALUES (1, N'A small and lightweight PC for basic computing tasks.', N'mini1.jpg', N'The Mini', 599.99),
    (2, N'A Business PC for professional applications.', N'business1.jpg', N'The Business', 799.99),
    (3, N'A PC for playing all of the latest and greatest video games.', N'gamer1.jpg', N'The Gamer', 999.99);
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'ProductID', N'Description', N'ImageName', N'Name', N'Price') AND [object_id] = OBJECT_ID(N'[Product]'))
        SET IDENTITY_INSERT [Product] OFF;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20201126022833_initial')
BEGIN
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'UpgradeID', N'UpgradeCategory', N'UpgradeName', N'UpgradePrice') AND [object_id] = OBJECT_ID(N'[Upgrade]'))
        SET IDENTITY_INSERT [Upgrade] ON;
    INSERT INTO [Upgrade] ([UpgradeID], [UpgradeCategory], [UpgradeName], [UpgradePrice])
    VALUES (29, N'Video', N'Quadro P1000', 550),
    (30, N'Sound', N'Integrated', 0),
    (31, N'Sound', N'Sound Blaster 1000', 40),
    (32, N'OS', N'None', 0),
    (33, N'OS', N'Ubuntu', 0),
    (34, N'OS', N'Win 10 Home', 70),
    (35, N'OS', N'Win 10 Pro', 110),
    (36, N'CPU', N'i5 9400', 0),
    (37, N'CPU', N'i5 10400F', 75),
    (38, N'CPU', N'i7 10700k', 150),
    (39, N'Memory', N'8 Gb', 0),
    (41, N'Memory', N'32 Gb', 200),
    (28, N'Video', N'Quadro P620', 300),
    (42, N'Storage', N'256 Gb SSD', 60),
    (43, N'Storage', N'512 Gb SSD', 120),
    (44, N'Storage', N'1 Tb SSD', 240),
    (45, N'Video', N'1650 Ti', 0),
    (46, N'Video', N'1660 Ti', 100),
    (47, N'Video', N'RTX 2060', 150),
    (48, N'Video', N'RTX 2070', 300),
    (49, N'Sound', N'Integrated', 0),
    (50, N'Sound', N'Sound Blaster 5000', 40),
    (51, N'Sound', N'Sound Blaster 10000', 100),
    (40, N'Memory', N'16 Gb', 100),
    (27, N'Video', N'Integrated', 0),
    (25, N'Storage', N'512 Gb SSD', 120),
    (52, N'OS', N'Win 10 Home', 0),
    (1, N'CPU', N'i3 8130u', 0),
    (2, N'CPU', N'i5 8250u', 50),
    (3, N'CPU', N'i7 8550u', 100),
    (4, N'Memory', N'8 Gb', 0),
    (5, N'Memory', N'16 Gb', 100),
    (6, N'Storage', N'1 Tb HDD', 0),
    (7, N'Storage', N'128 Gb SSD', 0),
    (8, N'Storage', N'256 Gb SSD', 60),
    (9, N'Storage', N'512 Gb SSD', 120),
    (10, N'Video', N'Integrated', 0),
    (11, N'Sound', N'Integrated', 0),
    (26, N'Storage', N'1 Tb SSD', 240),
    (12, N'OS', N'None', 0),
    (14, N'OS', N'Win 10 Home', 70),
    (15, N'CPU', N'i3 10100', 0),
    (16, N'CPU', N'i5 10400', 50),
    (17, N'CPU', N'i5 10600', 80),
    (18, N'CPU', N'i7 10700', 140),
    (19, N'CPU', N'i9 10900', 200),
    (20, N'Memory', N'8 Gb', 0),
    (21, N'Memory', N'16 Gb', 100),
    (22, N'Memory', N'32 Gb', 200),
    (23, N'Storage', N'1 Tb HDD', 0),
    (24, N'Storage', N'256 Gb SSD', 60),
    (13, N'OS', N'Ubuntu', 0),
    (53, N'OS', N'Win 10 Pro', 40);
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'UpgradeID', N'UpgradeCategory', N'UpgradeName', N'UpgradePrice') AND [object_id] = OBJECT_ID(N'[Upgrade]'))
        SET IDENTITY_INSERT [Upgrade] OFF;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20201126022833_initial')
BEGIN
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'OrderID', N'OrderDate', N'OrderPrice', N'ProductID', N'UserID') AND [object_id] = OBJECT_ID(N'[Order]'))
        SET IDENTITY_INSERT [Order] ON;
    INSERT INTO [Order] ([OrderID], [OrderDate], [OrderPrice], [ProductID], [UserID])
    VALUES (1, '2019-08-25T00:00:00.0000000', NULL, 1, NULL);
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'OrderID', N'OrderDate', N'OrderPrice', N'ProductID', N'UserID') AND [object_id] = OBJECT_ID(N'[Order]'))
        SET IDENTITY_INSERT [Order] OFF;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20201126022833_initial')
BEGIN
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'OrderID', N'OrderDate', N'OrderPrice', N'ProductID', N'UserID') AND [object_id] = OBJECT_ID(N'[Order]'))
        SET IDENTITY_INSERT [Order] ON;
    INSERT INTO [Order] ([OrderID], [OrderDate], [OrderPrice], [ProductID], [UserID])
    VALUES (2, '2019-08-26T00:00:00.0000000', NULL, 1, NULL);
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'OrderID', N'OrderDate', N'OrderPrice', N'ProductID', N'UserID') AND [object_id] = OBJECT_ID(N'[Order]'))
        SET IDENTITY_INSERT [Order] OFF;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20201126022833_initial')
BEGIN
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'OrderID', N'OrderDate', N'OrderPrice', N'ProductID', N'UserID') AND [object_id] = OBJECT_ID(N'[Order]'))
        SET IDENTITY_INSERT [Order] ON;
    INSERT INTO [Order] ([OrderID], [OrderDate], [OrderPrice], [ProductID], [UserID])
    VALUES (3, '2019-09-29T00:00:00.0000000', NULL, 2, NULL);
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'OrderID', N'OrderDate', N'OrderPrice', N'ProductID', N'UserID') AND [object_id] = OBJECT_ID(N'[Order]'))
        SET IDENTITY_INSERT [Order] OFF;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20201126022833_initial')
BEGIN
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'UpgradePJTID', N'OrderID', N'UpgradeID') AND [object_id] = OBJECT_ID(N'[UpgradePJT]'))
        SET IDENTITY_INSERT [UpgradePJT] ON;
    INSERT INTO [UpgradePJT] ([UpgradePJTID], [OrderID], [UpgradeID])
    VALUES (1, 1, 1),
    (2, 1, 4),
    (3, 1, 6),
    (4, 1, 10),
    (5, 1, 11),
    (6, 1, 12),
    (7, 2, 15),
    (8, 2, 20),
    (9, 2, 23),
    (10, 2, 27),
    (11, 2, 30),
    (12, 2, 32);
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'UpgradePJTID', N'OrderID', N'UpgradeID') AND [object_id] = OBJECT_ID(N'[UpgradePJT]'))
        SET IDENTITY_INSERT [UpgradePJT] OFF;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20201126022833_initial')
BEGIN
    CREATE INDEX [IX_AspNetRoleClaims_RoleId] ON [AspNetRoleClaims] ([RoleId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20201126022833_initial')
BEGIN
    CREATE UNIQUE INDEX [RoleNameIndex] ON [AspNetRoles] ([NormalizedName]) WHERE [NormalizedName] IS NOT NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20201126022833_initial')
BEGIN
    CREATE INDEX [IX_AspNetUserClaims_UserId] ON [AspNetUserClaims] ([UserId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20201126022833_initial')
BEGIN
    CREATE INDEX [IX_AspNetUserLogins_UserId] ON [AspNetUserLogins] ([UserId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20201126022833_initial')
BEGIN
    CREATE INDEX [IX_AspNetUserRoles_RoleId] ON [AspNetUserRoles] ([RoleId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20201126022833_initial')
BEGIN
    CREATE INDEX [EmailIndex] ON [AspNetUsers] ([NormalizedEmail]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20201126022833_initial')
BEGIN
    CREATE UNIQUE INDEX [UserNameIndex] ON [AspNetUsers] ([NormalizedUserName]) WHERE [NormalizedUserName] IS NOT NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20201126022833_initial')
BEGIN
    CREATE INDEX [IX_Order_ProductID] ON [Order] ([ProductID]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20201126022833_initial')
BEGIN
    CREATE INDEX [IX_UpgradePJT_OrderID] ON [UpgradePJT] ([OrderID]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20201126022833_initial')
BEGIN
    CREATE INDEX [IX_UpgradePJT_UpgradeID] ON [UpgradePJT] ([UpgradeID]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20201126022833_initial')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20201126022833_initial', N'3.1.10');
END;

GO

