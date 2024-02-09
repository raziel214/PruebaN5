USE [n5mpleados]
GO

/****** Object:  Table [dbo].[Empleados]    Script Date: 8/02/2024 8:41:14 p. m. ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Empleados](
	[Id] [uniqueidentifier] NOT NULL,
	[Nombre] [varchar](255) NOT NULL,
	[Apellido] [varchar](255) NOT NULL,
	[TipoDocumento] [varchar](255) NOT NULL,
	[NumeroDocumento] [varchar](255) NOT NULL,
	[Correo] [varchar](255) NOT NULL,
	[Cargo] [varchar](255) NOT NULL,
	[FechaNacimiento] [date] NOT NULL,
	[Activo] [bit] NOT NULL,
	[FechaCreacion] [datetime] NOT NULL,
	[FechaModificacion] [datetime] NULL,
	[IdTipoPermiso] [uniqueidentifier] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Empleados] ADD  DEFAULT (newsequentialid()) FOR [Id]
GO

ALTER TABLE [dbo].[Empleados]  WITH CHECK ADD FOREIGN KEY([IdTipoPermiso])
REFERENCES [dbo].[TiposPermisos] ([Id])
GO


