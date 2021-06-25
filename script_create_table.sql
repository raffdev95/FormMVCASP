USE [twoforms]
GO

/****** Object:  Table [dbo].[ut_forms]    Script Date: 25.06.2021 18:32:46 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


-- tabela z zapisem(przyjalem nazwe bazy twoforms-- testowo)


CREATE TABLE [dbo].[ut_forms](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [varchar](100) NULL,
	[surname] [varchar](300) NULL,
	[mail] [varchar](1000) NULL,
	[text] [varchar](1000) NULL,
	[subject] [varchar](500) NULL,
	[statusmail] [int] NULL,
 CONSTRAINT [PK_ut_forms] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

-- slownik do statusu MAILA

CREATE TABLE [dbo].[ut_status_mail](
	[id] [int] NULL,
	[nazwa] [varchar](100) NULL
) ON [PRIMARY]

insert into ut_status_mail (id,nazwa)values(1,'Wys³ano')
insert into ut_status_mail (id,nazwa)values(0,'B³¹d')

GO

