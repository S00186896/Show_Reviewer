
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 05/01/2020 07:13:35
-- Generated from EDMX file: F:\Year_2\Semester2\OOD\Project_2.0\Project\WpfApp1\database_show.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [showreviewer];
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

-- Creating table 'Shows'
CREATE TABLE [dbo].[Shows] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [name] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Seasons'
CREATE TABLE [dbo].[Seasons] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [name2] nvarchar(max)  NOT NULL,
    [noSeason] int  NOT NULL
);
GO

-- Creating table 'Episodes'
CREATE TABLE [dbo].[Episodes] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [name3] nvarchar(max)  NOT NULL,
    [noEpisode] nvarchar(max)  NOT NULL,
    [epRating] int  NOT NULL,
    [epReview] nvarchar(max)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Shows'
ALTER TABLE [dbo].[Shows]
ADD CONSTRAINT [PK_Shows]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Seasons'
ALTER TABLE [dbo].[Seasons]
ADD CONSTRAINT [PK_Seasons]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Episodes'
ALTER TABLE [dbo].[Episodes]
ADD CONSTRAINT [PK_Episodes]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------