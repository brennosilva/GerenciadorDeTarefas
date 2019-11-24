CREATE DATABASE [GERENCIADOR_TAREFA]

use GERENCIADOR_TAREFA

CREATE TABLE [dbo].[tarefa](
	[id_tarefa] [int] IDENTITY(1,1) NOT NULL,
	[nome] [varchar](50) NOT NULL,
	[status] [int] NOT NULL,
	[id_usuario] [int] NOT NULL,
 CONSTRAINT [PK_tarefa] PRIMARY KEY CLUSTERED 
(
	[id_tarefa] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[usuario](
	[id_usuario] [int] IDENTITY(1,1) NOT NULL,
	[nome] [varchar](50) NOT NULL,
	[email] [varchar](80) NOT NULL,
	[permissao] [int] NOT NULL,
	[senha] [varchar](50) NOT NULL,
 CONSTRAINT [PK_usuario] PRIMARY KEY CLUSTERED 
(
	[id_usuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[tarefa]  WITH CHECK ADD  CONSTRAINT [FK_tarefa_usuario] FOREIGN KEY([id_usuario])
REFERENCES [dbo].[usuario] ([id_usuario])
GO

ALTER TABLE [dbo].[tarefa] CHECK CONSTRAINT [FK_tarefa_usuario]
GO

USE [GERENCIADOR_TAREFA]
GO

INSERT INTO [dbo].[usuario]
           ([nome]
           ,[email]
           ,[permissao]
           ,[senha])
     VALUES
           ('admin'
           ,'admin@admin.com'
           ,1
           ,'admin')
GO





