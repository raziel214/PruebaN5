USE [n5mpleados]
GO

/****** Object:  Table [dbo].[Permisos]    Script Date: 8/02/2024 8:40:43 p. m. ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Permisos](
	[Id] [uniqueidentifier] NOT NULL,
	[Nombre] [varchar](255) NOT NULL,
	[Descripcion] [nvarchar](max) NULL,
	[IdTipoPermiso] [uniqueidentifier] NOT NULL,
	[FechaInicio] [datetime] NOT NULL,
	[FechaFin] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

ALTER TABLE [dbo].[Permisos] ADD  DEFAULT (newsequentialid()) FOR [Id]
GO

ALTER TABLE [dbo].[Permisos]  WITH CHECK ADD  CONSTRAINT [FK_Permisos_TiposPermisos] FOREIGN KEY([IdTipoPermiso])
REFERENCES [dbo].[TiposPermisos] ([Id])
GO

ALTER TABLE [dbo].[Permisos] CHECK CONSTRAINT [FK_Permisos_TiposPermisos]
GO


