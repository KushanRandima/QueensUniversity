USE [University]
GO
/****** Object:  StoredProcedure [dbo].[RegistrationDelete]    Script Date: 4/14/2014 10:59:12 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[RegistrationDelete] (
	@StudentID int
)

AS

SET NOCOUNT ON

DELETE FROM
	[Registration]
WHERE
	[StudentID] = @StudentID

GO
/****** Object:  StoredProcedure [dbo].[RegistrationInsert]    Script Date: 4/14/2014 10:59:12 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[RegistrationInsert] (
	@Name varchar(500),
	@DateOfBirth datetime,
	@GradePointAvg decimal(18, 0),
	@Active bit
)

AS

SET NOCOUNT ON

INSERT INTO [Registration] (
	[Name],
	[DateOfBirth],
	[GradePointAvg],
	[Active]
) VALUES (
	@Name,
	@DateOfBirth,
	@GradePointAvg,
	@Active
)

SELECT SCOPE_IDENTITY()

GO
/****** Object:  StoredProcedure [dbo].[RegistrationSelect]    Script Date: 4/14/2014 10:59:12 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[RegistrationSelect] (
	@StudentID int
)

AS

SET NOCOUNT ON

SELECT
	[StudentID],
	[Name],
	[DateOfBirth],
	[GradePointAvg],
	[Active]
FROM
	[Registration]
WHERE
	[StudentID] = @StudentID

GO
/****** Object:  StoredProcedure [dbo].[RegistrationSelectAll]    Script Date: 4/14/2014 10:59:12 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[RegistrationSelectAll]

AS

SET NOCOUNT ON

SELECT
	[StudentID],
	[Name],
	[DateOfBirth],
	[GradePointAvg],
	[Active]
FROM
	[Registration]

GO
/****** Object:  StoredProcedure [dbo].[RegistrationUpdate]    Script Date: 4/14/2014 10:59:12 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[RegistrationUpdate] (
	@StudentID int,
	@Name varchar(500),
	@DateOfBirth datetime,
	@GradePointAvg decimal(18, 0),
	@Active bit
)

AS

SET NOCOUNT ON

UPDATE
	[Registration]
SET
	[Name] = @Name,
	[DateOfBirth] = @DateOfBirth,
	[GradePointAvg] = @GradePointAvg,
	[Active] = @Active
WHERE
	 [StudentID] = @StudentID

GO
/****** Object:  Table [dbo].[Registration]    Script Date: 4/14/2014 10:59:12 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Registration](
	[StudentID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](500) NULL,
	[DateOfBirth] [datetime] NULL,
	[GradePointAvg] [decimal](18, 2) NULL,
	[Active] [bit] NULL,
 CONSTRAINT [PK_Registration_1] PRIMARY KEY CLUSTERED 
(
	[StudentID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
