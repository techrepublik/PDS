USE [master]
GO
/****** Object:  Database [PDS]    Script Date: 10/19/2017 11:29:57 PM ******/
CREATE DATABASE [PDS]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'PDS', FILENAME = N'F:\pds-bohol\PDS.mdf' , SIZE = 4096KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'PDS_log', FILENAME = N'F:\pds-bohol\PDS_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [PDS] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [PDS].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [PDS] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [PDS] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [PDS] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [PDS] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [PDS] SET ARITHABORT OFF 
GO
ALTER DATABASE [PDS] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [PDS] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [PDS] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [PDS] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [PDS] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [PDS] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [PDS] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [PDS] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [PDS] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [PDS] SET  DISABLE_BROKER 
GO
ALTER DATABASE [PDS] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [PDS] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [PDS] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [PDS] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [PDS] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [PDS] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [PDS] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [PDS] SET RECOVERY FULL 
GO
ALTER DATABASE [PDS] SET  MULTI_USER 
GO
ALTER DATABASE [PDS] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [PDS] SET DB_CHAINING OFF 
GO
ALTER DATABASE [PDS] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [PDS] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [PDS] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'PDS', N'ON'
GO
USE [PDS]
GO
/****** Object:  Schema [Education]    Script Date: 10/19/2017 11:29:58 PM ******/
CREATE SCHEMA [Education]
GO
/****** Object:  Schema [Others]    Script Date: 10/19/2017 11:29:58 PM ******/
CREATE SCHEMA [Others]
GO
/****** Object:  Schema [Personnel]    Script Date: 10/19/2017 11:29:58 PM ******/
CREATE SCHEMA [Personnel]
GO
/****** Object:  Table [dbo].[Details]    Script Date: 10/19/2017 11:29:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Details](
	[DetailNo] [int] IDENTITY(1,1) NOT NULL,
	[PersonnelNo] [int] NULL,
	[CommunityTaxNo] [varchar](50) NULL,
	[IssuedAt] [varchar](max) NULL,
	[IssuedOn] [date] NULL,
	[DateAccomplished] [date] NULL,
	[Signature] [image] NULL,
	[Thnumbmark] [image] NULL,
	[IsActive] [bit] NULL,
 CONSTRAINT [PK_Details] PRIMARY KEY CLUSTERED 
(
	[DetailNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[LeaveApplication]    Script Date: 10/19/2017 11:29:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[LeaveApplication](
	[LeaveApplicationNo] [int] IDENTITY(1,1) NOT NULL,
	[LeaveType] [varchar](50) NULL,
	[LeaveName] [varchar](50) NULL,
	[LeaveSpent] [varchar](50) NULL,
	[LeaveSpentDetail] [varchar](50) NULL,
	[LeaveDays] [int] NULL,
	[LeaveStart] [date] NULL,
	[LeaveEnd] [date] NULL,
	[Commutation] [varchar](50) NULL,
	[Recommendation] [varchar](50) NULL,
	[LeaveOfficeNo] [int] NULL,
 CONSTRAINT [PK_LeaveApplication] PRIMARY KEY CLUSTERED 
(
	[LeaveApplicationNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[LeaveOffice]    Script Date: 10/19/2017 11:29:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[LeaveOffice](
	[LeaveOfficeNo] [int] IDENTITY(1,1) NOT NULL,
	[DateFiled] [date] NULL,
	[Position] [varchar](50) NULL,
	[BasicSalary] [float] NULL,
	[PersonnelNo] [int] NULL,
	[OfficeAgency] [varchar](50) NULL,
 CONSTRAINT [PK_LeaveOffice] PRIMARY KEY CLUSTERED 
(
	[LeaveOfficeNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Questions]    Script Date: 10/19/2017 11:29:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Questions](
	[QuestionNo] [int] IDENTITY(1,1) NOT NULL,
	[PersonnelNo] [int] NULL,
	[Q36A_Yes] [bit] NULL,
	[Q36B_Yes] [bit] NULL,
	[Q36A_No] [bit] NULL,
	[Q36B_No] [bit] NULL,
	[Q36A_YesDetails] [varchar](100) NULL,
	[Q36B_YesDetails] [varchar](100) NULL,
	[Q37A_Yes] [bit] NULL,
	[Q37A_No] [bit] NULL,
	[Q37A_YesDetails] [varchar](100) NULL,
	[Q37B_Yes] [bit] NULL,
	[Q37B_No] [bit] NULL,
	[Q37B_YesDetails] [varchar](100) NULL,
	[Q38_Yes] [bit] NULL,
	[Q38_No] [bit] NULL,
	[Q38_YesDetails] [varchar](100) NULL,
	[Q39_Yes] [bit] NULL,
	[Q39_No] [bit] NULL,
	[Q39_YesDetails] [varchar](100) NULL,
	[Q40_Yes] [bit] NULL,
	[Q40_No] [bit] NULL,
	[Q40_YesDetails] [varchar](50) NULL,
	[Q41A_Yes] [bit] NULL,
	[Q41A_No] [bit] NULL,
	[Q41A_YesDetails] [varchar](100) NULL,
	[Q41B_Yes] [bit] NULL,
	[Q41B_No] [bit] NULL,
	[Q41B_YesDetails] [varchar](100) NULL,
	[Q41C_Yes] [bit] NULL,
	[Q41C_No] [bit] NULL,
	[Q41C_YesDetails] [varchar](100) NULL,
	[IsActive] [bit] NULL,
 CONSTRAINT [PK_Questions] PRIMARY KEY CLUSTERED 
(
	[QuestionNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[References]    Script Date: 10/19/2017 11:29:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[References](
	[ReferenceNo] [int] IDENTITY(1,1) NOT NULL,
	[PersonnelNo] [int] NOT NULL,
	[ReferenceName] [varchar](200) NULL,
	[ReferenceAddress] [varchar](max) NULL,
	[ReferenceTelNo] [varchar](50) NULL,
	[ReferenceIsAcive] [bit] NULL,
 CONSTRAINT [PK_References] PRIMARY KEY CLUSTERED 
(
	[ReferenceNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Users]    Script Date: 10/19/2017 11:29:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Users](
	[UserNo] [int] IDENTITY(1,1) NOT NULL,
	[UserName] [varchar](50) NULL,
	[Password] [varchar](50) NULL,
	[UserLevel] [nchar](10) NULL,
	[IsActive] [bit] NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[UserNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [Education].[Degrees]    Script Date: 10/19/2017 11:29:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [Education].[Degrees](
	[DegreeNo] [int] IDENTITY(1,1) NOT NULL,
	[DegreeName] [varchar](200) NULL,
	[DegreeShortName] [varchar](50) NULL,
	[IsActive] [bit] NULL,
	[modifieddate] [datetime] NULL,
 CONSTRAINT [PK_Degrees] PRIMARY KEY CLUSTERED 
(
	[DegreeNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [Education].[Educations]    Script Date: 10/19/2017 11:29:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [Education].[Educations](
	[EducationNo] [int] IDENTITY(1,1) NOT NULL,
	[PersonnelNo] [int] NULL,
	[EducationLevelNo] [varchar](50) NULL,
	[SchoolNo] [int] NULL,
	[DegreeNo] [int] NULL,
	[YearGraduated] [varchar](10) NULL,
	[HighestLevelEarned] [varchar](10) NULL,
	[InclusiveDate1] [date] NULL,
	[InclusiveDate2] [date] NULL,
	[ScholarshipHonor] [varchar](50) NULL,
	[modifieddate] [datetime] NULL,
 CONSTRAINT [PK_Educations] PRIMARY KEY CLUSTERED 
(
	[EducationNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [Education].[SchoolNames]    Script Date: 10/19/2017 11:29:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [Education].[SchoolNames](
	[SchoolNo] [int] IDENTITY(1,1) NOT NULL,
	[SchoolName] [varchar](200) NULL,
	[SchoolShortName] [varchar](50) NULL,
	[IsActive] [bit] NULL,
	[modifieddate] [datetime] NULL,
 CONSTRAINT [PK_SchoolNames] PRIMARY KEY CLUSTERED 
(
	[SchoolNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [Others].[Distinctions]    Script Date: 10/19/2017 11:29:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [Others].[Distinctions](
	[DistinctionNo] [int] IDENTITY(1,1) NOT NULL,
	[PersonnelNo] [int] NULL,
	[DistinctionName] [varchar](100) NULL,
	[modifieddate] [datetime] NULL,
 CONSTRAINT [PK_Distinctions] PRIMARY KEY CLUSTERED 
(
	[DistinctionNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [Others].[Eligibilities]    Script Date: 10/19/2017 11:29:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [Others].[Eligibilities](
	[EligibilityNo] [int] IDENTITY(1,1) NOT NULL,
	[PersonnelNo] [int] NULL,
	[EligibilityName] [varchar](200) NULL,
	[EligibilityRating] [varchar](50) NULL,
	[EligibilityExamDate] [date] NULL,
	[EligibilityExamPlace] [varchar](200) NULL,
	[EligibilityLicenseNo] [varchar](50) NULL,
	[EligibilityLicenseDate] [date] NULL,
	[modifieddate] [datetime] NULL,
 CONSTRAINT [PK_Eligibilities] PRIMARY KEY CLUSTERED 
(
	[EligibilityNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [Others].[Experiencies]    Script Date: 10/19/2017 11:29:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [Others].[Experiencies](
	[ExperienceNo] [int] IDENTITY(1,1) NOT NULL,
	[PersonnelNo] [int] NULL,
	[ExperienceDate1] [date] NULL,
	[ExperienceDate2] [date] NULL,
	[ExperiencePosition] [varchar](50) NULL,
	[ExperienceOffice] [varchar](50) NULL,
	[ExperienceSalary] [float] NULL,
	[ExperienceSalaryGrade] [varchar](10) NULL,
	[ExperienceStatus] [varchar](50) NULL,
	[ExperienceIsGovernment] [bit] NULL,
	[IsActive] [bit] NULL,
	[modifieddate] [datetime] NULL,
 CONSTRAINT [PK_Experiencies] PRIMARY KEY CLUSTERED 
(
	[ExperienceNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [Others].[Organizations]    Script Date: 10/19/2017 11:29:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [Others].[Organizations](
	[OrganizationNo] [int] IDENTITY(1,1) NOT NULL,
	[PersonnelNo] [int] NULL,
	[OrganizationName] [varchar](max) NULL,
	[modifieddate] [datetime] NULL,
 CONSTRAINT [PK_Organizations] PRIMARY KEY CLUSTERED 
(
	[OrganizationNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [Others].[Skills]    Script Date: 10/19/2017 11:29:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [Others].[Skills](
	[SkillNo] [int] IDENTITY(1,1) NOT NULL,
	[PersonnelNo] [int] NULL,
	[SkillName] [varchar](50) NULL,
	[modifieddate] [datetime] NULL,
 CONSTRAINT [PK_Skills] PRIMARY KEY CLUSTERED 
(
	[SkillNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [Others].[Trainings]    Script Date: 10/19/2017 11:29:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [Others].[Trainings](
	[TrainingNo] [int] IDENTITY(1,1) NOT NULL,
	[PersonnelNo] [int] NULL,
	[TrainingName] [varchar](200) NULL,
	[TrainingDate1] [date] NULL,
	[TrainingDate2] [date] NULL,
	[TrainingNoHours] [float] NULL,
	[TrainingSponsor] [varchar](200) NULL,
	[IsActive] [bit] NULL,
	[modifieddate] [datetime] NULL,
 CONSTRAINT [PK_Trainings] PRIMARY KEY CLUSTERED 
(
	[TrainingNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [Others].[Voluntaries]    Script Date: 10/19/2017 11:29:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [Others].[Voluntaries](
	[VoluntaryNo] [int] IDENTITY(1,1) NOT NULL,
	[PersonnelNo] [int] NULL,
	[VoluntaryOrganization] [varchar](200) NULL,
	[VoluntaryDate1] [date] NULL,
	[VoluntaryDate2] [date] NULL,
	[VoluntaryNoHours] [float] NULL,
	[VoluntaryPosition] [varchar](50) NULL,
	[IsActive] [bit] NULL,
	[modifieddate] [datetime] NULL,
 CONSTRAINT [PK_Voluntaries] PRIMARY KEY CLUSTERED 
(
	[VoluntaryNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [Personnel].[Address]    Script Date: 10/19/2017 11:29:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [Personnel].[Address](
	[AddressNo] [int] IDENTITY(1,1) NOT NULL,
	[PersonnelNo] [int] NULL,
	[AddressTypeNo] [int] NULL,
	[AddressLine1] [varchar](100) NULL,
	[AddressLine2] [varchar](100) NULL,
	[MunicipalityNo] [int] NULL,
	[IsActive] [bit] NULL,
	[modifieddate] [datetime] NULL,
 CONSTRAINT [PK_Address] PRIMARY KEY CLUSTERED 
(
	[AddressNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [Personnel].[AddressTypes]    Script Date: 10/19/2017 11:29:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [Personnel].[AddressTypes](
	[AddressTypeNo] [int] IDENTITY(1,1) NOT NULL,
	[AddressTypeName] [varchar](50) NULL,
	[modifieddate] [datetime] NULL,
 CONSTRAINT [PK_AddressTypes] PRIMARY KEY CLUSTERED 
(
	[AddressTypeNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [Personnel].[Childrens]    Script Date: 10/19/2017 11:29:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [Personnel].[Childrens](
	[ChildrenNo] [int] IDENTITY(1,1) NOT NULL,
	[SpouseNo] [int] NULL,
	[ChildrenLastName] [varchar](50) NULL,
	[ChildrenFirstName] [varchar](50) NULL,
	[ChildrenMiddleName] [varchar](50) NULL,
	[ChildrenBirthDate] [date] NULL,
	[modifieddate] [datetime] NULL,
 CONSTRAINT [PK_Childrens] PRIMARY KEY CLUSTERED 
(
	[ChildrenNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [Personnel].[Municipalities]    Script Date: 10/19/2017 11:29:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [Personnel].[Municipalities](
	[MunicipalityNo] [int] IDENTITY(1,1) NOT NULL,
	[MunicipalityName] [varchar](50) NULL,
	[MunicipalityPostalCode] [varchar](10) NULL,
	[ProvinceNo] [int] NULL,
	[IsActive] [bit] NULL,
	[datemodified] [datetime] NULL,
 CONSTRAINT [PK_Municipalities] PRIMARY KEY CLUSTERED 
(
	[MunicipalityNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [Personnel].[Parents]    Script Date: 10/19/2017 11:29:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [Personnel].[Parents](
	[ParentNo] [int] IDENTITY(1,1) NOT NULL,
	[PersonnelNo] [int] NULL,
	[ParentFatherSurName] [varchar](50) NULL,
	[ParentFatherFirstName] [varchar](50) NULL,
	[ParentFatherMiddeName] [varchar](50) NULL,
	[ParentMotherSurName] [varchar](50) NULL,
	[ParentMotherFirstName] [varchar](50) NULL,
	[ParentMotherMiddleName] [varchar](50) NULL,
	[modifieddate] [datetime] NULL,
 CONSTRAINT [PK_Parents] PRIMARY KEY CLUSTERED 
(
	[ParentNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [Personnel].[Personnels]    Script Date: 10/19/2017 11:29:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [Personnel].[Personnels](
	[PersonnelNo] [int] IDENTITY(1,1) NOT NULL,
	[CSIdNo] [varchar](50) NULL,
	[PersonnelIdNo] [varchar](50) NULL,
	[SurName] [varchar](50) NULL,
	[FirstName] [varchar](50) NULL,
	[MiddleName] [varchar](50) NULL,
	[SuffixName] [varchar](50) NULL,
	[ResidentialAddress] [varchar](max) NULL,
	[ResidentialZipCode] [int] NULL,
	[ResidentialtelephoneNo] [varchar](50) NULL,
	[PermanentAddress] [varchar](max) NULL,
	[PermanentZipCode] [int] NULL,
	[PermanentTelephoneNo] [varchar](50) NULL,
	[DateOfBirth] [date] NULL,
	[PlaceOfBirth] [varchar](200) NULL,
	[Sex] [varchar](10) NULL,
	[CivilStatus] [varchar](50) NULL,
	[Citizenship] [varchar](50) NULL,
	[Height] [float] NULL,
	[Weight] [float] NULL,
	[BloodType] [varchar](10) NULL,
	[GSISIdNo] [varchar](50) NULL,
	[PagIbigIdNo] [varchar](50) NULL,
	[PhiliHealthIdNo] [varchar](50) NULL,
	[SSSIdNo] [varchar](50) NULL,
	[FatherFirstName] [varchar](50) NULL,
	[FatherMiddleName] [varchar](50) NULL,
	[FatherLastName] [varchar](50) NULL,
	[MotherFirstName] [varchar](50) NULL,
	[MotherMiddleName] [varchar](50) NULL,
	[MotherLastName] [varchar](50) NULL,
	[MotherMaidenName] [varchar](50) NULL,
	[TIN] [varchar](50) NULL,
	[EmailAddress] [varchar](max) NULL,
	[CellphoneNo] [varchar](50) NULL,
	[Photo] [image] NULL,
	[IsActive] [bit] NULL,
	[BarcodeImage] [image] NULL,
	[guid] [uniqueidentifier] NULL,
	[datemodified] [datetime] NULL,
 CONSTRAINT [PK_Personnels] PRIMARY KEY CLUSTERED 
(
	[PersonnelNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [Personnel].[Provinces]    Script Date: 10/19/2017 11:29:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [Personnel].[Provinces](
	[ProvinceNo] [int] IDENTITY(1,1) NOT NULL,
	[ProvinceName] [varchar](100) NULL,
	[RegionNo] [int] NULL,
	[IsActive] [bit] NULL,
	[modifieddate] [datetime] NULL,
 CONSTRAINT [PK_Provinces] PRIMARY KEY CLUSTERED 
(
	[ProvinceNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [Personnel].[Regions]    Script Date: 10/19/2017 11:29:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [Personnel].[Regions](
	[RegionNo] [int] IDENTITY(1,1) NOT NULL,
	[RegionName] [varchar](50) NULL,
	[modifieddate] [datetime] NULL,
 CONSTRAINT [PK_Regions] PRIMARY KEY CLUSTERED 
(
	[RegionNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [Personnel].[Spouses]    Script Date: 10/19/2017 11:29:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [Personnel].[Spouses](
	[SpouseNo] [int] IDENTITY(1,1) NOT NULL,
	[PersonnelNo] [int] NULL,
	[SpouseSurName] [varchar](50) NULL,
	[SpouseFirstName] [varchar](50) NULL,
	[SpouseMiddleName] [varchar](50) NULL,
	[Occupation] [varchar](50) NULL,
	[Employer] [varchar](150) NULL,
	[EmployerAddress] [varchar](50) NULL,
	[TelephoneNo] [varchar](50) NULL,
	[IsActive] [bit] NULL,
	[modifieddate] [datetime] NULL,
 CONSTRAINT [PK_Spouses] PRIMARY KEY CLUSTERED 
(
	[SpouseNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
ALTER TABLE [dbo].[Details]  WITH CHECK ADD  CONSTRAINT [FK_Details_Personnels] FOREIGN KEY([PersonnelNo])
REFERENCES [Personnel].[Personnels] ([PersonnelNo])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Details] CHECK CONSTRAINT [FK_Details_Personnels]
GO
ALTER TABLE [dbo].[LeaveApplication]  WITH CHECK ADD  CONSTRAINT [FK_LeaveApplication_LeaveOffice] FOREIGN KEY([LeaveOfficeNo])
REFERENCES [dbo].[LeaveOffice] ([LeaveOfficeNo])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[LeaveApplication] CHECK CONSTRAINT [FK_LeaveApplication_LeaveOffice]
GO
ALTER TABLE [dbo].[LeaveOffice]  WITH CHECK ADD  CONSTRAINT [FK_LeaveOffice_Personnels] FOREIGN KEY([PersonnelNo])
REFERENCES [Personnel].[Personnels] ([PersonnelNo])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[LeaveOffice] CHECK CONSTRAINT [FK_LeaveOffice_Personnels]
GO
ALTER TABLE [dbo].[Questions]  WITH CHECK ADD  CONSTRAINT [FK_Questions_Personnels] FOREIGN KEY([PersonnelNo])
REFERENCES [Personnel].[Personnels] ([PersonnelNo])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Questions] CHECK CONSTRAINT [FK_Questions_Personnels]
GO
ALTER TABLE [dbo].[References]  WITH CHECK ADD  CONSTRAINT [FK_References_Personnels] FOREIGN KEY([PersonnelNo])
REFERENCES [Personnel].[Personnels] ([PersonnelNo])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[References] CHECK CONSTRAINT [FK_References_Personnels]
GO
ALTER TABLE [Education].[Educations]  WITH CHECK ADD  CONSTRAINT [FK_Educations_Degrees] FOREIGN KEY([DegreeNo])
REFERENCES [Education].[Degrees] ([DegreeNo])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [Education].[Educations] CHECK CONSTRAINT [FK_Educations_Degrees]
GO
ALTER TABLE [Education].[Educations]  WITH CHECK ADD  CONSTRAINT [FK_Educations_Personnels] FOREIGN KEY([PersonnelNo])
REFERENCES [Personnel].[Personnels] ([PersonnelNo])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [Education].[Educations] CHECK CONSTRAINT [FK_Educations_Personnels]
GO
ALTER TABLE [Education].[Educations]  WITH CHECK ADD  CONSTRAINT [FK_Educations_SchoolNames] FOREIGN KEY([SchoolNo])
REFERENCES [Education].[SchoolNames] ([SchoolNo])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [Education].[Educations] CHECK CONSTRAINT [FK_Educations_SchoolNames]
GO
ALTER TABLE [Others].[Distinctions]  WITH CHECK ADD  CONSTRAINT [FK_Distinctions_Personnels] FOREIGN KEY([PersonnelNo])
REFERENCES [Personnel].[Personnels] ([PersonnelNo])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [Others].[Distinctions] CHECK CONSTRAINT [FK_Distinctions_Personnels]
GO
ALTER TABLE [Others].[Eligibilities]  WITH CHECK ADD  CONSTRAINT [FK_Eligibilities_Personnels] FOREIGN KEY([PersonnelNo])
REFERENCES [Personnel].[Personnels] ([PersonnelNo])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [Others].[Eligibilities] CHECK CONSTRAINT [FK_Eligibilities_Personnels]
GO
ALTER TABLE [Others].[Experiencies]  WITH CHECK ADD  CONSTRAINT [FK_Experiencies_Personnels] FOREIGN KEY([PersonnelNo])
REFERENCES [Personnel].[Personnels] ([PersonnelNo])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [Others].[Experiencies] CHECK CONSTRAINT [FK_Experiencies_Personnels]
GO
ALTER TABLE [Others].[Organizations]  WITH CHECK ADD  CONSTRAINT [FK_Organizations_Personnels] FOREIGN KEY([PersonnelNo])
REFERENCES [Personnel].[Personnels] ([PersonnelNo])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [Others].[Organizations] CHECK CONSTRAINT [FK_Organizations_Personnels]
GO
ALTER TABLE [Others].[Skills]  WITH CHECK ADD  CONSTRAINT [FK_Skills_Personnels] FOREIGN KEY([PersonnelNo])
REFERENCES [Personnel].[Personnels] ([PersonnelNo])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [Others].[Skills] CHECK CONSTRAINT [FK_Skills_Personnels]
GO
ALTER TABLE [Others].[Trainings]  WITH CHECK ADD  CONSTRAINT [FK_Trainings_Personnels] FOREIGN KEY([PersonnelNo])
REFERENCES [Personnel].[Personnels] ([PersonnelNo])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [Others].[Trainings] CHECK CONSTRAINT [FK_Trainings_Personnels]
GO
ALTER TABLE [Others].[Voluntaries]  WITH CHECK ADD  CONSTRAINT [FK_Voluntaries_Personnels] FOREIGN KEY([PersonnelNo])
REFERENCES [Personnel].[Personnels] ([PersonnelNo])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [Others].[Voluntaries] CHECK CONSTRAINT [FK_Voluntaries_Personnels]
GO
ALTER TABLE [Personnel].[Address]  WITH CHECK ADD  CONSTRAINT [FK_Address_AddressTypes] FOREIGN KEY([AddressTypeNo])
REFERENCES [Personnel].[AddressTypes] ([AddressTypeNo])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [Personnel].[Address] CHECK CONSTRAINT [FK_Address_AddressTypes]
GO
ALTER TABLE [Personnel].[Address]  WITH CHECK ADD  CONSTRAINT [FK_Address_Municipalities] FOREIGN KEY([MunicipalityNo])
REFERENCES [Personnel].[Municipalities] ([MunicipalityNo])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [Personnel].[Address] CHECK CONSTRAINT [FK_Address_Municipalities]
GO
ALTER TABLE [Personnel].[Address]  WITH CHECK ADD  CONSTRAINT [FK_Address_Personnels] FOREIGN KEY([PersonnelNo])
REFERENCES [Personnel].[Personnels] ([PersonnelNo])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [Personnel].[Address] CHECK CONSTRAINT [FK_Address_Personnels]
GO
ALTER TABLE [Personnel].[Childrens]  WITH CHECK ADD  CONSTRAINT [FK_Childrens_Spouses] FOREIGN KEY([SpouseNo])
REFERENCES [Personnel].[Spouses] ([SpouseNo])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [Personnel].[Childrens] CHECK CONSTRAINT [FK_Childrens_Spouses]
GO
ALTER TABLE [Personnel].[Municipalities]  WITH CHECK ADD  CONSTRAINT [FK_Municipalities_Provinces] FOREIGN KEY([ProvinceNo])
REFERENCES [Personnel].[Provinces] ([ProvinceNo])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [Personnel].[Municipalities] CHECK CONSTRAINT [FK_Municipalities_Provinces]
GO
ALTER TABLE [Personnel].[Provinces]  WITH CHECK ADD  CONSTRAINT [FK_Provinces_Regions] FOREIGN KEY([RegionNo])
REFERENCES [Personnel].[Regions] ([RegionNo])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [Personnel].[Provinces] CHECK CONSTRAINT [FK_Provinces_Regions]
GO
ALTER TABLE [Personnel].[Spouses]  WITH CHECK ADD  CONSTRAINT [FK_Spouses_Personnels] FOREIGN KEY([PersonnelNo])
REFERENCES [Personnel].[Personnels] ([PersonnelNo])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [Personnel].[Spouses] CHECK CONSTRAINT [FK_Spouses_Personnels]
GO
USE [master]
GO
ALTER DATABASE [PDS] SET  READ_WRITE 
GO
