
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 03/23/2021 16:46:31
-- Generated from EDMX file: C:\Users\Carlos\source\repos\ControlHrsConsultoria\Models\DB.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [ControlHrsConsultoria];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_Cliente_Usuario]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Cliente] DROP CONSTRAINT [FK_Cliente_Usuario];
GO
IF OBJECT_ID(N'[dbo].[FK_Consultor_Usuario]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Consultor] DROP CONSTRAINT [FK_Consultor_Usuario];
GO
IF OBJECT_ID(N'[dbo].[FK_Operacion_Modulo]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Operacion] DROP CONSTRAINT [FK_Operacion_Modulo];
GO
IF OBJECT_ID(N'[dbo].[FK_Perfil_Idioma]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Perfil] DROP CONSTRAINT [FK_Perfil_Idioma];
GO
IF OBJECT_ID(N'[dbo].[FK_Proyecto_Consultor_Cliente_Cliente]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Proyecto_Consultor_Cliente] DROP CONSTRAINT [FK_Proyecto_Consultor_Cliente_Cliente];
GO
IF OBJECT_ID(N'[dbo].[FK_Proyecto_Consultor_Cliente_Consultor]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Proyecto_Consultor_Cliente] DROP CONSTRAINT [FK_Proyecto_Consultor_Cliente_Consultor];
GO
IF OBJECT_ID(N'[dbo].[FK_Proyecto_Consultor_Cliente_Perfil]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Proyecto_Consultor_Cliente] DROP CONSTRAINT [FK_Proyecto_Consultor_Cliente_Perfil];
GO
IF OBJECT_ID(N'[dbo].[FK_Proyecto_Consultor_Cliente_Proyecto]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Proyecto_Consultor_Cliente] DROP CONSTRAINT [FK_Proyecto_Consultor_Cliente_Proyecto];
GO
IF OBJECT_ID(N'[dbo].[FK_Usuario_Rol]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Usuario] DROP CONSTRAINT [FK_Usuario_Rol];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Cliente]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Cliente];
GO
IF OBJECT_ID(N'[dbo].[Consultor]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Consultor];
GO
IF OBJECT_ID(N'[dbo].[Idioma]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Idioma];
GO
IF OBJECT_ID(N'[dbo].[Modulo]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Modulo];
GO
IF OBJECT_ID(N'[dbo].[Operacion]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Operacion];
GO
IF OBJECT_ID(N'[dbo].[Perfil]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Perfil];
GO
IF OBJECT_ID(N'[dbo].[Proyecto]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Proyecto];
GO
IF OBJECT_ID(N'[dbo].[Proyecto_Consultor_Cliente]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Proyecto_Consultor_Cliente];
GO
IF OBJECT_ID(N'[dbo].[Rol]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Rol];
GO
IF OBJECT_ID(N'[dbo].[sysdiagrams]', 'U') IS NOT NULL
    DROP TABLE [dbo].[sysdiagrams];
GO
IF OBJECT_ID(N'[dbo].[Usuario]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Usuario];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Cliente'
CREATE TABLE [dbo].[Cliente] (
    [idCliente] int IDENTITY(1,1) NOT NULL,
    [codigoCliente] varchar(50)  NULL,
    [montoPrecio] decimal(7,2)  NULL,
    [nombre] varchar(50)  NULL,
    [direccion] varchar(50)  NULL,
    [idUsuario] int  NULL
);
GO

-- Creating table 'Consultor'
CREATE TABLE [dbo].[Consultor] (
    [idConsultor] int IDENTITY(1,1) NOT NULL,
    [codigoConsultor] varchar(50)  NULL,
    [nivelEstudios] varchar(50)  NULL,
    [seguroSocial] varchar(50)  NULL,
    [RFC] varchar(50)  NULL,
    [idUsuario] int  NULL
);
GO

-- Creating table 'Idioma'
CREATE TABLE [dbo].[Idioma] (
    [idIdioma] int IDENTITY(1,1) NOT NULL,
    [descripcion] varchar(50)  NULL
);
GO

-- Creating table 'Modulo'
CREATE TABLE [dbo].[Modulo] (
    [idModulo] int IDENTITY(1,1) NOT NULL,
    [nombre] varchar(50)  NULL
);
GO

-- Creating table 'Operacion'
CREATE TABLE [dbo].[Operacion] (
    [idOperacion] int IDENTITY(1,1) NOT NULL,
    [nombre] varchar(50)  NULL,
    [idModulo] int  NULL
);
GO

-- Creating table 'Perfil'
CREATE TABLE [dbo].[Perfil] (
    [idPerfil] int IDENTITY(1,1) NOT NULL,
    [tarifa] decimal(7,2)  NULL,
    [descripcion] varchar(50)  NULL,
    [nivelPerfil] varchar(50)  NULL,
    [idIdioma] int  NULL
);
GO

-- Creating table 'Proyecto'
CREATE TABLE [dbo].[Proyecto] (
    [idProyecto] int IDENTITY(1,1) NOT NULL,
    [nombre] varchar(50)  NULL,
    [descripcion] varchar(max)  NULL,
    [fechaInicio] datetime  NULL,
    [fechaFinal] datetime  NULL,
    [montoPrecio] decimal(7,2)  NULL,
    [costo] decimal(7,2)  NULL,
    [status] bit  NULL
);
GO

-- Creating table 'Proyecto_Consultor_Cliente'
CREATE TABLE [dbo].[Proyecto_Consultor_Cliente] (
    [idDetalle] int IDENTITY(1,1) NOT NULL,
    [idProyecto] int  NULL,
    [idConsultor] int  NULL,
    [idPerfil] int  NULL,
    [idCliente] int  NULL,
    [montoPrecio] decimal(7,2)  NULL,
    [costo] decimal(7,2)  NULL,
    [descripcion] varchar(max)  NULL,
    [fechaInicio] datetime  NULL,
    [fechaFinal] datetime  NULL,
    [cantidadHrs] decimal(2,2)  NULL
);
GO

-- Creating table 'Rol'
CREATE TABLE [dbo].[Rol] (
    [idRol] int IDENTITY(1,1) NOT NULL,
    [nombre] varchar(50)  NULL
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

-- Creating table 'Usuario'
CREATE TABLE [dbo].[Usuario] (
    [idUsuario] int IDENTITY(1,1) NOT NULL,
    [nombre] varchar(50)  NULL,
    [apellidos] varchar(50)  NULL,
    [correo] varchar(50)  NULL,
    [contraseña] varchar(50)  NULL,
    [fechaRegistro] datetime  NULL,
    [status] bit  NULL,
    [idRol] int  NULL,
    [idCliente] int  NULL,
    [token_recovery] varchar(200)  NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [idCliente] in table 'Cliente'
ALTER TABLE [dbo].[Cliente]
ADD CONSTRAINT [PK_Cliente]
    PRIMARY KEY CLUSTERED ([idCliente] ASC);
GO

-- Creating primary key on [idConsultor] in table 'Consultor'
ALTER TABLE [dbo].[Consultor]
ADD CONSTRAINT [PK_Consultor]
    PRIMARY KEY CLUSTERED ([idConsultor] ASC);
GO

-- Creating primary key on [idIdioma] in table 'Idioma'
ALTER TABLE [dbo].[Idioma]
ADD CONSTRAINT [PK_Idioma]
    PRIMARY KEY CLUSTERED ([idIdioma] ASC);
GO

-- Creating primary key on [idModulo] in table 'Modulo'
ALTER TABLE [dbo].[Modulo]
ADD CONSTRAINT [PK_Modulo]
    PRIMARY KEY CLUSTERED ([idModulo] ASC);
GO

-- Creating primary key on [idOperacion] in table 'Operacion'
ALTER TABLE [dbo].[Operacion]
ADD CONSTRAINT [PK_Operacion]
    PRIMARY KEY CLUSTERED ([idOperacion] ASC);
GO

-- Creating primary key on [idPerfil] in table 'Perfil'
ALTER TABLE [dbo].[Perfil]
ADD CONSTRAINT [PK_Perfil]
    PRIMARY KEY CLUSTERED ([idPerfil] ASC);
GO

-- Creating primary key on [idProyecto] in table 'Proyecto'
ALTER TABLE [dbo].[Proyecto]
ADD CONSTRAINT [PK_Proyecto]
    PRIMARY KEY CLUSTERED ([idProyecto] ASC);
GO

-- Creating primary key on [idDetalle] in table 'Proyecto_Consultor_Cliente'
ALTER TABLE [dbo].[Proyecto_Consultor_Cliente]
ADD CONSTRAINT [PK_Proyecto_Consultor_Cliente]
    PRIMARY KEY CLUSTERED ([idDetalle] ASC);
GO

-- Creating primary key on [idRol] in table 'Rol'
ALTER TABLE [dbo].[Rol]
ADD CONSTRAINT [PK_Rol]
    PRIMARY KEY CLUSTERED ([idRol] ASC);
GO

-- Creating primary key on [diagram_id] in table 'sysdiagrams'
ALTER TABLE [dbo].[sysdiagrams]
ADD CONSTRAINT [PK_sysdiagrams]
    PRIMARY KEY CLUSTERED ([diagram_id] ASC);
GO

-- Creating primary key on [idUsuario] in table 'Usuario'
ALTER TABLE [dbo].[Usuario]
ADD CONSTRAINT [PK_Usuario]
    PRIMARY KEY CLUSTERED ([idUsuario] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [idUsuario] in table 'Cliente'
ALTER TABLE [dbo].[Cliente]
ADD CONSTRAINT [FK_Cliente_Usuario]
    FOREIGN KEY ([idUsuario])
    REFERENCES [dbo].[Usuario]
        ([idUsuario])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Cliente_Usuario'
CREATE INDEX [IX_FK_Cliente_Usuario]
ON [dbo].[Cliente]
    ([idUsuario]);
GO

-- Creating foreign key on [idCliente] in table 'Proyecto_Consultor_Cliente'
ALTER TABLE [dbo].[Proyecto_Consultor_Cliente]
ADD CONSTRAINT [FK_Proyecto_Consultor_Cliente_Cliente]
    FOREIGN KEY ([idCliente])
    REFERENCES [dbo].[Cliente]
        ([idCliente])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Proyecto_Consultor_Cliente_Cliente'
CREATE INDEX [IX_FK_Proyecto_Consultor_Cliente_Cliente]
ON [dbo].[Proyecto_Consultor_Cliente]
    ([idCliente]);
GO

-- Creating foreign key on [idUsuario] in table 'Consultor'
ALTER TABLE [dbo].[Consultor]
ADD CONSTRAINT [FK_Consultor_Usuario]
    FOREIGN KEY ([idUsuario])
    REFERENCES [dbo].[Usuario]
        ([idUsuario])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Consultor_Usuario'
CREATE INDEX [IX_FK_Consultor_Usuario]
ON [dbo].[Consultor]
    ([idUsuario]);
GO

-- Creating foreign key on [idConsultor] in table 'Proyecto_Consultor_Cliente'
ALTER TABLE [dbo].[Proyecto_Consultor_Cliente]
ADD CONSTRAINT [FK_Proyecto_Consultor_Cliente_Consultor]
    FOREIGN KEY ([idConsultor])
    REFERENCES [dbo].[Consultor]
        ([idConsultor])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Proyecto_Consultor_Cliente_Consultor'
CREATE INDEX [IX_FK_Proyecto_Consultor_Cliente_Consultor]
ON [dbo].[Proyecto_Consultor_Cliente]
    ([idConsultor]);
GO

-- Creating foreign key on [idIdioma] in table 'Perfil'
ALTER TABLE [dbo].[Perfil]
ADD CONSTRAINT [FK_Perfil_Idioma]
    FOREIGN KEY ([idIdioma])
    REFERENCES [dbo].[Idioma]
        ([idIdioma])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Perfil_Idioma'
CREATE INDEX [IX_FK_Perfil_Idioma]
ON [dbo].[Perfil]
    ([idIdioma]);
GO

-- Creating foreign key on [idModulo] in table 'Operacion'
ALTER TABLE [dbo].[Operacion]
ADD CONSTRAINT [FK_Operacion_Modulo]
    FOREIGN KEY ([idModulo])
    REFERENCES [dbo].[Modulo]
        ([idModulo])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Operacion_Modulo'
CREATE INDEX [IX_FK_Operacion_Modulo]
ON [dbo].[Operacion]
    ([idModulo]);
GO

-- Creating foreign key on [idPerfil] in table 'Proyecto_Consultor_Cliente'
ALTER TABLE [dbo].[Proyecto_Consultor_Cliente]
ADD CONSTRAINT [FK_Proyecto_Consultor_Cliente_Perfil]
    FOREIGN KEY ([idPerfil])
    REFERENCES [dbo].[Perfil]
        ([idPerfil])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Proyecto_Consultor_Cliente_Perfil'
CREATE INDEX [IX_FK_Proyecto_Consultor_Cliente_Perfil]
ON [dbo].[Proyecto_Consultor_Cliente]
    ([idPerfil]);
GO

-- Creating foreign key on [idProyecto] in table 'Proyecto_Consultor_Cliente'
ALTER TABLE [dbo].[Proyecto_Consultor_Cliente]
ADD CONSTRAINT [FK_Proyecto_Consultor_Cliente_Proyecto]
    FOREIGN KEY ([idProyecto])
    REFERENCES [dbo].[Proyecto]
        ([idProyecto])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Proyecto_Consultor_Cliente_Proyecto'
CREATE INDEX [IX_FK_Proyecto_Consultor_Cliente_Proyecto]
ON [dbo].[Proyecto_Consultor_Cliente]
    ([idProyecto]);
GO

-- Creating foreign key on [idRol] in table 'Usuario'
ALTER TABLE [dbo].[Usuario]
ADD CONSTRAINT [FK_Usuario_Rol]
    FOREIGN KEY ([idRol])
    REFERENCES [dbo].[Rol]
        ([idRol])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Usuario_Rol'
CREATE INDEX [IX_FK_Usuario_Rol]
ON [dbo].[Usuario]
    ([idRol]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------