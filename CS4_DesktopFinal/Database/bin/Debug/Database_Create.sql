﻿/*
Deployment script for Database

This code was generated by a tool.
Changes to this file may cause incorrect behavior and will be lost if
the code is regenerated.
*/

GO
SET ANSI_NULLS, ANSI_PADDING, ANSI_WARNINGS, ARITHABORT, CONCAT_NULL_YIELDS_NULL, QUOTED_IDENTIFIER ON;

SET NUMERIC_ROUNDABORT OFF;


GO
:setvar DatabaseName "Database"
:setvar DefaultFilePrefix "Database"
:setvar DefaultDataPath ""
:setvar DefaultLogPath ""

GO
:on error exit
GO
/*
Detect SQLCMD mode and disable script execution if SQLCMD mode is not supported.
To re-enable the script after enabling SQLCMD mode, execute the following:
SET NOEXEC OFF; 
*/
:setvar __IsSqlCmdEnabled "True"
GO
IF N'$(__IsSqlCmdEnabled)' NOT LIKE N'True'
    BEGIN
        PRINT N'SQLCMD mode must be enabled to successfully execute this script.';
        SET NOEXEC ON;
    END


GO
USE [master];


GO

IF (DB_ID(N'$(DatabaseName)') IS NOT NULL) 
BEGIN
    ALTER DATABASE [$(DatabaseName)]
    SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
    DROP DATABASE [$(DatabaseName)];
END

GO
PRINT N'Creating $(DatabaseName)...'
GO
CREATE DATABASE [$(DatabaseName)] COLLATE SQL_Latin1_General_CP1_CI_AS
GO
IF EXISTS (SELECT 1
           FROM   [master].[dbo].[sysdatabases]
           WHERE  [name] = N'$(DatabaseName)')
    BEGIN
        ALTER DATABASE [$(DatabaseName)]
            SET ANSI_NULLS ON,
                ANSI_PADDING ON,
                ANSI_WARNINGS ON,
                ARITHABORT ON,
                CONCAT_NULL_YIELDS_NULL ON,
                NUMERIC_ROUNDABORT OFF,
                QUOTED_IDENTIFIER ON,
                ANSI_NULL_DEFAULT ON,
                CURSOR_DEFAULT LOCAL,
                RECOVERY FULL,
                CURSOR_CLOSE_ON_COMMIT OFF,
                AUTO_CREATE_STATISTICS ON,
                AUTO_SHRINK OFF,
                AUTO_UPDATE_STATISTICS ON,
                RECURSIVE_TRIGGERS OFF 
            WITH ROLLBACK IMMEDIATE;
        ALTER DATABASE [$(DatabaseName)]
            SET AUTO_CLOSE OFF 
            WITH ROLLBACK IMMEDIATE;
    END


GO
IF EXISTS (SELECT 1
           FROM   [master].[dbo].[sysdatabases]
           WHERE  [name] = N'$(DatabaseName)')
    BEGIN
        ALTER DATABASE [$(DatabaseName)]
            SET ALLOW_SNAPSHOT_ISOLATION OFF;
    END


GO
IF EXISTS (SELECT 1
           FROM   [master].[dbo].[sysdatabases]
           WHERE  [name] = N'$(DatabaseName)')
    BEGIN
        ALTER DATABASE [$(DatabaseName)]
            SET READ_COMMITTED_SNAPSHOT OFF 
            WITH ROLLBACK IMMEDIATE;
    END


GO
IF EXISTS (SELECT 1
           FROM   [master].[dbo].[sysdatabases]
           WHERE  [name] = N'$(DatabaseName)')
    BEGIN
        ALTER DATABASE [$(DatabaseName)]
            SET AUTO_UPDATE_STATISTICS_ASYNC OFF,
                PAGE_VERIFY NONE,
                DATE_CORRELATION_OPTIMIZATION OFF,
                DISABLE_BROKER,
                PARAMETERIZATION SIMPLE,
                SUPPLEMENTAL_LOGGING OFF 
            WITH ROLLBACK IMMEDIATE;
    END


GO
IF IS_SRVROLEMEMBER(N'sysadmin') = 1
    BEGIN
        IF EXISTS (SELECT 1
                   FROM   [master].[dbo].[sysdatabases]
                   WHERE  [name] = N'$(DatabaseName)')
            BEGIN
                EXECUTE sp_executesql N'ALTER DATABASE [$(DatabaseName)]
    SET TRUSTWORTHY OFF,
        DB_CHAINING OFF 
    WITH ROLLBACK IMMEDIATE';
            END
    END
ELSE
    BEGIN
        PRINT N'The database settings cannot be modified. You must be a SysAdmin to apply these settings.';
    END


GO
IF IS_SRVROLEMEMBER(N'sysadmin') = 1
    BEGIN
        IF EXISTS (SELECT 1
                   FROM   [master].[dbo].[sysdatabases]
                   WHERE  [name] = N'$(DatabaseName)')
            BEGIN
                EXECUTE sp_executesql N'ALTER DATABASE [$(DatabaseName)]
    SET HONOR_BROKER_PRIORITY OFF 
    WITH ROLLBACK IMMEDIATE';
            END
    END
ELSE
    BEGIN
        PRINT N'The database settings cannot be modified. You must be a SysAdmin to apply these settings.';
    END


GO
ALTER DATABASE [$(DatabaseName)]
    SET TARGET_RECOVERY_TIME = 0 SECONDS 
    WITH ROLLBACK IMMEDIATE;


GO
IF EXISTS (SELECT 1
           FROM   [master].[dbo].[sysdatabases]
           WHERE  [name] = N'$(DatabaseName)')
    BEGIN
        ALTER DATABASE [$(DatabaseName)]
            SET FILESTREAM(NON_TRANSACTED_ACCESS = OFF),
                CONTAINMENT = NONE 
            WITH ROLLBACK IMMEDIATE;
    END


GO
USE [$(DatabaseName)];


GO
IF fulltextserviceproperty(N'IsFulltextInstalled') = 1
    EXECUTE sp_fulltext_database 'enable';


GO
PRINT N'Creating [dbo].[Line_Item]...';


GO
CREATE TABLE [dbo].[Line_Item] (
    [D_line_item]  INT NOT NULL,
    [F_line_item]  INT NULL,
    [B_line_item]  INT NULL,
    [D_product_id] INT NULL,
    [D_order_id]   INT NULL,
    [quantity]     INT NULL,
    PRIMARY KEY CLUSTERED ([D_line_item] ASC)
);


GO
PRINT N'Creating [dbo].[Product]...';


GO
CREATE TABLE [dbo].[Product] (
    [D_product_id] INT           NOT NULL,
    [F_product_id] INT           NULL,
    [B_product_id] INT           NULL,
    [sku]          VARCHAR (255) NULL,
    [title]        VARCHAR (255) NULL,
    [type]         VARCHAR (255) NULL,
    [price]        INT           NULL,
    [stock]        INT           NULL,
    PRIMARY KEY CLUSTERED ([D_product_id] ASC)
);


GO
PRINT N'Creating [dbo].[Treatment]...';


GO
CREATE TABLE [dbo].[Treatment] (
    [consult_id]   INT NOT NULL,
    [body_part_id] INT NULL,
    [D_product_id] INT NULL,
    PRIMARY KEY CLUSTERED ([consult_id] ASC)
);


GO
PRINT N'Creating [dbo].[Consult]...';


GO
CREATE TABLE [dbo].[Consult] (
    [consult_id]           INT        NOT NULL,
    [record_id]            NCHAR (10) NULL,
    [physical_examination] TEXT       NULL,
    [care_plan]            TEXT       NULL,
    PRIMARY KEY CLUSTERED ([consult_id] ASC)
);


GO
PRINT N'Creating [dbo].[Order]...';


GO
CREATE TABLE [dbo].[Order] (
    [D_order_id]    INT           NOT NULL,
    [F_order_id]    INT           NULL,
    [B_order_id]    INT           NULL,
    [D_customer_id] INT           NULL,
    [status]        VARCHAR (255) NULL,
    [total]         INT           NULL,
    [created]       INT           NULL,
    [changed]       INT           NULL,
    PRIMARY KEY CLUSTERED ([D_order_id] ASC)
);


GO
PRINT N'Creating [dbo].[Record]...';


GO
CREATE TABLE [dbo].[Record] (
    [record_id]       INT        NOT NULL,
    [D_customer_id]   NCHAR (10) NULL,
    [patient_history] NCHAR (10) NULL,
    [Allergies]       NCHAR (10) NULL,
    [Medications]     NCHAR (10) NULL,
    PRIMARY KEY CLUSTERED ([record_id] ASC)
);


GO
PRINT N'Creating [dbo].[Body_Part]...';


GO
CREATE TABLE [dbo].[Body_Part] (
    [body_part_id]          INT           NOT NULL,
    [body_part_description] VARCHAR (255) NULL,
    PRIMARY KEY CLUSTERED ([body_part_id] ASC)
);


GO
PRINT N'Creating [dbo].[Problem]...';


GO
CREATE TABLE [dbo].[Problem] (
    [consult_id]   INT NOT NULL,
    [body_part_id] INT NULL,
    PRIMARY KEY CLUSTERED ([consult_id] ASC)
);


GO
PRINT N'Creating [dbo].[Bookings]...';


GO
CREATE TABLE [dbo].[Bookings] (
    [booking_id]    INT      NOT NULL,
    [date]          DATE     NULL,
    [time]          TIME (7) NULL,
    [description]   TEXT     NULL,
    [expert_id]     INT      NULL,
    [D_customer_id] INT      NULL,
    PRIMARY KEY CLUSTERED ([booking_id] ASC)
);


GO
PRINT N'Creating [dbo].[Customer]...';


GO
CREATE TABLE [dbo].[Customer] (
    [D_customer_id]    INT           NOT NULL,
    [F_user_id]        INT           NULL,
    [B_user_id]        INT           NULL,
    [expert_id]        INT           NULL,
    [salutory_address] VARCHAR (255) NULL,
    [first_name]       VARCHAR (255) NULL,
    [last_name]        VARCHAR (255) NULL,
    [mail]             VARCHAR (255) NULL,
    [street]           VARCHAR (255) NULL,
    [number]           VARCHAR (255) NULL,
    [city]             VARCHAR (255) NULL,
    [post_code]        VARCHAR (255) NULL,
    [country]          VARCHAR (255) NULL,
    PRIMARY KEY CLUSTERED ([D_customer_id] ASC)
);


GO
PRINT N'Creating [dbo].[Admin]...';


GO
CREATE TABLE [dbo].[Admin] (
    [admin_id] INT NOT NULL,
    [user_id]  INT NULL,
    PRIMARY KEY CLUSTERED ([admin_id] ASC)
);


GO
PRINT N'Creating [dbo].[User]...';


GO
CREATE TABLE [dbo].[User] (
    [user_id]    INT         NOT NULL,
    [username]   NCHAR (10)  NULL,
    [password]   NCHAR (10)  NULL,
    [first_name] NCHAR (255) NULL,
    [last_name]  NCHAR (255) NULL,
    PRIMARY KEY CLUSTERED ([user_id] ASC)
);


GO
PRINT N'Creating [dbo].[Expert]...';


GO
CREATE TABLE [dbo].[Expert] (
    [expert_id] INT NOT NULL,
    [user_id]   INT NULL,
    PRIMARY KEY CLUSTERED ([expert_id] ASC)
);


GO
-- Refactoring step to update target server with deployed transaction logs

IF OBJECT_ID(N'dbo.__RefactorLog') IS NULL
BEGIN
    CREATE TABLE [dbo].[__RefactorLog] (OperationKey UNIQUEIDENTIFIER NOT NULL PRIMARY KEY)
    EXEC sp_addextendedproperty N'microsoft_database_tools_support', N'refactoring log', N'schema', N'dbo', N'table', N'__RefactorLog'
END
GO
IF NOT EXISTS (SELECT OperationKey FROM [dbo].[__RefactorLog] WHERE OperationKey = 'f6fd6a5d-5420-4934-a9f4-f68a58e282fa')
INSERT INTO [dbo].[__RefactorLog] (OperationKey) values ('f6fd6a5d-5420-4934-a9f4-f68a58e282fa')
IF NOT EXISTS (SELECT OperationKey FROM [dbo].[__RefactorLog] WHERE OperationKey = 'a64d11a8-2af0-4d6f-bf04-b717b9879c09')
INSERT INTO [dbo].[__RefactorLog] (OperationKey) values ('a64d11a8-2af0-4d6f-bf04-b717b9879c09')
IF NOT EXISTS (SELECT OperationKey FROM [dbo].[__RefactorLog] WHERE OperationKey = '58989f83-1e3c-4dab-b605-82f2b5841f8c')
INSERT INTO [dbo].[__RefactorLog] (OperationKey) values ('58989f83-1e3c-4dab-b605-82f2b5841f8c')
IF NOT EXISTS (SELECT OperationKey FROM [dbo].[__RefactorLog] WHERE OperationKey = '4737f584-d9ea-4e07-8b94-513fa340eaf1')
INSERT INTO [dbo].[__RefactorLog] (OperationKey) values ('4737f584-d9ea-4e07-8b94-513fa340eaf1')
IF NOT EXISTS (SELECT OperationKey FROM [dbo].[__RefactorLog] WHERE OperationKey = '4da0cb20-9a46-4570-87c2-835c15e70094')
INSERT INTO [dbo].[__RefactorLog] (OperationKey) values ('4da0cb20-9a46-4570-87c2-835c15e70094')
IF NOT EXISTS (SELECT OperationKey FROM [dbo].[__RefactorLog] WHERE OperationKey = '75c17951-5d4e-4e4d-b661-ae4074ba7ba4')
INSERT INTO [dbo].[__RefactorLog] (OperationKey) values ('75c17951-5d4e-4e4d-b661-ae4074ba7ba4')
IF NOT EXISTS (SELECT OperationKey FROM [dbo].[__RefactorLog] WHERE OperationKey = '9668963c-3e25-4166-9e15-cfdb56a626aa')
INSERT INTO [dbo].[__RefactorLog] (OperationKey) values ('9668963c-3e25-4166-9e15-cfdb56a626aa')
IF NOT EXISTS (SELECT OperationKey FROM [dbo].[__RefactorLog] WHERE OperationKey = 'e4399a32-6478-4816-99dd-a479a44ee86c')
INSERT INTO [dbo].[__RefactorLog] (OperationKey) values ('e4399a32-6478-4816-99dd-a479a44ee86c')
IF NOT EXISTS (SELECT OperationKey FROM [dbo].[__RefactorLog] WHERE OperationKey = '5169d799-cbc1-420b-98d2-014614419bbb')
INSERT INTO [dbo].[__RefactorLog] (OperationKey) values ('5169d799-cbc1-420b-98d2-014614419bbb')
IF NOT EXISTS (SELECT OperationKey FROM [dbo].[__RefactorLog] WHERE OperationKey = '46069aaf-ca73-4e0c-b8da-62973718a52f')
INSERT INTO [dbo].[__RefactorLog] (OperationKey) values ('46069aaf-ca73-4e0c-b8da-62973718a52f')
IF NOT EXISTS (SELECT OperationKey FROM [dbo].[__RefactorLog] WHERE OperationKey = 'a18a1a3f-b29e-45be-a6a4-217f1cf0999f')
INSERT INTO [dbo].[__RefactorLog] (OperationKey) values ('a18a1a3f-b29e-45be-a6a4-217f1cf0999f')
IF NOT EXISTS (SELECT OperationKey FROM [dbo].[__RefactorLog] WHERE OperationKey = 'de21cc7f-4118-4518-bea0-c871180b454f')
INSERT INTO [dbo].[__RefactorLog] (OperationKey) values ('de21cc7f-4118-4518-bea0-c871180b454f')
IF NOT EXISTS (SELECT OperationKey FROM [dbo].[__RefactorLog] WHERE OperationKey = '312855f4-b2a9-4dc2-ae22-fc5509a1021a')
INSERT INTO [dbo].[__RefactorLog] (OperationKey) values ('312855f4-b2a9-4dc2-ae22-fc5509a1021a')
IF NOT EXISTS (SELECT OperationKey FROM [dbo].[__RefactorLog] WHERE OperationKey = '76b90d04-530b-476d-8f67-d563d3ba2fb2')
INSERT INTO [dbo].[__RefactorLog] (OperationKey) values ('76b90d04-530b-476d-8f67-d563d3ba2fb2')
IF NOT EXISTS (SELECT OperationKey FROM [dbo].[__RefactorLog] WHERE OperationKey = 'df0a011e-fb4e-433e-8bd4-f3dbbc4d5b99')
INSERT INTO [dbo].[__RefactorLog] (OperationKey) values ('df0a011e-fb4e-433e-8bd4-f3dbbc4d5b99')
IF NOT EXISTS (SELECT OperationKey FROM [dbo].[__RefactorLog] WHERE OperationKey = '51352b43-90dc-408d-a4d1-488fcd32fdf1')
INSERT INTO [dbo].[__RefactorLog] (OperationKey) values ('51352b43-90dc-408d-a4d1-488fcd32fdf1')
IF NOT EXISTS (SELECT OperationKey FROM [dbo].[__RefactorLog] WHERE OperationKey = '8903fc01-0225-4dfe-a576-c779880487b6')
INSERT INTO [dbo].[__RefactorLog] (OperationKey) values ('8903fc01-0225-4dfe-a576-c779880487b6')
IF NOT EXISTS (SELECT OperationKey FROM [dbo].[__RefactorLog] WHERE OperationKey = '765e704f-eec2-499d-9b10-90223fcbfabb')
INSERT INTO [dbo].[__RefactorLog] (OperationKey) values ('765e704f-eec2-499d-9b10-90223fcbfabb')
IF NOT EXISTS (SELECT OperationKey FROM [dbo].[__RefactorLog] WHERE OperationKey = '13489b00-fcdc-43fb-8859-3cdd29aa3757')
INSERT INTO [dbo].[__RefactorLog] (OperationKey) values ('13489b00-fcdc-43fb-8859-3cdd29aa3757')
IF NOT EXISTS (SELECT OperationKey FROM [dbo].[__RefactorLog] WHERE OperationKey = 'd9acbeb1-5f74-4c85-9a3b-db73217761de')
INSERT INTO [dbo].[__RefactorLog] (OperationKey) values ('d9acbeb1-5f74-4c85-9a3b-db73217761de')
IF NOT EXISTS (SELECT OperationKey FROM [dbo].[__RefactorLog] WHERE OperationKey = 'baed742b-88eb-4998-b9a6-0559ae8239d7')
INSERT INTO [dbo].[__RefactorLog] (OperationKey) values ('baed742b-88eb-4998-b9a6-0559ae8239d7')
IF NOT EXISTS (SELECT OperationKey FROM [dbo].[__RefactorLog] WHERE OperationKey = '90a1dc23-c02f-47d6-bc76-a55c5fe7236a')
INSERT INTO [dbo].[__RefactorLog] (OperationKey) values ('90a1dc23-c02f-47d6-bc76-a55c5fe7236a')
IF NOT EXISTS (SELECT OperationKey FROM [dbo].[__RefactorLog] WHERE OperationKey = '993ba659-a48b-4244-b66c-078b19b5c84d')
INSERT INTO [dbo].[__RefactorLog] (OperationKey) values ('993ba659-a48b-4244-b66c-078b19b5c84d')
IF NOT EXISTS (SELECT OperationKey FROM [dbo].[__RefactorLog] WHERE OperationKey = 'bb890cd5-098b-4a6c-9360-03e4f6b30528')
INSERT INTO [dbo].[__RefactorLog] (OperationKey) values ('bb890cd5-098b-4a6c-9360-03e4f6b30528')
IF NOT EXISTS (SELECT OperationKey FROM [dbo].[__RefactorLog] WHERE OperationKey = '047caac6-89fe-4846-83e2-a3a7e829046f')
INSERT INTO [dbo].[__RefactorLog] (OperationKey) values ('047caac6-89fe-4846-83e2-a3a7e829046f')
IF NOT EXISTS (SELECT OperationKey FROM [dbo].[__RefactorLog] WHERE OperationKey = '17e8949c-6275-4acc-89f3-4a99dbcd9113')
INSERT INTO [dbo].[__RefactorLog] (OperationKey) values ('17e8949c-6275-4acc-89f3-4a99dbcd9113')
IF NOT EXISTS (SELECT OperationKey FROM [dbo].[__RefactorLog] WHERE OperationKey = 'a42c8ca7-d1f0-4ba2-bf57-a427d721863a')
INSERT INTO [dbo].[__RefactorLog] (OperationKey) values ('a42c8ca7-d1f0-4ba2-bf57-a427d721863a')
IF NOT EXISTS (SELECT OperationKey FROM [dbo].[__RefactorLog] WHERE OperationKey = 'ce17b767-39e7-4518-ab76-3ca8855ff937')
INSERT INTO [dbo].[__RefactorLog] (OperationKey) values ('ce17b767-39e7-4518-ab76-3ca8855ff937')
IF NOT EXISTS (SELECT OperationKey FROM [dbo].[__RefactorLog] WHERE OperationKey = '13243da5-50eb-4ca0-89d7-c1164a7d8ad4')
INSERT INTO [dbo].[__RefactorLog] (OperationKey) values ('13243da5-50eb-4ca0-89d7-c1164a7d8ad4')

GO

GO
DECLARE @VarDecimalSupported AS BIT;

SELECT @VarDecimalSupported = 0;

IF ((ServerProperty(N'EngineEdition') = 3)
    AND (((@@microsoftversion / power(2, 24) = 9)
          AND (@@microsoftversion & 0xffff >= 3024))
         OR ((@@microsoftversion / power(2, 24) = 10)
             AND (@@microsoftversion & 0xffff >= 1600))))
    SELECT @VarDecimalSupported = 1;

IF (@VarDecimalSupported > 0)
    BEGIN
        EXECUTE sp_db_vardecimal_storage_format N'$(DatabaseName)', 'ON';
    END


GO
ALTER DATABASE [$(DatabaseName)]
    SET MULTI_USER 
    WITH ROLLBACK IMMEDIATE;


GO
PRINT N'Update complete.';


GO
