
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 05/01/2019 22:06:49
-- Generated from EDMX file: C:\Users\Miguel Ribeiro\Desktop\ESTG\2º Semestre 2018-2019\Desenvolvimento de Aplicações\RealStand\FormPrincipal\RealStand\BaseDadosRealStand.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [RealStandBD];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_ClienteCarroOficina]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Carro_CarroOficina] DROP CONSTRAINT [FK_ClienteCarroOficina];
GO
IF OBJECT_ID(N'[dbo].[FK_CarroOficinaServico]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Servico] DROP CONSTRAINT [FK_CarroOficinaServico];
GO
IF OBJECT_ID(N'[dbo].[FK_ServicoParcela]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Parcela] DROP CONSTRAINT [FK_ServicoParcela];
GO
IF OBJECT_ID(N'[dbo].[FK_ClienteVenda]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Venda] DROP CONSTRAINT [FK_ClienteVenda];
GO
IF OBJECT_ID(N'[dbo].[FK_CarroAluguerAluguer]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Aluguer] DROP CONSTRAINT [FK_CarroAluguerAluguer];
GO
IF OBJECT_ID(N'[dbo].[FK_ClienteAluguer]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Aluguer] DROP CONSTRAINT [FK_ClienteAluguer];
GO
IF OBJECT_ID(N'[dbo].[FK_CarroVendaVenda]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Carro_CarroVenda] DROP CONSTRAINT [FK_CarroVendaVenda];
GO
IF OBJECT_ID(N'[dbo].[FK_CarroOficina_inherits_Carro]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Carro_CarroOficina] DROP CONSTRAINT [FK_CarroOficina_inherits_Carro];
GO
IF OBJECT_ID(N'[dbo].[FK_CarroAluguer_inherits_Carro]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Carro_CarroAluguer] DROP CONSTRAINT [FK_CarroAluguer_inherits_Carro];
GO
IF OBJECT_ID(N'[dbo].[FK_CarroVenda_inherits_Carro]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Carro_CarroVenda] DROP CONSTRAINT [FK_CarroVenda_inherits_Carro];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Cliente]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Cliente];
GO
IF OBJECT_ID(N'[dbo].[Carro]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Carro];
GO
IF OBJECT_ID(N'[dbo].[Servico]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Servico];
GO
IF OBJECT_ID(N'[dbo].[Parcela]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Parcela];
GO
IF OBJECT_ID(N'[dbo].[Venda]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Venda];
GO
IF OBJECT_ID(N'[dbo].[Aluguer]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Aluguer];
GO
IF OBJECT_ID(N'[dbo].[Carro_CarroOficina]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Carro_CarroOficina];
GO
IF OBJECT_ID(N'[dbo].[Carro_CarroAluguer]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Carro_CarroAluguer];
GO
IF OBJECT_ID(N'[dbo].[Carro_CarroVenda]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Carro_CarroVenda];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Cliente'
CREATE TABLE [dbo].[Cliente] (
    [IdCliente] int IDENTITY(1,1) NOT NULL,
    [Nome] nvarchar(max)  NOT NULL,
    [NIF] nvarchar(max)  NOT NULL,
    [Morada] nvarchar(max)  NOT NULL,
    [Contacto] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Carro'
CREATE TABLE [dbo].[Carro] (
    [IdCarro] int IDENTITY(1,1) NOT NULL,
    [NumeroChassis] nvarchar(max)  NOT NULL,
    [Marca] nvarchar(max)  NOT NULL,
    [Modelo] nvarchar(max)  NOT NULL,
    [Combustivel] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Servico'
CREATE TABLE [dbo].[Servico] (
    [IdServico] int IDENTITY(1,1) NOT NULL,
    [DataEntrada] nvarchar(max)  NOT NULL,
    [Tipo] nvarchar(max)  NOT NULL,
    [CarroOficinaCarro] int  NOT NULL,
    [CarroOficina_IdCarro] int  NOT NULL
);
GO

-- Creating table 'Parcela'
CREATE TABLE [dbo].[Parcela] (
    [IdParcela] int IDENTITY(1,1) NOT NULL,
    [Valor] decimal(18,0)  NOT NULL,
    [Descricao] nvarchar(max)  NOT NULL,
    [ServicoIdServico] int  NOT NULL,
    [Servico_IdServico] int  NOT NULL
);
GO

-- Creating table 'Venda'
CREATE TABLE [dbo].[Venda] (
    [IdVenda] int IDENTITY(1,1) NOT NULL,
    [Valor] decimal(18,0)  NOT NULL,
    [Estado] nvarchar(max)  NOT NULL,
    [DataVenda] datetime  NOT NULL,
    [ClienteIdCliente] int  NOT NULL,
    [Cliente_IdCliente] int  NOT NULL
);
GO

-- Creating table 'Aluguer'
CREATE TABLE [dbo].[Aluguer] (
    [IdAluguer] int IDENTITY(1,1) NOT NULL,
    [DataInicio] datetime  NOT NULL,
    [DataFim] nvarchar(max)  NOT NULL,
    [Valor] decimal(18,0)  NOT NULL,
    [Kms] decimal(18,0)  NOT NULL,
    [ClienteIdCliente] nvarchar(max)  NOT NULL,
    [CarroAluguer_IdCarro] int  NOT NULL,
    [Cliente_IdCliente] int  NOT NULL
);
GO

-- Creating table 'Carro_CarroOficina'
CREATE TABLE [dbo].[Carro_CarroOficina] (
    [Matricula] nvarchar(max)  NOT NULL,
    [Kms] nvarchar(max)  NOT NULL,
    [ClienteIdCliente] int  NOT NULL,
    [IdCarro] int  NOT NULL,
    [Cliente_IdCliente] int  NOT NULL
);
GO

-- Creating table 'Carro_CarroAluguer'
CREATE TABLE [dbo].[Carro_CarroAluguer] (
    [Estado] nvarchar(max)  NOT NULL,
    [Matricula] nvarchar(max)  NOT NULL,
    [IdCarro] int  NOT NULL
);
GO

-- Creating table 'Carro_CarroVenda'
CREATE TABLE [dbo].[Carro_CarroVenda] (
    [Extras] nvarchar(max)  NOT NULL,
    [IdCarro] int  NOT NULL,
    [Venda_IdVenda] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [IdCliente] in table 'Cliente'
ALTER TABLE [dbo].[Cliente]
ADD CONSTRAINT [PK_Cliente]
    PRIMARY KEY CLUSTERED ([IdCliente] ASC);
GO

-- Creating primary key on [IdCarro] in table 'Carro'
ALTER TABLE [dbo].[Carro]
ADD CONSTRAINT [PK_Carro]
    PRIMARY KEY CLUSTERED ([IdCarro] ASC);
GO

-- Creating primary key on [IdServico] in table 'Servico'
ALTER TABLE [dbo].[Servico]
ADD CONSTRAINT [PK_Servico]
    PRIMARY KEY CLUSTERED ([IdServico] ASC);
GO

-- Creating primary key on [IdParcela] in table 'Parcela'
ALTER TABLE [dbo].[Parcela]
ADD CONSTRAINT [PK_Parcela]
    PRIMARY KEY CLUSTERED ([IdParcela] ASC);
GO

-- Creating primary key on [IdVenda] in table 'Venda'
ALTER TABLE [dbo].[Venda]
ADD CONSTRAINT [PK_Venda]
    PRIMARY KEY CLUSTERED ([IdVenda] ASC);
GO

-- Creating primary key on [IdAluguer] in table 'Aluguer'
ALTER TABLE [dbo].[Aluguer]
ADD CONSTRAINT [PK_Aluguer]
    PRIMARY KEY CLUSTERED ([IdAluguer] ASC);
GO

-- Creating primary key on [IdCarro] in table 'Carro_CarroOficina'
ALTER TABLE [dbo].[Carro_CarroOficina]
ADD CONSTRAINT [PK_Carro_CarroOficina]
    PRIMARY KEY CLUSTERED ([IdCarro] ASC);
GO

-- Creating primary key on [IdCarro] in table 'Carro_CarroAluguer'
ALTER TABLE [dbo].[Carro_CarroAluguer]
ADD CONSTRAINT [PK_Carro_CarroAluguer]
    PRIMARY KEY CLUSTERED ([IdCarro] ASC);
GO

-- Creating primary key on [IdCarro] in table 'Carro_CarroVenda'
ALTER TABLE [dbo].[Carro_CarroVenda]
ADD CONSTRAINT [PK_Carro_CarroVenda]
    PRIMARY KEY CLUSTERED ([IdCarro] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Cliente_IdCliente] in table 'Carro_CarroOficina'
ALTER TABLE [dbo].[Carro_CarroOficina]
ADD CONSTRAINT [FK_ClienteCarroOficina]
    FOREIGN KEY ([Cliente_IdCliente])
    REFERENCES [dbo].[Cliente]
        ([IdCliente])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ClienteCarroOficina'
CREATE INDEX [IX_FK_ClienteCarroOficina]
ON [dbo].[Carro_CarroOficina]
    ([Cliente_IdCliente]);
GO

-- Creating foreign key on [CarroOficina_IdCarro] in table 'Servico'
ALTER TABLE [dbo].[Servico]
ADD CONSTRAINT [FK_CarroOficinaServico]
    FOREIGN KEY ([CarroOficina_IdCarro])
    REFERENCES [dbo].[Carro_CarroOficina]
        ([IdCarro])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CarroOficinaServico'
CREATE INDEX [IX_FK_CarroOficinaServico]
ON [dbo].[Servico]
    ([CarroOficina_IdCarro]);
GO

-- Creating foreign key on [Servico_IdServico] in table 'Parcela'
ALTER TABLE [dbo].[Parcela]
ADD CONSTRAINT [FK_ServicoParcela]
    FOREIGN KEY ([Servico_IdServico])
    REFERENCES [dbo].[Servico]
        ([IdServico])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ServicoParcela'
CREATE INDEX [IX_FK_ServicoParcela]
ON [dbo].[Parcela]
    ([Servico_IdServico]);
GO

-- Creating foreign key on [Cliente_IdCliente] in table 'Venda'
ALTER TABLE [dbo].[Venda]
ADD CONSTRAINT [FK_ClienteVenda]
    FOREIGN KEY ([Cliente_IdCliente])
    REFERENCES [dbo].[Cliente]
        ([IdCliente])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ClienteVenda'
CREATE INDEX [IX_FK_ClienteVenda]
ON [dbo].[Venda]
    ([Cliente_IdCliente]);
GO

-- Creating foreign key on [CarroAluguer_IdCarro] in table 'Aluguer'
ALTER TABLE [dbo].[Aluguer]
ADD CONSTRAINT [FK_CarroAluguerAluguer]
    FOREIGN KEY ([CarroAluguer_IdCarro])
    REFERENCES [dbo].[Carro_CarroAluguer]
        ([IdCarro])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CarroAluguerAluguer'
CREATE INDEX [IX_FK_CarroAluguerAluguer]
ON [dbo].[Aluguer]
    ([CarroAluguer_IdCarro]);
GO

-- Creating foreign key on [Cliente_IdCliente] in table 'Aluguer'
ALTER TABLE [dbo].[Aluguer]
ADD CONSTRAINT [FK_ClienteAluguer]
    FOREIGN KEY ([Cliente_IdCliente])
    REFERENCES [dbo].[Cliente]
        ([IdCliente])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ClienteAluguer'
CREATE INDEX [IX_FK_ClienteAluguer]
ON [dbo].[Aluguer]
    ([Cliente_IdCliente]);
GO

-- Creating foreign key on [Venda_IdVenda] in table 'Carro_CarroVenda'
ALTER TABLE [dbo].[Carro_CarroVenda]
ADD CONSTRAINT [FK_CarroVendaVenda]
    FOREIGN KEY ([Venda_IdVenda])
    REFERENCES [dbo].[Venda]
        ([IdVenda])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CarroVendaVenda'
CREATE INDEX [IX_FK_CarroVendaVenda]
ON [dbo].[Carro_CarroVenda]
    ([Venda_IdVenda]);
GO

-- Creating foreign key on [IdCarro] in table 'Carro_CarroOficina'
ALTER TABLE [dbo].[Carro_CarroOficina]
ADD CONSTRAINT [FK_CarroOficina_inherits_Carro]
    FOREIGN KEY ([IdCarro])
    REFERENCES [dbo].[Carro]
        ([IdCarro])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating foreign key on [IdCarro] in table 'Carro_CarroAluguer'
ALTER TABLE [dbo].[Carro_CarroAluguer]
ADD CONSTRAINT [FK_CarroAluguer_inherits_Carro]
    FOREIGN KEY ([IdCarro])
    REFERENCES [dbo].[Carro]
        ([IdCarro])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating foreign key on [IdCarro] in table 'Carro_CarroVenda'
ALTER TABLE [dbo].[Carro_CarroVenda]
ADD CONSTRAINT [FK_CarroVenda_inherits_Carro]
    FOREIGN KEY ([IdCarro])
    REFERENCES [dbo].[Carro]
        ([IdCarro])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------