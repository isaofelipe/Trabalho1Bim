
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 04/28/2018 20:09:37
-- Generated from EDMX file: D:\Repositorios\Trabalho1Bim\Trabalho1Bim\Models\ModelDatabase1.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [trabalho1-eng-soft];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_ClienteVenda]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Venda] DROP CONSTRAINT [FK_ClienteVenda];
GO
IF OBJECT_ID(N'[dbo].[FK_VendedorVenda]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Venda] DROP CONSTRAINT [FK_VendedorVenda];
GO
IF OBJECT_ID(N'[dbo].[FK_VendaItemVenda]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ItemVenda] DROP CONSTRAINT [FK_VendaItemVenda];
GO
IF OBJECT_ID(N'[dbo].[FK_ProdutoItemVenda]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ItemVenda] DROP CONSTRAINT [FK_ProdutoItemVenda];
GO
IF OBJECT_ID(N'[dbo].[FK_ItemCompra_Produto]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ItemCompra] DROP CONSTRAINT [FK_ItemCompra_Produto];
GO
IF OBJECT_ID(N'[dbo].[FK_ItemCompra_Compra]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ItemCompra] DROP CONSTRAINT [FK_ItemCompra_Compra];
GO
IF OBJECT_ID(N'[dbo].[FK_CompraFornecedor]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Compra] DROP CONSTRAINT [FK_CompraFornecedor];
GO
IF OBJECT_ID(N'[dbo].[FK_Cliente_inherits_Pessoa]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Pessoa_Cliente] DROP CONSTRAINT [FK_Cliente_inherits_Pessoa];
GO
IF OBJECT_ID(N'[dbo].[FK_Vendedor_inherits_Pessoa]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Pessoa_Vendedor] DROP CONSTRAINT [FK_Vendedor_inherits_Pessoa];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Compra]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Compra];
GO
IF OBJECT_ID(N'[dbo].[Fornecedor]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Fornecedor];
GO
IF OBJECT_ID(N'[dbo].[ItemCompra]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ItemCompra];
GO
IF OBJECT_ID(N'[dbo].[ItemVenda]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ItemVenda];
GO
IF OBJECT_ID(N'[dbo].[Pessoa]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Pessoa];
GO
IF OBJECT_ID(N'[dbo].[Pessoa_Cliente]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Pessoa_Cliente];
GO
IF OBJECT_ID(N'[dbo].[Pessoa_Vendedor]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Pessoa_Vendedor];
GO
IF OBJECT_ID(N'[dbo].[Produto]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Produto];
GO
IF OBJECT_ID(N'[dbo].[Venda]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Venda];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Compra'
CREATE TABLE [dbo].[Compra] (
    [idCompra] int IDENTITY(1,1) NOT NULL,
    [data] datetime  NOT NULL,
    [fornecedorId] int  NOT NULL,
    [Fornecedor_idFornecedor] int  NOT NULL
);
GO

-- Creating table 'Fornecedor'
CREATE TABLE [dbo].[Fornecedor] (
    [idFornecedor] int IDENTITY(1,1) NOT NULL,
    [nome] nchar(30)  NOT NULL,
    [cnpj] nchar(14)  NOT NULL
);
GO

-- Creating table 'ItemCompra'
CREATE TABLE [dbo].[ItemCompra] (
    [idItemCompra] int IDENTITY(1,1) NOT NULL,
    [precoUnitario] float  NOT NULL,
    [quantidade] int  NOT NULL,
    [Produto_idProduto] int  NOT NULL,
    [Compra_idCompra] int  NOT NULL
);
GO

-- Creating table 'ItemVenda'
CREATE TABLE [dbo].[ItemVenda] (
    [idItemVenda] int IDENTITY(1,1) NOT NULL,
    [precoUnitario] float  NOT NULL,
    [quantidade] int  NOT NULL,
    [Venda_idVenda] int  NOT NULL,
    [Produto_idProduto] int  NOT NULL
);
GO

-- Creating table 'Pessoa'
CREATE TABLE [dbo].[Pessoa] (
    [idPessoa] int IDENTITY(1,1) NOT NULL,
    [nome] nchar(30)  NOT NULL,
    [cpf] nchar(11)  NOT NULL
);
GO

-- Creating table 'Pessoa_Cliente'
CREATE TABLE [dbo].[Pessoa_Cliente] (
    [idCliente] int IDENTITY(1,1) NOT NULL,
    [telefone] nchar(10)  NULL,
    [endereco] nchar(30)  NULL,
    [idPessoa] int  NOT NULL
);
GO

-- Creating table 'Pessoa_Vendedor'
CREATE TABLE [dbo].[Pessoa_Vendedor] (
    [idVendedor] int IDENTITY(1,1) NOT NULL,
    [login] nchar(10)  NOT NULL,
    [senha] nchar(10)  NOT NULL,
    [idPessoa] int  NOT NULL
);
GO

-- Creating table 'Produto'
CREATE TABLE [dbo].[Produto] (
    [idProduto] int IDENTITY(1,1) NOT NULL,
    [categoria] int  NOT NULL,
    [estoque] int  NOT NULL,
    [precoUnitario] float  NOT NULL,
    [nome] nchar(30)  NOT NULL
);
GO

-- Creating table 'Venda'
CREATE TABLE [dbo].[Venda] (
    [idVenda] int IDENTITY(1,1) NOT NULL,
    [data] datetime  NULL,
    [Cliente_idPessoa] int  NOT NULL,
    [Vendedor_idPessoa] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [idCompra] in table 'Compra'
ALTER TABLE [dbo].[Compra]
ADD CONSTRAINT [PK_Compra]
    PRIMARY KEY CLUSTERED ([idCompra] ASC);
GO

-- Creating primary key on [idFornecedor] in table 'Fornecedor'
ALTER TABLE [dbo].[Fornecedor]
ADD CONSTRAINT [PK_Fornecedor]
    PRIMARY KEY CLUSTERED ([idFornecedor] ASC);
GO

-- Creating primary key on [idItemCompra] in table 'ItemCompra'
ALTER TABLE [dbo].[ItemCompra]
ADD CONSTRAINT [PK_ItemCompra]
    PRIMARY KEY CLUSTERED ([idItemCompra] ASC);
GO

-- Creating primary key on [idItemVenda] in table 'ItemVenda'
ALTER TABLE [dbo].[ItemVenda]
ADD CONSTRAINT [PK_ItemVenda]
    PRIMARY KEY CLUSTERED ([idItemVenda] ASC);
GO

-- Creating primary key on [idPessoa] in table 'Pessoa'
ALTER TABLE [dbo].[Pessoa]
ADD CONSTRAINT [PK_Pessoa]
    PRIMARY KEY CLUSTERED ([idPessoa] ASC);
GO

-- Creating primary key on [idPessoa] in table 'Pessoa_Cliente'
ALTER TABLE [dbo].[Pessoa_Cliente]
ADD CONSTRAINT [PK_Pessoa_Cliente]
    PRIMARY KEY CLUSTERED ([idPessoa] ASC);
GO

-- Creating primary key on [idPessoa] in table 'Pessoa_Vendedor'
ALTER TABLE [dbo].[Pessoa_Vendedor]
ADD CONSTRAINT [PK_Pessoa_Vendedor]
    PRIMARY KEY CLUSTERED ([idPessoa] ASC);
GO

-- Creating primary key on [idProduto] in table 'Produto'
ALTER TABLE [dbo].[Produto]
ADD CONSTRAINT [PK_Produto]
    PRIMARY KEY CLUSTERED ([idProduto] ASC);
GO

-- Creating primary key on [idVenda] in table 'Venda'
ALTER TABLE [dbo].[Venda]
ADD CONSTRAINT [PK_Venda]
    PRIMARY KEY CLUSTERED ([idVenda] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Cliente_idPessoa] in table 'Venda'
ALTER TABLE [dbo].[Venda]
ADD CONSTRAINT [FK_ClienteVenda]
    FOREIGN KEY ([Cliente_idPessoa])
    REFERENCES [dbo].[Pessoa_Cliente]
        ([idPessoa])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ClienteVenda'
CREATE INDEX [IX_FK_ClienteVenda]
ON [dbo].[Venda]
    ([Cliente_idPessoa]);
GO

-- Creating foreign key on [Vendedor_idPessoa] in table 'Venda'
ALTER TABLE [dbo].[Venda]
ADD CONSTRAINT [FK_VendedorVenda]
    FOREIGN KEY ([Vendedor_idPessoa])
    REFERENCES [dbo].[Pessoa_Vendedor]
        ([idPessoa])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_VendedorVenda'
CREATE INDEX [IX_FK_VendedorVenda]
ON [dbo].[Venda]
    ([Vendedor_idPessoa]);
GO

-- Creating foreign key on [Venda_idVenda] in table 'ItemVenda'
ALTER TABLE [dbo].[ItemVenda]
ADD CONSTRAINT [FK_VendaItemVenda]
    FOREIGN KEY ([Venda_idVenda])
    REFERENCES [dbo].[Venda]
        ([idVenda])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_VendaItemVenda'
CREATE INDEX [IX_FK_VendaItemVenda]
ON [dbo].[ItemVenda]
    ([Venda_idVenda]);
GO

-- Creating foreign key on [Produto_idProduto] in table 'ItemVenda'
ALTER TABLE [dbo].[ItemVenda]
ADD CONSTRAINT [FK_ProdutoItemVenda]
    FOREIGN KEY ([Produto_idProduto])
    REFERENCES [dbo].[Produto]
        ([idProduto])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ProdutoItemVenda'
CREATE INDEX [IX_FK_ProdutoItemVenda]
ON [dbo].[ItemVenda]
    ([Produto_idProduto]);
GO

-- Creating foreign key on [Produto_idProduto] in table 'ItemCompra'
ALTER TABLE [dbo].[ItemCompra]
ADD CONSTRAINT [FK_ItemCompra_Produto]
    FOREIGN KEY ([Produto_idProduto])
    REFERENCES [dbo].[Produto]
        ([idProduto])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ItemCompra_Produto'
CREATE INDEX [IX_FK_ItemCompra_Produto]
ON [dbo].[ItemCompra]
    ([Produto_idProduto]);
GO

-- Creating foreign key on [Compra_idCompra] in table 'ItemCompra'
ALTER TABLE [dbo].[ItemCompra]
ADD CONSTRAINT [FK_ItemCompra_Compra]
    FOREIGN KEY ([Compra_idCompra])
    REFERENCES [dbo].[Compra]
        ([idCompra])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ItemCompra_Compra'
CREATE INDEX [IX_FK_ItemCompra_Compra]
ON [dbo].[ItemCompra]
    ([Compra_idCompra]);
GO

-- Creating foreign key on [Fornecedor_idFornecedor] in table 'Compra'
ALTER TABLE [dbo].[Compra]
ADD CONSTRAINT [FK_CompraFornecedor]
    FOREIGN KEY ([Fornecedor_idFornecedor])
    REFERENCES [dbo].[Fornecedor]
        ([idFornecedor])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CompraFornecedor'
CREATE INDEX [IX_FK_CompraFornecedor]
ON [dbo].[Compra]
    ([Fornecedor_idFornecedor]);
GO

-- Creating foreign key on [idPessoa] in table 'Pessoa_Cliente'
ALTER TABLE [dbo].[Pessoa_Cliente]
ADD CONSTRAINT [FK_Cliente_inherits_Pessoa]
    FOREIGN KEY ([idPessoa])
    REFERENCES [dbo].[Pessoa]
        ([idPessoa])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating foreign key on [idPessoa] in table 'Pessoa_Vendedor'
ALTER TABLE [dbo].[Pessoa_Vendedor]
ADD CONSTRAINT [FK_Vendedor_inherits_Pessoa]
    FOREIGN KEY ([idPessoa])
    REFERENCES [dbo].[Pessoa]
        ([idPessoa])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------