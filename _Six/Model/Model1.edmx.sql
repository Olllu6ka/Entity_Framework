
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 05/11/2023 19:18:01
-- Generated from EDMX file: C:\Users\Мой друг\source\repos\Entity Framework\Third_\Model\Model1.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [Baseowner];
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

-- Creating table 'CustomersSet'
CREATE TABLE [dbo].[CustomersSet] (
    [customer_id] nvarchar(max)  NOT NULL,
    [customer_name] nvarchar(max)  NOT NULL,
    [Id] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'OrdersSet'
CREATE TABLE [dbo].[OrdersSet] (
    [order_id] nvarchar(max)  NOT NULL,
    [customer_id] nvarchar(max)  NOT NULL,
    [amount] nvarchar(max)  NOT NULL,
    [Id] nvarchar(max)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'CustomersSet'
ALTER TABLE [dbo].[CustomersSet]
ADD CONSTRAINT [PK_CustomersSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'OrdersSet'
ALTER TABLE [dbo].[OrdersSet]
ADD CONSTRAINT [PK_OrdersSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------