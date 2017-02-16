USE [master]
GO
CREATE DATABASE [NHibernate mini project]
GO
USE [NHibernate mini project]
GO

/****** Object:  Table [dbo].[Balloon]    Script Date: 16/02/2017 11:48:53 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Balloon](
	[Id] [uniqueidentifier] NOT NULL,
	[vehicleName] [nchar](100) NOT NULL,
	[weight] [decimal](18, 0) NOT NULL,
	[numSandbags] [int] NULL,
	[sandbagWeight] [decimal](18, 0) NULL,
	[altitude] [decimal](18, 0) NOT NULL,
	[currentFuel] [decimal](18, 0) NOT NULL,
	[maximumFuel] [decimal](18, 0) NOT NULL,
	[currentPassengers] [int] NOT NULL,
	[maximumPassengers] [int] NOT NULL,
 CONSTRAINT [PK_Balloon_1] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

/****** Object:  Table [dbo].[Boat]    Script Date: 16/02/2017 11:49:22 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Boat](
	[Id] [uniqueidentifier] NOT NULL,
	[vehicleName] [nchar](100) NOT NULL,
	[boatEnvironment] [nchar](100) NOT NULL,
	[weight] [decimal](18, 0) NOT NULL,
	[hasCargo] [bit] NOT NULL,
	[cargoWeight] [decimal](18, 0) NULL,
	[currentFuel] [decimal](18, 0) NOT NULL,
	[maximumFuel] [decimal](18, 0) NOT NULL,
	[currentPassengers] [int] NOT NULL,
	[maximumPassengers] [int] NOT NULL,
 CONSTRAINT [PK_Boat] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

/****** Object:  Table [dbo].[Car]    Script Date: 16/02/2017 11:50:30 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Car](
	[Id] [uniqueidentifier] NOT NULL,
	[vehicleName] [nvarchar](255) NOT NULL,
	[numberPlate] [nvarchar](255) NOT NULL,
	[carType] [nvarchar](255) NOT NULL,
	[milage] [decimal](19, 5) NOT NULL,
	[weight] [decimal](19, 5) NOT NULL,
	[currentFuel] [decimal](19, 5) NOT NULL,
	[maximumFuel] [decimal](19, 5) NOT NULL,
	[currentPassengers] [int] NOT NULL,
	[maximumPassengers] [int] NOT NULL,
 CONSTRAINT [PK__Car__3214EC07AC059FE0] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

/****** Object:  Table [dbo].[Lorry]    Script Date: 16/02/2017 11:50:56 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Lorry](
	[Id] [uniqueidentifier] NOT NULL,
	[vehicleName] [nvarchar](255) NOT NULL,
	[numberPlate] [nvarchar](255) NOT NULL,
	[milage] [decimal](19, 5) NOT NULL,
	[weight] [decimal](19, 5) NOT NULL,
	[hasLoad] [bit] NOT NULL,
	[loadWeight] [decimal](19, 5) NULL,
	[currentFuel] [decimal](19, 5) NOT NULL,
	[maximumFuel] [decimal](19, 5) NOT NULL,
	[currentPassengers] [int] NOT NULL,
	[maximumPassengers] [int] NOT NULL,
 CONSTRAINT [PK__Lorry__3214EC07724EFAD5] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

/****** Object:  Table [dbo].[Plane]    Script Date: 16/02/2017 11:51:08 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Plane](
	[Id] [uniqueidentifier] NOT NULL,
	[vehicleName] [nchar](100) NOT NULL,
	[weight] [decimal](18, 0) NOT NULL,
	[wingSpan] [decimal](18, 0) NOT NULL,
	[altitude] [decimal](18, 0) NOT NULL,
	[currentFuel] [decimal](18, 0) NOT NULL,
	[maximumFuel] [decimal](18, 0) NOT NULL,
	[currentPassengers] [int] NOT NULL,
	[maximumPassengers] [int] NOT NULL,
 CONSTRAINT [PK_Plane] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

/****** Object:  Table [dbo].[Submarine]    Script Date: 16/02/2017 11:51:21 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Submarine](
	[Id] [uniqueidentifier] NOT NULL,
	[vehicleName] [nchar](100) NOT NULL,
	[weight] [decimal](18, 0) NOT NULL,
	[hasCargo] [bit] NOT NULL,
	[cargoWeight] [decimal](18, 0) NULL,
	[currentFuel] [decimal](18, 0) NOT NULL,
	[maximumFuel] [decimal](18, 0) NOT NULL,
	[currentPassengers] [int] NOT NULL,
	[maximumPassengers] [int] NOT NULL,
	[submerged] [bit] NOT NULL,
	[currentOxygenVolume] [decimal](18, 0) NOT NULL,
	[maximumOxygenVolume] [decimal](18, 0) NOT NULL,
 CONSTRAINT [PK_Submarine] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO





