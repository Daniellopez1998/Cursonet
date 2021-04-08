
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 03/22/2021 09:59:41
-- Generated from EDMX file: C:\Users\MAÑANA\source\repos\Cursonet\ModelFirstLunes\ModelFirstLunes\Model1.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [ModelFirstLunes];
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

-- Creating table 'ClientesSet'
CREATE TABLE [dbo].[ClientesSet] (
    [ClienteId] int IDENTITY(1,1) NOT NULL,
    [Nombre] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'PedidosSet'
CREATE TABLE [dbo].[PedidosSet] (
    [PedidoId] int IDENTITY(1,1) NOT NULL,
    [ClienteId] int  NOT NULL
);
GO

-- Creating table 'LineaPedidosSet'
CREATE TABLE [dbo].[LineaPedidosSet] (
    [LineaPedidosId] int IDENTITY(1,1) NOT NULL,
    [PedidoId] int  NOT NULL,
    [ProductoId] int  NOT NULL,
    [Unidades] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'ProductosSet'
CREATE TABLE [dbo].[ProductosSet] (
    [ProductoId] int IDENTITY(1,1) NOT NULL,
    [Descripcion] nvarchar(max)  NOT NULL,
    [Precio] nvarchar(max)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [ClienteId] in table 'ClientesSet'
ALTER TABLE [dbo].[ClientesSet]
ADD CONSTRAINT [PK_ClientesSet]
    PRIMARY KEY CLUSTERED ([ClienteId] ASC);
GO

-- Creating primary key on [PedidoId] in table 'PedidosSet'
ALTER TABLE [dbo].[PedidosSet]
ADD CONSTRAINT [PK_PedidosSet]
    PRIMARY KEY CLUSTERED ([PedidoId] ASC);
GO

-- Creating primary key on [LineaPedidosId] in table 'LineaPedidosSet'
ALTER TABLE [dbo].[LineaPedidosSet]
ADD CONSTRAINT [PK_LineaPedidosSet]
    PRIMARY KEY CLUSTERED ([LineaPedidosId] ASC);
GO

-- Creating primary key on [ProductoId] in table 'ProductosSet'
ALTER TABLE [dbo].[ProductosSet]
ADD CONSTRAINT [PK_ProductosSet]
    PRIMARY KEY CLUSTERED ([ProductoId] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [ClienteId] in table 'PedidosSet'
ALTER TABLE [dbo].[PedidosSet]
ADD CONSTRAINT [FK_ClientesPedidos]
    FOREIGN KEY ([ClienteId])
    REFERENCES [dbo].[ClientesSet]
        ([ClienteId])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ClientesPedidos'
CREATE INDEX [IX_FK_ClientesPedidos]
ON [dbo].[PedidosSet]
    ([ClienteId]);
GO

-- Creating foreign key on [PedidoId] in table 'LineaPedidosSet'
ALTER TABLE [dbo].[LineaPedidosSet]
ADD CONSTRAINT [FK_PedidosLineaPedidos]
    FOREIGN KEY ([PedidoId])
    REFERENCES [dbo].[PedidosSet]
        ([PedidoId])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PedidosLineaPedidos'
CREATE INDEX [IX_FK_PedidosLineaPedidos]
ON [dbo].[LineaPedidosSet]
    ([PedidoId]);
GO

-- Creating foreign key on [ProductoId] in table 'LineaPedidosSet'
ALTER TABLE [dbo].[LineaPedidosSet]
ADD CONSTRAINT [FK_LineaPedidosProductos]
    FOREIGN KEY ([ProductoId])
    REFERENCES [dbo].[ProductosSet]
        ([ProductoId])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_LineaPedidosProductos'
CREATE INDEX [IX_FK_LineaPedidosProductos]
ON [dbo].[LineaPedidosSet]
    ([ProductoId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------