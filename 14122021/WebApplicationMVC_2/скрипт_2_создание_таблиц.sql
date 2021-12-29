USE [demobd]
GO

/****** Object:  Table [dbo].[ActivityTypes]    Script Date: 09.12.2021 19:29:51 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[ActivityTypes](
	[id] [int] NOT NULL,
	[name] [varchar](256) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

USE [demobd]
GO

/****** Object:  Table [dbo].[Courses]    Script Date: 09.12.2021 19:30:02 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Courses](
	[id] [uniqueidentifier] NOT NULL,
	[name] [varchar](256) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

USE [demobd]
GO

/****** Object:  Table [dbo].[EducationalForms]    Script Date: 09.12.2021 19:30:22 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[EducationalForms](
	[id] [int] NOT NULL,
	[name] [varchar](256) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

/****** Object:  Table [dbo].[WorkStatuses]    Script Date: 10.12.2021 0:21:24 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[WorkStatuses](
	[id] [int] NOT NULL,
	[name] [varchar](256) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

USE [demobd]
GO

/****** Object:  Table [dbo].[Employees]    Script Date: 09.12.2021 19:30:34 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Employees](
	[id] [uniqueidentifier] NOT NULL,
	[lastName] [varchar](256) NOT NULL,
	[firstName] [varchar](256) NOT NULL,
	[middleName] [varchar](256) NOT NULL,
	[birthDate] [date] NOT NULL,
	[phoneNumber] [varchar](256) NULL,
	[email] [varchar](256) NULL,
	[academicDegree] [varchar](256) NULL,
	[position] [varchar](256) NULL,
	[salary] [numeric](10, 2) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

USE [demobd]
GO



USE [demobd]
GO

/****** Object:  Table [dbo].[Groups]    Script Date: 09.12.2021 19:31:04 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Groups](
	[id] [uniqueidentifier] NOT NULL,
	[name] [varchar](256) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

USE [demobd]
GO

/****** Object:  Table [dbo].[MarkTypes]    Script Date: 09.12.2021 19:31:32 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[MarkTypes](
	[id] [int] NOT NULL,
	[name] [varchar](256) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO


/****** Object:  Table [dbo].[Reasons]    Script Date: 09.12.2021 19:32:14 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Reasons](
	[id] [int] NOT NULL,
	[name] [varchar](256) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

USE [demobd]
GO

/****** Object:  Table [dbo].[ScholarshipTypes]    Script Date: 09.12.2021 19:32:27 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[ScholarshipTypes](
	[id] [int] NOT NULL,
	[name] [varchar](256) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

USE [demobd]
GO
/****** Object:  Table [dbo].[TrainingTypes]    Script Date: 09.12.2021 19:32:52 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[TrainingTypes](
	[id] [int] NOT NULL,
	[name] [varchar](256) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

USE [demobd]
GO

/****** Object:  Table [dbo].[Values]    Script Date: 10.12.2021 7:47:26 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Values](
	[id] [int] NOT NULL,
	[name] [varchar](256) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO


USE [demobd]
GO


/****** Object:  Table [dbo].[Students]    Script Date: 09.12.2021 19:32:41 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Students](
	[id] [uniqueidentifier] NOT NULL,
	[LastName] [varchar](256) NOT NULL,
	[FirstName] [varchar](256) NOT NULL,
	[MiddleName] [varchar](256) NOT NULL,
	[BirthDate] [date] NOT NULL,
	[PhoneNumber] [varchar](256) NOT NULL,
	[CreditCardNumber] [varchar](256) NOT NULL,
	[GroupId] [uniqueidentifier] NOT NULL,
	[EducationalFormId] [int] NULL,
	[TrainingTypeId] [int] NOT NULL,
	[ScholarshipAmount] [numeric](18, 2) NULL,
	[ScholarshipTypeId] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Students]  WITH CHECK ADD  CONSTRAINT [FK_group_students] FOREIGN KEY([GroupId])
REFERENCES [dbo].[Groups] ([id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO

ALTER TABLE [dbo].[Students] CHECK CONSTRAINT [FK_group_students]
GO

USE [demobd]
GO

/****** Object:  Table [dbo].[Visits]    Script Date: 09.12.2021 19:33:02 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Visits](
	[id] [uniqueidentifier] NOT NULL,
	[StudentId] [uniqueidentifier] NOT NULL,
	[Date] [date] NOT NULL,
	[ReasonId] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Visits]  WITH CHECK ADD  CONSTRAINT [FK_reason_visits] FOREIGN KEY([ReasonId])
REFERENCES [dbo].[Reasons] ([id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO

ALTER TABLE [dbo].[Visits] CHECK CONSTRAINT [FK_reason_visits]
GO

ALTER TABLE [dbo].[Visits]  WITH CHECK ADD  CONSTRAINT [FK_student_visits] FOREIGN KEY([StudentId])
REFERENCES [dbo].[Students] ([id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO

ALTER TABLE [dbo].[Visits] CHECK CONSTRAINT [FK_student_visits]
GO

CREATE TABLE [dbo].[Activities](
	[id] [uniqueidentifier] NOT NULL,
	[StudentId] [uniqueidentifier] NOT NULL,
	[ActivityTypeId] [int] NOT NULL,
	[Topic] [varchar](256) NOT NULL,
	[Date] [date] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Activities]  WITH CHECK ADD  CONSTRAINT [FK_student_activitytype_activities] FOREIGN KEY([ActivityTypeId])
REFERENCES [dbo].[ActivityTypes] ([id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO

ALTER TABLE [dbo].[Activities] CHECK CONSTRAINT [FK_student_activitytype_activities]
GO

ALTER TABLE [dbo].[Activities]  WITH CHECK ADD  CONSTRAINT [FK_student_educational_activities] FOREIGN KEY([StudentId])
REFERENCES [dbo].[Students] ([id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO

ALTER TABLE [dbo].[Activities] CHECK CONSTRAINT [FK_student_educational_activities]
GO

/****** Object:  Table [dbo].[GraduateWorks]    Script Date: 10.12.2021 7:55:16 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[GraduateWorks](
	[id] [uniqueidentifier] NOT NULL,
	[StudentId] [uniqueidentifier] NOT NULL,
	[EmployeeId] [uniqueidentifier] NOT NULL,
	[Topic] [varchar](256) NOT NULL,
	[ValueID] [int] NULL,
	[WorkStatusId] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[GraduateWorks]  WITH CHECK ADD  CONSTRAINT [FK_employee_graduate_works] FOREIGN KEY([EmployeeId])
REFERENCES [dbo].[Employees] ([id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO

ALTER TABLE [dbo].[GraduateWorks] CHECK CONSTRAINT [FK_employee_graduate_works]
GO

ALTER TABLE [dbo].[GraduateWorks]  WITH CHECK ADD  CONSTRAINT [FK_student_graduate_works] FOREIGN KEY([StudentId])
REFERENCES [dbo].[Students] ([id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO

ALTER TABLE [dbo].[GraduateWorks] CHECK CONSTRAINT [FK_student_graduate_works]
GO

ALTER TABLE [dbo].[GraduateWorks]  WITH CHECK ADD  CONSTRAINT [FK_value_graduate_works] FOREIGN KEY([ValueId])
REFERENCES [dbo].[Values] ([id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO

ALTER TABLE [dbo].[GraduateWorks] CHECK CONSTRAINT [FK_value_graduate_works]
GO



/****** Object:  Table [dbo].[Marks]    Script Date: 09.12.2021 19:31:22 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Marks](
	[id] [uniqueidentifier] NOT NULL,
	[StudentId] [uniqueidentifier] NOT NULL,
	[MarkTypeId] [int] NOT NULL,
	[CourseId] [uniqueidentifier] NOT NULL,
	[Date] [date] NOT NULL,
	[ValueId] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Marks]  WITH CHECK ADD  CONSTRAINT [FK_course_marks] FOREIGN KEY([CourseId])
REFERENCES [dbo].[Courses] ([id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO

ALTER TABLE [dbo].[Marks] CHECK CONSTRAINT [FK_course_marks]
GO

ALTER TABLE [dbo].[Marks]  WITH CHECK ADD  CONSTRAINT [FK_marktype_marks] FOREIGN KEY([MarkTypeId])
REFERENCES [dbo].[MarkTypes] ([id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO

ALTER TABLE [dbo].[Marks] CHECK CONSTRAINT [FK_marktype_marks]
GO

ALTER TABLE [dbo].[Marks]  WITH CHECK ADD  CONSTRAINT [FK_student_marks] FOREIGN KEY([StudentId])
REFERENCES [dbo].[Students] ([id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO

ALTER TABLE [dbo].[Marks] CHECK CONSTRAINT [FK_student_marks]
GO

ALTER TABLE [dbo].[Marks]  WITH CHECK ADD  CONSTRAINT [FK_values_marks] FOREIGN KEY([ValueId])
REFERENCES [dbo].[Values] ([id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO

ALTER TABLE [dbo].[Marks] CHECK CONSTRAINT [FK_values_marks]
GO

USE [demobd]
GO

/****** Object:  Table [dbo].[Roles]    Script Date: 13.12.2021 20:04:27 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Roles](
	[id] [int] NOT NULL,
	[name] [varchar](256) NOT NULL,
	[fullname] [varchar](256) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

USE [demobd]
GO

/****** Object:  Table [dbo].[Users]    Script Date: 13.12.2021 20:04:40 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Users](
	[id] [uniqueidentifier] NOT NULL,
	[Email] [varchar](256) NOT NULL,
	[Password] [varchar](256) NOT NULL,
	[RoleId] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Users]  WITH CHECK ADD  CONSTRAINT [FK_role_users] FOREIGN KEY([RoleId])
REFERENCES [dbo].[Roles] ([id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO

ALTER TABLE [dbo].[Users] CHECK CONSTRAINT [FK_role_users]
GO
