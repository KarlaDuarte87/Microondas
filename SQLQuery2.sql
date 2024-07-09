USE [DB_SistemaMicroondas]
GO

/****** Object:  Table [dbo].[Programas]    Script Date: 09/07/2024 10:53:51 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Programas](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nome] [nvarchar](100) NOT NULL,
	[Comida] [nvarchar](100) NOT NULL,
	[TempoEmSegundos] [int] NOT NULL,
	[Potencia] [int] NOT NULL,
	[CaracterDeAquecimento] [nvarchar](1) NOT NULL,
	[Instrucoes] [nvarchar](max) NOT NULL,
	[Customizado] [bit] NOT NULL,
 CONSTRAINT [PK_Programas] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO


