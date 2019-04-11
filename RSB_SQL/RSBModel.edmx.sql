
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 11/23/2016 22:58:41
-- Generated from EDMX file: C:\Development\RSB_SQL\RSB_SQL\RSBModel.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [RSB];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[PrivateContractor]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PrivateContractor];
GO
IF OBJECT_ID(N'[dbo].[RSBDiary]', 'U') IS NOT NULL
    DROP TABLE [dbo].[RSBDiary];
GO
IF OBJECT_ID(N'[dbo].[TranscriptCopyType]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TranscriptCopyType];
GO
IF OBJECT_ID(N'[dbo].[TranscriptParticularType]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TranscriptParticularType];
GO
IF OBJECT_ID(N'[dbo].[TranscriptSoundType]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TranscriptSoundType];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'RSBDiary'
CREATE TABLE [dbo].[RSBDiary] (
    [id] int IDENTITY(1,1) NOT NULL,
    [jurisdiction] varchar(255)  NULL,
    [case_name] varchar(255)  NULL,
    [case_no] varchar(255)  NULL,
    [hearing_date] datetime  NULL,
    [judge] varchar(100)  NULL,
    [transcript_particular_type_id] int  NULL,
    [is_daily] int  NULL,
    [sound_type_id] int  NULL,
    [sound_centre_id] int  NULL,
    [transcript_copy_type_id] int  NULL,
    [tr_cancelled_date] datetime  NULL,
    [level8_copy_date] datetime  NULL,
    [completed_by_name] varchar(255)  NULL,
    [actual_num_of_pages] int  NULL,
    [estimated_num_of_pages] int  NULL,
    [reporters_list] varchar(255)  NULL,
    [private_contractor_id] int  NULL,
    [is_handed_down] int  NULL,
    [comments] varchar(255)  NULL,
    [cancel_reason] varchar(255)  NULL
);
GO

-- Creating table 'PrivateContractors'
CREATE TABLE [dbo].[PrivateContractors] (
    [private_contractor_id] int IDENTITY(1,1) NOT NULL,
    [private_contractor_name] varchar(255)  NOT NULL,
    [private_contractor_email] varchar(255)  NULL
);
GO

-- Creating table 'TranscriptCopyTypes'
CREATE TABLE [dbo].[TranscriptCopyTypes] (
    [transcript_copy_type_id] int IDENTITY(1,1) NOT NULL,
    [transcript_copy_type] varchar(50)  NOT NULL
);
GO

-- Creating table 'TranscriptParticularTypes'
CREATE TABLE [dbo].[TranscriptParticularTypes] (
    [transcript_particular_type_id] int IDENTITY(1,1) NOT NULL,
    [transcript_particular_type] varchar(50)  NOT NULL
);
GO

-- Creating table 'TranscriptSoundTypes'
CREATE TABLE [dbo].[TranscriptSoundTypes] (
    [transcript_sound_type_id] int IDENTITY(1,1) NOT NULL,
    [transcript_sound_type] varchar(50)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [id] in table 'RSBDiary'
ALTER TABLE [dbo].[RSBDiary]
ADD CONSTRAINT [PK_RSBDiary]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [private_contractor_id] in table 'PrivateContractors'
ALTER TABLE [dbo].[PrivateContractors]
ADD CONSTRAINT [PK_PrivateContractors]
    PRIMARY KEY CLUSTERED ([private_contractor_id] ASC);
GO

-- Creating primary key on [transcript_copy_type_id] in table 'TranscriptCopyTypes'
ALTER TABLE [dbo].[TranscriptCopyTypes]
ADD CONSTRAINT [PK_TranscriptCopyTypes]
    PRIMARY KEY CLUSTERED ([transcript_copy_type_id] ASC);
GO

-- Creating primary key on [transcript_particular_type_id] in table 'TranscriptParticularTypes'
ALTER TABLE [dbo].[TranscriptParticularTypes]
ADD CONSTRAINT [PK_TranscriptParticularTypes]
    PRIMARY KEY CLUSTERED ([transcript_particular_type_id] ASC);
GO

-- Creating primary key on [transcript_sound_type_id] in table 'TranscriptSoundTypes'
ALTER TABLE [dbo].[TranscriptSoundTypes]
ADD CONSTRAINT [PK_TranscriptSoundTypes]
    PRIMARY KEY CLUSTERED ([transcript_sound_type_id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------