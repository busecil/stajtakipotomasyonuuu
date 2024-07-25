
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 03/23/2024 16:21:07
-- Generated from EDMX file: C:\Users\BEYZAGÜL ADAKLI\Desktop\4.Hafta\stajtakipotomasyonu\stajtakipotomasyonu\Model1.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [STAJOTOMASYONU];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_Bölümler_Akademisyen]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Bölümler] DROP CONSTRAINT [FK_Bölümler_Akademisyen];
GO
IF OBJECT_ID(N'[dbo].[FK_Liste_Öğrenciler]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Liste] DROP CONSTRAINT [FK_Liste_Öğrenciler];
GO
IF OBJECT_ID(N'[dbo].[FK_Öğrenciler_Programlar1]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Öğrenciler] DROP CONSTRAINT [FK_Öğrenciler_Programlar1];
GO
IF OBJECT_ID(N'[dbo].[FK_Programlar_Akademisyen]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Programlar] DROP CONSTRAINT [FK_Programlar_Akademisyen];
GO
IF OBJECT_ID(N'[dbo].[FK_Programlar_Akademisyen1]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Programlar] DROP CONSTRAINT [FK_Programlar_Akademisyen1];
GO
IF OBJECT_ID(N'[dbo].[FK_Programlar_Bölümler]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Programlar] DROP CONSTRAINT [FK_Programlar_Bölümler];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Akademisyen]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Akademisyen];
GO
IF OBJECT_ID(N'[dbo].[Bölümler]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Bölümler];
GO
IF OBJECT_ID(N'[dbo].[Liste]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Liste];
GO
IF OBJECT_ID(N'[dbo].[OkulAyar]', 'U') IS NOT NULL
    DROP TABLE [dbo].[OkulAyar];
GO
IF OBJECT_ID(N'[dbo].[Öğrenciler]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Öğrenciler];
GO
IF OBJECT_ID(N'[dbo].[Programlar]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Programlar];
GO
IF OBJECT_ID(N'[dbo].[StajDevamTakip]', 'U') IS NOT NULL
    DROP TABLE [dbo].[StajDevamTakip];
GO
IF OBJECT_ID(N'[dbo].[sysdiagrams]', 'U') IS NOT NULL
    DROP TABLE [dbo].[sysdiagrams];
GO
IF OBJECT_ID(N'[dbo].[YazdırılacakSayfaSayıları]', 'U') IS NOT NULL
    DROP TABLE [dbo].[YazdırılacakSayfaSayıları];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Akademisyen'
CREATE TABLE [dbo].[Akademisyen] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [ElemanAdi] nvarchar(50)  NULL,
    [Unvani] nvarchar(50)  NULL,
    [idariGörevi] nvarchar(50)  NULL,
    [eposta] nvarchar(50)  NULL
);
GO

-- Creating table 'Bölümler'
CREATE TABLE [dbo].[Bölümler] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [BolumAdi] nvarchar(50)  NULL,
    [KisaAdi] nvarchar(50)  NULL,
    [Baskan] int  NOT NULL
);
GO

-- Creating table 'Liste'
CREATE TABLE [dbo].[Liste] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [OgrenciID] int  NULL
);
GO

-- Creating table 'OkulAyar'
CREATE TABLE [dbo].[OkulAyar] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [okulAdi] nvarchar(100)  NULL,
    [ogretimYili] nvarchar(50)  NULL,
    [yariYili] nvarchar(10)  NULL,
    [stajSure] tinyint  NULL,
    [baslamaTarihi] datetime  NULL,
    [bitisTarihi] datetime  NULL
);
GO

-- Creating table 'Öğrenciler'
CREATE TABLE [dbo].[Öğrenciler] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [ogrenciNo] nvarchar(20)  NULL,
    [tcKimlikNo] nvarchar(11)  NULL,
    [adi] nvarchar(50)  NULL,
    [soyAdi] nvarchar(50)  NULL,
    [cinsiyet] nvarchar(10)  NULL,
    [dogumYeri] nvarchar(50)  NULL,
    [dogumTarihi] datetime  NULL,
    [programID] int  NULL,
    [sinifi] tinyint  NULL,
    [telefon] nvarchar(20)  NULL,
    [ikametAdresi] nvarchar(150)  NULL,
    [ikametAdresİl] nvarchar(30)  NULL,
    [ikametAdresİlce] nvarchar(30)  NULL,
    [eposta] nvarchar(50)  NULL,
    [stajDurumu] nvarchar(30)  NULL,
    [stajSonuc] nvarchar(30)  NULL,
    [kimlikID] nvarchar(50)  NULL,
    [anneAdi] nvarchar(30)  NULL,
    [babaAdi] nvarchar(30)  NULL,
    [uyrugu] nvarchar(30)  NULL,
    [kayitTarihi] datetime  NULL,
    [kayitNedeni] nvarchar(50)  NULL,
    [cezaSayisi] tinyint  NULL,
    [aktifDönemDersKayitSayisi] tinyint  NULL,
    [medeniHali] nchar(10)  NULL,
    [mahalleKöy] nchar(50)  NULL,
    [ciltNo] int  NULL,
    [aileSiraNo] int  NULL,
    [siraNo] int  NULL,
    [nüfKayİl] nchar(30)  NULL,
    [nüfKayİlçe] nchar(30)  NULL
);
GO

-- Creating table 'Programlar'
CREATE TABLE [dbo].[Programlar] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [ProgramAdi] nvarchar(50)  NULL,
    [ProgramKisaAdi] nvarchar(50)  NULL,
    [BolumID] int  NULL,
    [DanismaniBir] int  NULL,
    [Danismaniki] int  NULL
);
GO

-- Creating table 'StajDevamTakip'
CREATE TABLE [dbo].[StajDevamTakip] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [SiraNo] tinyint  NULL,
    [Tarih] datetime  NULL
);
GO

-- Creating table 'sysdiagrams'
CREATE TABLE [dbo].[sysdiagrams] (
    [name] nvarchar(128)  NOT NULL,
    [principal_id] int  NOT NULL,
    [diagram_id] int IDENTITY(1,1) NOT NULL,
    [version] int  NULL,
    [definition] varbinary(max)  NULL
);
GO

-- Creating table 'YazdırılacakSayfaSayıları'
CREATE TABLE [dbo].[YazdırılacakSayfaSayıları] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [StajBasvuruFormu] tinyint  NULL,
    [İsverenBilgiFormu] tinyint  NULL,
    [SigortalamaYazisi] tinyint  NULL,
    [BosRaporSayfasi] tinyint  NULL,
    [DevamTakipCizelgesi] tinyint  NULL,
    [DegerlendirmeFormu] tinyint  NULL,
    [Taahhütname] tinyint  NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [ID] in table 'Akademisyen'
ALTER TABLE [dbo].[Akademisyen]
ADD CONSTRAINT [PK_Akademisyen]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'Bölümler'
ALTER TABLE [dbo].[Bölümler]
ADD CONSTRAINT [PK_Bölümler]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'Liste'
ALTER TABLE [dbo].[Liste]
ADD CONSTRAINT [PK_Liste]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'OkulAyar'
ALTER TABLE [dbo].[OkulAyar]
ADD CONSTRAINT [PK_OkulAyar]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'Öğrenciler'
ALTER TABLE [dbo].[Öğrenciler]
ADD CONSTRAINT [PK_Öğrenciler]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'Programlar'
ALTER TABLE [dbo].[Programlar]
ADD CONSTRAINT [PK_Programlar]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'StajDevamTakip'
ALTER TABLE [dbo].[StajDevamTakip]
ADD CONSTRAINT [PK_StajDevamTakip]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [diagram_id] in table 'sysdiagrams'
ALTER TABLE [dbo].[sysdiagrams]
ADD CONSTRAINT [PK_sysdiagrams]
    PRIMARY KEY CLUSTERED ([diagram_id] ASC);
GO

-- Creating primary key on [ID] in table 'YazdırılacakSayfaSayıları'
ALTER TABLE [dbo].[YazdırılacakSayfaSayıları]
ADD CONSTRAINT [PK_YazdırılacakSayfaSayıları]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Baskan] in table 'Bölümler'
ALTER TABLE [dbo].[Bölümler]
ADD CONSTRAINT [FK_Bölümler_Akademisyen]
    FOREIGN KEY ([Baskan])
    REFERENCES [dbo].[Akademisyen]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Bölümler_Akademisyen'
CREATE INDEX [IX_FK_Bölümler_Akademisyen]
ON [dbo].[Bölümler]
    ([Baskan]);
GO

-- Creating foreign key on [DanismaniBir] in table 'Programlar'
ALTER TABLE [dbo].[Programlar]
ADD CONSTRAINT [FK_Programlar_Akademisyen]
    FOREIGN KEY ([DanismaniBir])
    REFERENCES [dbo].[Akademisyen]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Programlar_Akademisyen'
CREATE INDEX [IX_FK_Programlar_Akademisyen]
ON [dbo].[Programlar]
    ([DanismaniBir]);
GO

-- Creating foreign key on [Danismaniki] in table 'Programlar'
ALTER TABLE [dbo].[Programlar]
ADD CONSTRAINT [FK_Programlar_Akademisyen1]
    FOREIGN KEY ([Danismaniki])
    REFERENCES [dbo].[Akademisyen]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Programlar_Akademisyen1'
CREATE INDEX [IX_FK_Programlar_Akademisyen1]
ON [dbo].[Programlar]
    ([Danismaniki]);
GO

-- Creating foreign key on [BolumID] in table 'Programlar'
ALTER TABLE [dbo].[Programlar]
ADD CONSTRAINT [FK_Programlar_Bölümler]
    FOREIGN KEY ([BolumID])
    REFERENCES [dbo].[Bölümler]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Programlar_Bölümler'
CREATE INDEX [IX_FK_Programlar_Bölümler]
ON [dbo].[Programlar]
    ([BolumID]);
GO

-- Creating foreign key on [OgrenciID] in table 'Liste'
ALTER TABLE [dbo].[Liste]
ADD CONSTRAINT [FK_Liste_Öğrenciler]
    FOREIGN KEY ([OgrenciID])
    REFERENCES [dbo].[Öğrenciler]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Liste_Öğrenciler'
CREATE INDEX [IX_FK_Liste_Öğrenciler]
ON [dbo].[Liste]
    ([OgrenciID]);
GO

-- Creating foreign key on [programID] in table 'Öğrenciler'
ALTER TABLE [dbo].[Öğrenciler]
ADD CONSTRAINT [FK_Öğrenciler_Programlar1]
    FOREIGN KEY ([programID])
    REFERENCES [dbo].[Programlar]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Öğrenciler_Programlar1'
CREATE INDEX [IX_FK_Öğrenciler_Programlar1]
ON [dbo].[Öğrenciler]
    ([programID]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------