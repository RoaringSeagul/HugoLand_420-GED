
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 10/24/2015 12:12:08
-- Generated from EDMX file: C:\technique informatique\session 3\base de données\tp\tp1\hugoland\HugoLand_420-GED\TP#1 - HugoLandEditeur\HugoLandDb.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [GED-Equipe7-2015];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------


-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Classes'
CREATE TABLE [dbo].[Classes] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [NomClasse] nvarchar(max)  NOT NULL,
    [Description] nvarchar(max)  NOT NULL,
    [StatsBaseStr] int  NOT NULL,
    [StatsBaseDex] int  NOT NULL,
    [StatsBaseInt] int  NOT NULL,
    [StatsBaseVitalitê] int  NOT NULL,
    [MondeId] int  NOT NULL
);
GO

-- Creating table 'Heroes'
CREATE TABLE [dbo].[Heroes] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Niveau] int  NOT NULL,
    [Experience] int  NOT NULL,
    [x] nvarchar(max)  NOT NULL,
    [y] nvarchar(max)  NOT NULL,
    [Argent] int  NOT NULL,
    [StatsStr] int  NOT NULL,
    [StatsDex] int  NOT NULL,
    [StatsInt] int  NOT NULL,
    [StatsVitalitê] int  NOT NULL,
    [NomHero] nvarchar(max)  NOT NULL,
    [EstConnectê] bit  NOT NULL,
    [InventaireHeroId] int  NOT NULL,
    [MondeId] int  NOT NULL,
    [Class_Id] int  NOT NULL,
    [CompteJoueur_Id] int  NOT NULL
);
GO

-- Creating table 'CompteJoueurs'
CREATE TABLE [dbo].[CompteJoueurs] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [NomUtilisateur] nvarchar(max)  NOT NULL,
    [MotDePasse] nvarchar(max)  NOT NULL,
    [Courriel] nvarchar(max)  NOT NULL,
    [Prenom] nvarchar(max)  NOT NULL,
    [Nom] nvarchar(max)  NOT NULL,
    [TypeUtilisateur] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Mondes'
CREATE TABLE [dbo].[Mondes] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Description] nvarchar(max)  NOT NULL,
    [LimiteX] int  NOT NULL,
    [LimiteY] int  NOT NULL
);
GO

-- Creating table 'ObjetMondes'
CREATE TABLE [dbo].[ObjetMondes] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [X] int  NOT NULL,
    [Y] int  NOT NULL,
    [Description] nvarchar(max)  NOT NULL,
    [TypeObjet] nvarchar(max)  NOT NULL,
    [MondeId] int  NOT NULL
);
GO

-- Creating table 'InventaireHeroes'
CREATE TABLE [dbo].[InventaireHeroes] (
    [Id] int IDENTITY(1,1) NOT NULL
);
GO

-- Creating table 'Items'
CREATE TABLE [dbo].[Items] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Nom] nvarchar(max)  NOT NULL,
    [Description] nvarchar(max)  NOT NULL,
    [X] int  NOT NULL,
    [Y] int  NOT NULL,
    [Niveau] int  NOT NULL,
    [ValeurArgent] int  NOT NULL,
    [Poid] int  NOT NULL,
    [RegNiveau] int  NOT NULL,
    [RegForce] int  NOT NULL,
    [RegDex] int  NOT NULL,
    [RegInt] int  NOT NULL,
    [RegEnduance] int  NOT NULL,
    [Quantitê] int  NOT NULL,
    [MondeId] int  NOT NULL,
    [InventaireHero_Id] int  NOT NULL
);
GO

-- Creating table 'EffetItems'
CREATE TABLE [dbo].[EffetItems] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [ValeurEffet] nvarchar(max)  NOT NULL,
    [TypeEffet] nvarchar(max)  NOT NULL,
    [Item_Id] int  NOT NULL
);
GO

-- Creating table 'Monstres'
CREATE TABLE [dbo].[Monstres] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Nom] nvarchar(max)  NOT NULL,
    [X] int  NOT NULL,
    [Y] int  NOT NULL,
    [StatVitalitê] int  NOT NULL,
    [StatDmgMin] int  NOT NULL,
    [StatDmgMax] int  NOT NULL,
    [MondeId] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Classes'
ALTER TABLE [dbo].[Classes]
ADD CONSTRAINT [PK_Classes]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Heroes'
ALTER TABLE [dbo].[Heroes]
ADD CONSTRAINT [PK_Heroes]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'CompteJoueurs'
ALTER TABLE [dbo].[CompteJoueurs]
ADD CONSTRAINT [PK_CompteJoueurs]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Mondes'
ALTER TABLE [dbo].[Mondes]
ADD CONSTRAINT [PK_Mondes]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'ObjetMondes'
ALTER TABLE [dbo].[ObjetMondes]
ADD CONSTRAINT [PK_ObjetMondes]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'InventaireHeroes'
ALTER TABLE [dbo].[InventaireHeroes]
ADD CONSTRAINT [PK_InventaireHeroes]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Items'
ALTER TABLE [dbo].[Items]
ADD CONSTRAINT [PK_Items]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'EffetItems'
ALTER TABLE [dbo].[EffetItems]
ADD CONSTRAINT [PK_EffetItems]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Monstres'
ALTER TABLE [dbo].[Monstres]
ADD CONSTRAINT [PK_Monstres]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Class_Id] in table 'Heroes'
ALTER TABLE [dbo].[Heroes]
ADD CONSTRAINT [FK_HeroClasses]
    FOREIGN KEY ([Class_Id])
    REFERENCES [dbo].[Classes]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_HeroClasses'
CREATE INDEX [IX_FK_HeroClasses]
ON [dbo].[Heroes]
    ([Class_Id]);
GO

-- Creating foreign key on [CompteJoueur_Id] in table 'Heroes'
ALTER TABLE [dbo].[Heroes]
ADD CONSTRAINT [FK_HeroCompteJoueur]
    FOREIGN KEY ([CompteJoueur_Id])
    REFERENCES [dbo].[CompteJoueurs]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_HeroCompteJoueur'
CREATE INDEX [IX_FK_HeroCompteJoueur]
ON [dbo].[Heroes]
    ([CompteJoueur_Id]);
GO

-- Creating foreign key on [MondeId] in table 'Classes'
ALTER TABLE [dbo].[Classes]
ADD CONSTRAINT [FK_MondeClasses]
    FOREIGN KEY ([MondeId])
    REFERENCES [dbo].[Mondes]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_MondeClasses'
CREATE INDEX [IX_FK_MondeClasses]
ON [dbo].[Classes]
    ([MondeId]);
GO

-- Creating foreign key on [MondeId] in table 'ObjetMondes'
ALTER TABLE [dbo].[ObjetMondes]
ADD CONSTRAINT [FK_MondeObjetMonde]
    FOREIGN KEY ([MondeId])
    REFERENCES [dbo].[Mondes]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_MondeObjetMonde'
CREATE INDEX [IX_FK_MondeObjetMonde]
ON [dbo].[ObjetMondes]
    ([MondeId]);
GO

-- Creating foreign key on [InventaireHeroId] in table 'Heroes'
ALTER TABLE [dbo].[Heroes]
ADD CONSTRAINT [FK_InventaireHeroHero]
    FOREIGN KEY ([InventaireHeroId])
    REFERENCES [dbo].[InventaireHeroes]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_InventaireHeroHero'
CREATE INDEX [IX_FK_InventaireHeroHero]
ON [dbo].[Heroes]
    ([InventaireHeroId]);
GO

-- Creating foreign key on [MondeId] in table 'Items'
ALTER TABLE [dbo].[Items]
ADD CONSTRAINT [FK_MondeItems]
    FOREIGN KEY ([MondeId])
    REFERENCES [dbo].[Mondes]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_MondeItems'
CREATE INDEX [IX_FK_MondeItems]
ON [dbo].[Items]
    ([MondeId]);
GO

-- Creating foreign key on [InventaireHero_Id] in table 'Items'
ALTER TABLE [dbo].[Items]
ADD CONSTRAINT [FK_ItemsInventaireHero]
    FOREIGN KEY ([InventaireHero_Id])
    REFERENCES [dbo].[InventaireHeroes]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ItemsInventaireHero'
CREATE INDEX [IX_FK_ItemsInventaireHero]
ON [dbo].[Items]
    ([InventaireHero_Id]);
GO

-- Creating foreign key on [Item_Id] in table 'EffetItems'
ALTER TABLE [dbo].[EffetItems]
ADD CONSTRAINT [FK_EffetItemItems]
    FOREIGN KEY ([Item_Id])
    REFERENCES [dbo].[Items]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_EffetItemItems'
CREATE INDEX [IX_FK_EffetItemItems]
ON [dbo].[EffetItems]
    ([Item_Id]);
GO

-- Creating foreign key on [MondeId] in table 'Monstres'
ALTER TABLE [dbo].[Monstres]
ADD CONSTRAINT [FK_MondeMonstre]
    FOREIGN KEY ([MondeId])
    REFERENCES [dbo].[Mondes]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_MondeMonstre'
CREATE INDEX [IX_FK_MondeMonstre]
ON [dbo].[Monstres]
    ([MondeId]);
GO

-- Creating foreign key on [MondeId] in table 'Heroes'
ALTER TABLE [dbo].[Heroes]
ADD CONSTRAINT [FK_MondeHero]
    FOREIGN KEY ([MondeId])
    REFERENCES [dbo].[Mondes]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_MondeHero'
CREATE INDEX [IX_FK_MondeHero]
ON [dbo].[Heroes]
    ([MondeId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------