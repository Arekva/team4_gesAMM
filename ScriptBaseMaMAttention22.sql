USE [master]
GO
/****** Object:  Database [GSB_gesAMM]    Script Date: 17/12/2020 15:30:58 ******/
CREATE DATABASE [GSB_gesAMM]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'GSB_gesAMM', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\GSB_gesAMM.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'GSB_gesAMM_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\GSB_gesAMM_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [GSB_gesAMM] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [GSB_gesAMM].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [GSB_gesAMM] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [GSB_gesAMM] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [GSB_gesAMM] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [GSB_gesAMM] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [GSB_gesAMM] SET ARITHABORT OFF 
GO
ALTER DATABASE [GSB_gesAMM] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [GSB_gesAMM] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [GSB_gesAMM] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [GSB_gesAMM] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [GSB_gesAMM] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [GSB_gesAMM] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [GSB_gesAMM] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [GSB_gesAMM] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [GSB_gesAMM] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [GSB_gesAMM] SET  DISABLE_BROKER 
GO
ALTER DATABASE [GSB_gesAMM] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [GSB_gesAMM] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [GSB_gesAMM] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [GSB_gesAMM] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [GSB_gesAMM] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [GSB_gesAMM] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [GSB_gesAMM] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [GSB_gesAMM] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [GSB_gesAMM] SET  MULTI_USER 
GO
ALTER DATABASE [GSB_gesAMM] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [GSB_gesAMM] SET DB_CHAINING OFF 
GO
ALTER DATABASE [GSB_gesAMM] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [GSB_gesAMM] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [GSB_gesAMM] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [GSB_gesAMM] SET QUERY_STORE = OFF
GO
USE [GSB_gesAMM]
GO
/****** Object:  Table [dbo].[Decision]    Script Date: 17/12/2020 15:30:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Decision](
	[DCS_id] [int] NOT NULL,
	[DCS_libelle] [char](50) NOT NULL,
 CONSTRAINT [PK_Decision] PRIMARY KEY CLUSTERED 
(
	[DCS_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Etape]    Script Date: 17/12/2020 15:30:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Etape](
	[ETP_num] [int] NOT NULL,
	[ETP_libelle] [char](50) NOT NULL,
	[ETP_dateNorme] [date] NULL,
	[ETP_norme] [nchar](30) NULL,
	[ETP_dernier_user] [int] NULL,
 CONSTRAINT [PK_Etape] PRIMARY KEY CLUSTERED 
(
	[ETP_num] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Famille]    Script Date: 17/12/2020 15:30:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Famille](
	[FAM_code] [nchar](50) NOT NULL,
	[FAM_libelle] [char](255) NOT NULL,
	[FAM_nbMediAmm] [int] NOT NULL,
 CONSTRAINT [PK_Famille] PRIMARY KEY CLUSTERED 
(
	[FAM_code] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Historique]    Script Date: 17/12/2020 15:30:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Historique](
	[numero] [int] NOT NULL,
	[dateMaj] [date] NULL,
	[idUtilisateur] [int] NULL,
	[numEtape] [int] NULL,
	[normeBeforeChange] [nvarchar](20) NULL,
	[dateNormeBeforeChange] [date] NULL,
	[normeAfterChange] [nvarchar](20) NULL,
	[dateNormeAfterChange] [date] NULL,
 CONSTRAINT [PK_Historique] PRIMARY KEY CLUSTERED 
(
	[numero] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Medicament]    Script Date: 17/12/2020 15:30:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Medicament](
	[MED_depotLegal] [nchar](50) NOT NULL,
	[MED_nomCommercial] [nchar](50) NOT NULL,
	[MED_composition] [nchar](255) NOT NULL,
	[MED_effets] [nchar](255) NOT NULL,
	[MED_contreIndications] [nchar](255) NOT NULL,
	[MED_amm] [nchar](50) NULL,
	[MEDderniereEtape] [int] NULL,
	[MED_codeFamille] [nchar](50) NULL,
 CONSTRAINT [PK_Medicament] PRIMARY KEY CLUSTERED 
(
	[MED_depotLegal] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Subir]    Script Date: 17/12/2020 15:30:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Subir](
	[SUB_dateDecision] [datetime] NOT NULL,
	[SUB_numEtape] [int] NOT NULL,
	[SUB_idDecision] [int] NOT NULL,
	[SUB_codeDepotLegal] [nchar](50) NOT NULL,
 CONSTRAINT [PK_Subir] PRIMARY KEY CLUSTERED 
(
	[SUB_numEtape] ASC,
	[SUB_codeDepotLegal] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Utilisateur]    Script Date: 17/12/2020 15:30:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Utilisateur](
	[id] [int] NOT NULL,
	[login] [varchar](20) NULL,
	[mdp] [varchar](100) NULL,
 CONSTRAINT [PK_Utilisateur] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Decision] ([DCS_id], [DCS_libelle]) VALUES (1, N'validee                                           ')
INSERT [dbo].[Decision] ([DCS_id], [DCS_libelle]) VALUES (2, N'refusee                                           ')
GO
INSERT [dbo].[Etape] ([ETP_num], [ETP_libelle], [ETP_dateNorme], [ETP_norme], [ETP_dernier_user]) VALUES (1, N'Definition du protocole de validation             ', NULL, NULL, NULL)
INSERT [dbo].[Etape] ([ETP_num], [ETP_libelle], [ETP_dateNorme], [ETP_norme], [ETP_dernier_user]) VALUES (2, N'Pharmacologie experimentale                       ', NULL, NULL, NULL)
INSERT [dbo].[Etape] ([ETP_num], [ETP_libelle], [ETP_dateNorme], [ETP_norme], [ETP_dernier_user]) VALUES (3, N'Toxicologie                                       ', CAST(N'2004-05-12' AS Date), N'726/2004/CEE                  ', NULL)
INSERT [dbo].[Etape] ([ETP_num], [ETP_libelle], [ETP_dateNorme], [ETP_norme], [ETP_dernier_user]) VALUES (4, N'Pharmacocinetique                                 ', NULL, NULL, NULL)
INSERT [dbo].[Etape] ([ETP_num], [ETP_libelle], [ETP_dateNorme], [ETP_norme], [ETP_dernier_user]) VALUES (5, N'Experimentation animale                           ', CAST(N'2012-01-05' AS Date), N'180/2012/CEE                  ', NULL)
INSERT [dbo].[Etape] ([ETP_num], [ETP_libelle], [ETP_dateNorme], [ETP_norme], [ETP_dernier_user]) VALUES (6, N'Methodes alternatives                             ', NULL, NULL, NULL)
INSERT [dbo].[Etape] ([ETP_num], [ETP_libelle], [ETP_dateNorme], [ETP_norme], [ETP_dernier_user]) VALUES (7, N'Essais cliniques                                  ', CAST(N'2009-03-15' AS Date), N'665/2005/CEE                  ', 1)
INSERT [dbo].[Etape] ([ETP_num], [ETP_libelle], [ETP_dateNorme], [ETP_norme], [ETP_dernier_user]) VALUES (8, N'Autorisation Mise sur le Marche                   ', CAST(N'2005-04-29' AS Date), N'665/2005/CEE                  ', 1)
GO
INSERT [dbo].[Famille] ([FAM_code], [FAM_libelle], [FAM_nbMediAmm]) VALUES (N'AA                                                ', N'Antalgiques en association                                                                                                                                                                                                                                     ', 0)
INSERT [dbo].[Famille] ([FAM_code], [FAM_libelle], [FAM_nbMediAmm]) VALUES (N'AAA                                               ', N'Antalgiques antipyretiques en association                                                                                                                                                                                                                      ', 0)
INSERT [dbo].[Famille] ([FAM_code], [FAM_libelle], [FAM_nbMediAmm]) VALUES (N'AAC                                               ', N'Antidepresseur d’action centrale                                                                                                                                                                                                                               ', 0)
INSERT [dbo].[Famille] ([FAM_code], [FAM_libelle], [FAM_nbMediAmm]) VALUES (N'AAH                                               ', N'Antivertigineux antihistaminique H1                                                                                                                                                                                                                            ', 0)
INSERT [dbo].[Famille] ([FAM_code], [FAM_libelle], [FAM_nbMediAmm]) VALUES (N'ABA                                               ', N'Antibiotique antituberculeux                                                                                                                                                                                                                                   ', 0)
INSERT [dbo].[Famille] ([FAM_code], [FAM_libelle], [FAM_nbMediAmm]) VALUES (N'ABC                                               ', N'Antibiotique antiacneique local                                                                                                                                                                                                                                ', 0)
INSERT [dbo].[Famille] ([FAM_code], [FAM_libelle], [FAM_nbMediAmm]) VALUES (N'ABP                                               ', N'Antibiotique de la famille des beta-lactamines (penicilline A)                                                                                                                                                                                                 ', 0)
INSERT [dbo].[Famille] ([FAM_code], [FAM_libelle], [FAM_nbMediAmm]) VALUES (N'AFC                                               ', N'Antibiotique de la famille des cyclines                                                                                                                                                                                                                        ', 0)
INSERT [dbo].[Famille] ([FAM_code], [FAM_libelle], [FAM_nbMediAmm]) VALUES (N'AFM                                               ', N'Antibiotique de la famille des macrolides                                                                                                                                                                                                                      ', 0)
INSERT [dbo].[Famille] ([FAM_code], [FAM_libelle], [FAM_nbMediAmm]) VALUES (N'AH                                                ', N'Antihistaminique H1 local                                                                                                                                                                                                                                      ', 0)
INSERT [dbo].[Famille] ([FAM_code], [FAM_libelle], [FAM_nbMediAmm]) VALUES (N'AIM                                               ', N'Antidepresseur imipraminique (tricyclique)                                                                                                                                                                                                                     ', 0)
INSERT [dbo].[Famille] ([FAM_code], [FAM_libelle], [FAM_nbMediAmm]) VALUES (N'AIN                                               ', N'Antidepresseur inhibiteur selectif de la recapture de la serotonine                                                                                                                                                                                            ', 0)
INSERT [dbo].[Famille] ([FAM_code], [FAM_libelle], [FAM_nbMediAmm]) VALUES (N'ALO                                               ', N'Antibiotique local (ORL)                                                                                                                                                                                                                                       ', 0)
INSERT [dbo].[Famille] ([FAM_code], [FAM_libelle], [FAM_nbMediAmm]) VALUES (N'ANS                                               ', N'Antidepresseur IMAO non selectif                                                                                                                                                                                                                               ', 0)
INSERT [dbo].[Famille] ([FAM_code], [FAM_libelle], [FAM_nbMediAmm]) VALUES (N'AO                                                ', N'Antibiotique ophtalmique                                                                                                                                                                                                                                       ', 0)
INSERT [dbo].[Famille] ([FAM_code], [FAM_libelle], [FAM_nbMediAmm]) VALUES (N'AP                                                ', N'Antipsychotique normothymique                                                                                                                                                                                                                                  ', 0)
INSERT [dbo].[Famille] ([FAM_code], [FAM_libelle], [FAM_nbMediAmm]) VALUES (N'AUM                                               ', N'Antibiotique urinaire minute                                                                                                                                                                                                                                   ', 0)
INSERT [dbo].[Famille] ([FAM_code], [FAM_libelle], [FAM_nbMediAmm]) VALUES (N'CRT                                               ', N'"Corticoide                                                                                                                                                                                                                                                    ', 1)
INSERT [dbo].[Famille] ([FAM_code], [FAM_libelle], [FAM_nbMediAmm]) VALUES (N'HYP                                               ', N'Hypnotique antihistaminique                                                                                                                                                                                                                                    ', 0)
INSERT [dbo].[Famille] ([FAM_code], [FAM_libelle], [FAM_nbMediAmm]) VALUES (N'PSA                                               ', N'"Psychostimulant                                                                                                                                                                                                                                               ', 0)
GO
INSERT [dbo].[Historique] ([numero], [dateMaj], [idUtilisateur], [numEtape], [normeBeforeChange], [dateNormeBeforeChange], [normeAfterChange], [dateNormeAfterChange]) VALUES (1, CAST(N'2020-12-17' AS Date), 1, 7, NULL, CAST(N'2005-04-30' AS Date), N'665/2005/CEE        ', CAST(N'2009-03-15' AS Date))
INSERT [dbo].[Historique] ([numero], [dateMaj], [idUtilisateur], [numEtape], [normeBeforeChange], [dateNormeBeforeChange], [normeAfterChange], [dateNormeAfterChange]) VALUES (2, CAST(N'2020-12-17' AS Date), 1, 8, NULL, CAST(N'2005-04-30' AS Date), N'665/2005/CEE        ', CAST(N'2005-04-29' AS Date))
GO
INSERT [dbo].[Medicament] ([MED_depotLegal], [MED_nomCommercial], [MED_composition], [MED_effets], [MED_contreIndications], [MED_amm], [MEDderniereEtape], [MED_codeFamille]) VALUES (N'3MYC7                                             ', N'TRIMYCINE                                         ', N'Triamcinolone (acétonide) + Néomycine + Nystatine                                                                                                                                                                                                              ', N'"Ce médicament est un corticoïde à  activité forte ou très forte associé à  un antibiotique et un antifongique                                                                                                                                                 ', N' utilisé en application locale dans certaines atteintes cutanées surinfectées."                                                                                                                                                                                ', N'5555555                                           ', 8, N'CRT                                               ')
INSERT [dbo].[Medicament] ([MED_depotLegal], [MED_nomCommercial], [MED_composition], [MED_effets], [MED_contreIndications], [MED_amm], [MEDderniereEtape], [MED_codeFamille]) VALUES (N'ADIMOL9                                           ', N'ADIMOL                                            ', N'Amoxicilline + Acide clavulanique                                                                                                                                                                                                                              ', N'"Ce médicament                                                                                                                                                                                                                                                 ', N' plus puissant que les pénicillines simples                                                                                                                                                                                                                    ', NULL, 4, N'ABP                                               ')
INSERT [dbo].[Medicament] ([MED_depotLegal], [MED_nomCommercial], [MED_composition], [MED_effets], [MED_contreIndications], [MED_amm], [MEDderniereEtape], [MED_codeFamille]) VALUES (N'AMOPIL7                                           ', N'AMOPIL                                            ', N'Amoxicilline                                                                                                                                                                                                                                                   ', N'"Ce médicament                                                                                                                                                                                                                                                 ', N' plus puissant que les pénicillines simples                                                                                                                                                                                                                    ', NULL, 3, N'ABP                                               ')
INSERT [dbo].[Medicament] ([MED_depotLegal], [MED_nomCommercial], [MED_composition], [MED_effets], [MED_contreIndications], [MED_amm], [MEDderniereEtape], [MED_codeFamille]) VALUES (N'AMOX45                                            ', N'AMOXAR                                            ', N'Amoxicilline                                                                                                                                                                                                                                                   ', N'"Ce médicament                                                                                                                                                                                                                                                 ', N' plus puissant que les pénicillines simples                                                                                                                                                                                                                    ', NULL, NULL, N'ABP                                               ')
INSERT [dbo].[Medicament] ([MED_depotLegal], [MED_nomCommercial], [MED_composition], [MED_effets], [MED_contreIndications], [MED_amm], [MEDderniereEtape], [MED_codeFamille]) VALUES (N'AMOXIG12                                          ', N'AMOXI Gé                                          ', N'Amoxicilline                                                                                                                                                                                                                                                   ', N'"Ce médicament                                                                                                                                                                                                                                                 ', N' plus puissant que les pénicillines simples                                                                                                                                                                                                                    ', NULL, NULL, N'ABP                                               ')
INSERT [dbo].[Medicament] ([MED_depotLegal], [MED_nomCommercial], [MED_composition], [MED_effets], [MED_contreIndications], [MED_amm], [MEDderniereEtape], [MED_codeFamille]) VALUES (N'APATOUX22                                         ', N'APATOUX Vitamine C                                ', N'Tyrothricine + Tétracaïne + Acide ascorbique (Vitamine C)                                                                                                                                                                                                      ', N'Ce médicament est utilisé pour traiter les affections de la bouche et de la gorge.                                                                                                                                                                             ', N'"Ce médicament est contre-indiqué en cas d’allergie à  l’un des constituants                                                                                                                                                                                   ', NULL, NULL, N'ALO                                               ')
INSERT [dbo].[Medicament] ([MED_depotLegal], [MED_nomCommercial], [MED_composition], [MED_effets], [MED_contreIndications], [MED_amm], [MEDderniereEtape], [MED_codeFamille]) VALUES (N'BACTIG10                                          ', N'BACTIGEL                                          ', N'Erythromycine                                                                                                                                                                                                                                                  ', N'Ce médicament est utilisé en application locale pour traiter l’acné et les infections cutanées bactériennes associées.                                                                                                                                         ', N'Ce médicament est contre-indiqué en cas d’allergie aux antibiotiques de la famille des macrolides ou des lincosanides.                                                                                                                                         ', NULL, NULL, N'ABC                                               ')
INSERT [dbo].[Medicament] ([MED_depotLegal], [MED_nomCommercial], [MED_composition], [MED_effets], [MED_contreIndications], [MED_amm], [MEDderniereEtape], [MED_codeFamille]) VALUES (N'BACTIV13                                          ', N'BACTIVIL                                          ', N'Erythromycine                                                                                                                                                                                                                                                  ', N'Ce médicament est utilisé pour traiter des infections bactériennes spécifiques.                                                                                                                                                                                ', N'Ce médicament est contre-indiqué en cas d’allergie aux macrolides (dont le chef de file est l’érythromycine).                                                                                                                                                  ', NULL, NULL, N'AFM                                               ')
INSERT [dbo].[Medicament] ([MED_depotLegal], [MED_nomCommercial], [MED_composition], [MED_effets], [MED_contreIndications], [MED_amm], [MEDderniereEtape], [MED_codeFamille]) VALUES (N'BITALV                                            ', N'BIVALIC                                           ', N'Dextropropoxyphène + Paracétamol                                                                                                                                                                                                                               ', N'Ce médicament est utilisé pour traiter les douleurs d’intensité modérée ou intense.                                                                                                                                                                            ', N'"Ce médicament est contre-indiqué en cas d’allergie aux médicaments de cette famille                                                                                                                                                                           ', NULL, NULL, N'AAA                                               ')
INSERT [dbo].[Medicament] ([MED_depotLegal], [MED_nomCommercial], [MED_composition], [MED_effets], [MED_contreIndications], [MED_amm], [MEDderniereEtape], [MED_codeFamille]) VALUES (N'CARTION6                                          ', N'CARTION                                           ', N'Acide acétylsalicylique (aspirine) + Acide ascorbique (Vitamine C) + Paracétamol                                                                                                                                                                               ', N'Ce médicament est utilisé dans le traitement symptomatique de la douleur ou de la fièvre.                                                                                                                                                                      ', N'"Ce médicament est contre-indiqué en cas de troubles de la coagulation (tendances aux hémorragies)                                                                                                                                                             ', NULL, NULL, N'AAA                                               ')
INSERT [dbo].[Medicament] ([MED_depotLegal], [MED_nomCommercial], [MED_composition], [MED_effets], [MED_contreIndications], [MED_amm], [MEDderniereEtape], [MED_codeFamille]) VALUES (N'CLAZER6                                           ', N'CLAZER                                            ', N'Clarithromycine                                                                                                                                                                                                                                                ', N'"Ce médicament est utilisé pour traiter des infections bactériennes spécifiques. Il est également utilisé dans le traitement de l’ulcère gastro-duodénal                                                                                                       ', N' en association avec d’autres médicaments."                                                                                                                                                                                                                    ', NULL, NULL, N'AFM                                               ')
INSERT [dbo].[Medicament] ([MED_depotLegal], [MED_nomCommercial], [MED_composition], [MED_effets], [MED_contreIndications], [MED_amm], [MEDderniereEtape], [MED_codeFamille]) VALUES (N'DEPRIL9                                           ', N'DEPRAMIL                                          ', N'Clomipramine                                                                                                                                                                                                                                                   ', N'"Ce médicament est utilisé pour traiter les épisodes dépressifs sévères                                                                                                                                                                                        ', N' certaines douleurs rebelles                                                                                                                                                                                                                                   ', NULL, NULL, N'AIM                                               ')
INSERT [dbo].[Medicament] ([MED_depotLegal], [MED_nomCommercial], [MED_composition], [MED_effets], [MED_contreIndications], [MED_amm], [MEDderniereEtape], [MED_codeFamille]) VALUES (N'DIMIRTAM6                                         ', N'DIMIRTAM                                          ', N'Mirtazapine                                                                                                                                                                                                                                                    ', N'Ce médicament est utilisé pour traiter les épisodes dépressifs sévères.                                                                                                                                                                                        ', N'La prise de ce produit est contre-indiquée en cas de d’allergie à  l’un des constituants.                                                                                                                                                                      ', NULL, NULL, N'AAC                                               ')
INSERT [dbo].[Medicament] ([MED_depotLegal], [MED_nomCommercial], [MED_composition], [MED_effets], [MED_contreIndications], [MED_amm], [MEDderniereEtape], [MED_codeFamille]) VALUES (N'DOLRIL7                                           ', N'DOLORIL                                           ', N'Acide acétylsalicylique (aspirine) + Acide ascorbique (Vitamine C) + Paracétamol                                                                                                                                                                               ', N'Ce médicament est utilisé dans le traitement symptomatique de la douleur ou de la fièvre.                                                                                                                                                                      ', N'Ce médicament est contre-indiqué en cas d’allergie au paracétamol ou aux salicylates.                                                                                                                                                                          ', N'NULL                                              ', NULL, N'AAA                                               ')
INSERT [dbo].[Medicament] ([MED_depotLegal], [MED_nomCommercial], [MED_composition], [MED_effets], [MED_contreIndications], [MED_amm], [MEDderniereEtape], [MED_codeFamille]) VALUES (N'DORNOM8                                           ', N'NORMADOR                                          ', N'Doxylamine                                                                                                                                                                                                                                                     ', N'Ce médicament est utilisé pour traiter l’insomnie chez l’adulte.                                                                                                                                                                                               ', N'"Ce médicament est contre-indiqué en cas de glaucome                                                                                                                                                                                                           ', NULL, NULL, N'HYP                                               ')
INSERT [dbo].[Medicament] ([MED_depotLegal], [MED_nomCommercial], [MED_composition], [MED_effets], [MED_contreIndications], [MED_amm], [MEDderniereEtape], [MED_codeFamille]) VALUES (N'EQUILARX6                                         ', N'EQUILAR                                           ', N'Méclozine                                                                                                                                                                                                                                                      ', N'Ce médicament est utilisé pour traiter les vertiges et pour prévenir le mal des transports.                                                                                                                                                                    ', N'"Ce médicament ne doit pas être utilisé en cas d’allergie au produit                                                                                                                                                                                           ', NULL, NULL, N'AAH                                               ')
INSERT [dbo].[Medicament] ([MED_depotLegal], [MED_nomCommercial], [MED_composition], [MED_effets], [MED_contreIndications], [MED_amm], [MEDderniereEtape], [MED_codeFamille]) VALUES (N'EVILR7                                            ', N'EVEILLOR                                          ', N'Adrafinil                                                                                                                                                                                                                                                      ', N'Ce médicament est utilisé pour traiter les troubles de la vigilance et certains symptomes neurologiques chez le sujet agé.                                                                                                                                     ', N'Ce médicament est contre-indiqué en cas d’allergie à  l’un des constituants.                                                                                                                                                                                   ', NULL, NULL, N'PSA                                               ')
INSERT [dbo].[Medicament] ([MED_depotLegal], [MED_nomCommercial], [MED_composition], [MED_effets], [MED_contreIndications], [MED_amm], [MEDderniereEtape], [MED_codeFamille]) VALUES (N'INSXT5                                            ', N'INSECTIL                                          ', N'Diphénydramine                                                                                                                                                                                                                                                 ', N'Ce médicament est utilisé en application locale sur les piqûres d’insecte et l’urticaire.                                                                                                                                                                      ', N'Ce médicament est contre-indiqué en cas d’allergie aux antihistaminiques.                                                                                                                                                                                      ', NULL, NULL, N'AH                                                ')
INSERT [dbo].[Medicament] ([MED_depotLegal], [MED_nomCommercial], [MED_composition], [MED_effets], [MED_contreIndications], [MED_amm], [MEDderniereEtape], [MED_codeFamille]) VALUES (N'JOVAI8                                            ', N'JOVENIL                                           ', N'Josamycine                                                                                                                                                                                                                                                     ', N'Ce médicament est utilisé pour traiter des infections bactériennes spécifiques.                                                                                                                                                                                ', N'Ce médicament est contre-indiqué en cas d’allergie aux macrolides (dont le chef de file est l’érythromycine).                                                                                                                                                  ', NULL, NULL, N'AFM                                               ')
INSERT [dbo].[Medicament] ([MED_depotLegal], [MED_nomCommercial], [MED_composition], [MED_effets], [MED_contreIndications], [MED_amm], [MEDderniereEtape], [MED_codeFamille]) VALUES (N'LIDOXY23                                          ', N'LIDOXYTRACINE                                     ', N'Oxytétracycline +Lidocaïne                                                                                                                                                                                                                                     ', N'Ce médicament est utilisé en injection intramusculaire pour traiter certaines infections spécifiques.                                                                                                                                                          ', N'Ce médicament est contre-indiqué en cas d’allergie à  l’un des constituants. Il ne doit pas être associé aux rétinoïdes.                                                                                                                                       ', NULL, NULL, N'AFC                                               ')
INSERT [dbo].[Medicament] ([MED_depotLegal], [MED_nomCommercial], [MED_composition], [MED_effets], [MED_contreIndications], [MED_amm], [MEDderniereEtape], [MED_codeFamille]) VALUES (N'LITHOR12                                          ', N'LITHORINE                                         ', N'Lithium                                                                                                                                                                                                                                                        ', N'Ce médicament est indiqué dans la prévention des psychoses maniaco-dépressives ou pour traiter les états maniaques.                                                                                                                                            ', N'"Ce médicament ne doit pas être utilisé si vous êtes allergique au lithium. Avant de prendre ce traitement                                                                                                                                                     ', NULL, NULL, N'AP                                                ')
INSERT [dbo].[Medicament] ([MED_depotLegal], [MED_nomCommercial], [MED_composition], [MED_effets], [MED_contreIndications], [MED_amm], [MEDderniereEtape], [MED_codeFamille]) VALUES (N'PARMOL16                                          ', N'PARMOCODEINE                                      ', N'Codéine + Paracétamol                                                                                                                                                                                                                                          ', N'Ce médicament est utilisé pour le traitement des douleurs lorsque des antalgiques simples ne sont pas assez efficaces.                                                                                                                                         ', N'"Ce médicament est contre-indiqué en cas d’allergie à  l’un des constituants                                                                                                                                                                                   ', NULL, NULL, N'AA                                                ')
INSERT [dbo].[Medicament] ([MED_depotLegal], [MED_nomCommercial], [MED_composition], [MED_effets], [MED_contreIndications], [MED_amm], [MEDderniereEtape], [MED_codeFamille]) VALUES (N'PHYSOI8                                           ', N'PHYSICOR                                          ', N'Sulbutiamine                                                                                                                                                                                                                                                   ', N'"Ce médicament est utilisé pour traiter les baisses d’activité physique ou psychique                                                                                                                                                                           ', N' souvent dans un contexte de dépression."                                                                                                                                                                                                                      ', NULL, NULL, N'PSA                                               ')
INSERT [dbo].[Medicament] ([MED_depotLegal], [MED_nomCommercial], [MED_composition], [MED_effets], [MED_contreIndications], [MED_amm], [MEDderniereEtape], [MED_codeFamille]) VALUES (N'PIRIZ8                                            ', N'PIRIZAN                                           ', N'Pyrazinamide                                                                                                                                                                                                                                                   ', N'"Ce médicament est utilisé                                                                                                                                                                                                                                     ', N' en association à  d’autres antibiotiques                                                                                                                                                                                                                      ', NULL, NULL, N'ABA                                               ')
INSERT [dbo].[Medicament] ([MED_depotLegal], [MED_nomCommercial], [MED_composition], [MED_effets], [MED_contreIndications], [MED_amm], [MEDderniereEtape], [MED_codeFamille]) VALUES (N'POMDI20                                           ', N'POMADINE                                          ', N'Bacitracine                                                                                                                                                                                                                                                    ', N'Ce médicament est utilisé pour traiter les infections oculaires de la surface de l’oeil.                                                                                                                                                                       ', N'Ce médicament est contre-indiqué en cas d’allergie aux antibiotiques appliqués localement.                                                                                                                                                                     ', NULL, NULL, N'AO                                                ')
INSERT [dbo].[Medicament] ([MED_depotLegal], [MED_nomCommercial], [MED_composition], [MED_effets], [MED_contreIndications], [MED_amm], [MEDderniereEtape], [MED_codeFamille]) VALUES (N'TESTATRON                                         ', N'A                                                 ', N'a                                                                                                                                                                                                                                                              ', N'aa                                                                                                                                                                                                                                                             ', N'a                                                                                                                                                                                                                                                              ', NULL, NULL, N'AA                                                ')
INSERT [dbo].[Medicament] ([MED_depotLegal], [MED_nomCommercial], [MED_composition], [MED_effets], [MED_contreIndications], [MED_amm], [MEDderniereEtape], [MED_codeFamille]) VALUES (N'TROXT21                                           ', N'TROXADET                                          ', N'Paroxétine                                                                                                                                                                                                                                                     ', N'Ce médicament est utilisé pour traiter la dépression et les troubles obsessionnels compulsifs. Il peut également être utilisé en prévention des crises de panique avec ou sans agoraphobie.                                                                    ', N'Ce médicament est contre-indiqué en cas d’allergie au produit.                                                                                                                                                                                                 ', NULL, NULL, N'AIN                                               ')
INSERT [dbo].[Medicament] ([MED_depotLegal], [MED_nomCommercial], [MED_composition], [MED_effets], [MED_contreIndications], [MED_amm], [MEDderniereEtape], [MED_codeFamille]) VALUES (N'TXISOL22                                          ', N'TOUXISOL Vitamine C                               ', N'Tyrothricine + Acide ascorbique (Vitamine C)                                                                                                                                                                                                                   ', N'Ce médicament est utilisé pour traiter les affections de la bouche et de la gorge.                                                                                                                                                                             ', N'Ce médicament est contre-indiqué en cas d’allergie à  l’un des constituants et chez l’enfant de moins de 6 ans.                                                                                                                                                ', NULL, NULL, N'ALO                                               ')
INSERT [dbo].[Medicament] ([MED_depotLegal], [MED_nomCommercial], [MED_composition], [MED_effets], [MED_contreIndications], [MED_amm], [MEDderniereEtape], [MED_codeFamille]) VALUES (N'URIEG6                                            ', N'URIREGUL                                          ', N'Fosfomycine trométamol                                                                                                                                                                                                                                         ', N'Ce médicament est utilisé pour traiter les infections urinaires simples chez la femme de moins de 65 ans.                                                                                                                                                      ', N'La prise de ce médicament est contre-indiquée en cas d’allergie à  l’un des constituants et d’insuffisance rénale.                                                                                                                                             ', NULL, NULL, N'AUM                                               ')
GO
INSERT [dbo].[Subir] ([SUB_dateDecision], [SUB_numEtape], [SUB_idDecision], [SUB_codeDepotLegal]) VALUES (CAST(N'2020-12-17T15:25:42.720' AS DateTime), 1, 1, N'3MYC7                                             ')
INSERT [dbo].[Subir] ([SUB_dateDecision], [SUB_numEtape], [SUB_idDecision], [SUB_codeDepotLegal]) VALUES (CAST(N'2020-12-01T15:25:42.000' AS DateTime), 1, 1, N'ADIMOL9                                           ')
INSERT [dbo].[Subir] ([SUB_dateDecision], [SUB_numEtape], [SUB_idDecision], [SUB_codeDepotLegal]) VALUES (CAST(N'2020-12-01T15:25:42.000' AS DateTime), 1, 1, N'AMOPIL7                                           ')
INSERT [dbo].[Subir] ([SUB_dateDecision], [SUB_numEtape], [SUB_idDecision], [SUB_codeDepotLegal]) VALUES (CAST(N'2020-12-17T15:25:42.720' AS DateTime), 2, 1, N'3MYC7                                             ')
INSERT [dbo].[Subir] ([SUB_dateDecision], [SUB_numEtape], [SUB_idDecision], [SUB_codeDepotLegal]) VALUES (CAST(N'2020-12-01T15:25:42.000' AS DateTime), 2, 1, N'ADIMOL9                                           ')
INSERT [dbo].[Subir] ([SUB_dateDecision], [SUB_numEtape], [SUB_idDecision], [SUB_codeDepotLegal]) VALUES (CAST(N'2020-12-01T15:25:42.000' AS DateTime), 2, 1, N'AMOPIL7                                           ')
INSERT [dbo].[Subir] ([SUB_dateDecision], [SUB_numEtape], [SUB_idDecision], [SUB_codeDepotLegal]) VALUES (CAST(N'2020-12-17T15:25:42.720' AS DateTime), 3, 1, N'3MYC7                                             ')
INSERT [dbo].[Subir] ([SUB_dateDecision], [SUB_numEtape], [SUB_idDecision], [SUB_codeDepotLegal]) VALUES (CAST(N'2020-12-01T15:25:42.000' AS DateTime), 3, 1, N'ADIMOL9                                           ')
INSERT [dbo].[Subir] ([SUB_dateDecision], [SUB_numEtape], [SUB_idDecision], [SUB_codeDepotLegal]) VALUES (CAST(N'2020-12-01T15:25:42.000' AS DateTime), 3, 1, N'AMOPIL7                                           ')
INSERT [dbo].[Subir] ([SUB_dateDecision], [SUB_numEtape], [SUB_idDecision], [SUB_codeDepotLegal]) VALUES (CAST(N'2020-12-17T15:25:42.720' AS DateTime), 4, 1, N'3MYC7                                             ')
INSERT [dbo].[Subir] ([SUB_dateDecision], [SUB_numEtape], [SUB_idDecision], [SUB_codeDepotLegal]) VALUES (CAST(N'2020-12-01T15:25:42.000' AS DateTime), 4, 2, N'ADIMOL9                                           ')
INSERT [dbo].[Subir] ([SUB_dateDecision], [SUB_numEtape], [SUB_idDecision], [SUB_codeDepotLegal]) VALUES (CAST(N'2020-12-17T15:25:42.720' AS DateTime), 5, 1, N'3MYC7                                             ')
INSERT [dbo].[Subir] ([SUB_dateDecision], [SUB_numEtape], [SUB_idDecision], [SUB_codeDepotLegal]) VALUES (CAST(N'2020-12-17T15:25:42.720' AS DateTime), 6, 1, N'3MYC7                                             ')
INSERT [dbo].[Subir] ([SUB_dateDecision], [SUB_numEtape], [SUB_idDecision], [SUB_codeDepotLegal]) VALUES (CAST(N'2020-12-17T15:25:42.720' AS DateTime), 7, 1, N'3MYC7                                             ')
INSERT [dbo].[Subir] ([SUB_dateDecision], [SUB_numEtape], [SUB_idDecision], [SUB_codeDepotLegal]) VALUES (CAST(N'2020-12-01T15:25:42.000' AS DateTime), 8, 1, N'3MYC7                                             ')
GO
INSERT [dbo].[Utilisateur] ([id], [login], [mdp]) VALUES (1, N'aaa', N'mdp')
INSERT [dbo].[Utilisateur] ([id], [login], [mdp]) VALUES (2, N'bbb', N'mdp')
INSERT [dbo].[Utilisateur] ([id], [login], [mdp]) VALUES (3, N'ccc', N'mdp')
GO
ALTER TABLE [dbo].[Historique]  WITH CHECK ADD  CONSTRAINT [FK_Historique_Etape] FOREIGN KEY([numEtape])
REFERENCES [dbo].[Etape] ([ETP_num])
GO
ALTER TABLE [dbo].[Historique] CHECK CONSTRAINT [FK_Historique_Etape]
GO
ALTER TABLE [dbo].[Historique]  WITH CHECK ADD  CONSTRAINT [FK_Historique_Utilisateur] FOREIGN KEY([idUtilisateur])
REFERENCES [dbo].[Utilisateur] ([id])
GO
ALTER TABLE [dbo].[Historique] CHECK CONSTRAINT [FK_Historique_Utilisateur]
GO
ALTER TABLE [dbo].[Medicament]  WITH CHECK ADD  CONSTRAINT [FK_Medicament_Famille] FOREIGN KEY([MED_codeFamille])
REFERENCES [dbo].[Famille] ([FAM_code])
GO
ALTER TABLE [dbo].[Medicament] CHECK CONSTRAINT [FK_Medicament_Famille]
GO
ALTER TABLE [dbo].[Subir]  WITH CHECK ADD  CONSTRAINT [FK_Subir_Decision] FOREIGN KEY([SUB_idDecision])
REFERENCES [dbo].[Decision] ([DCS_id])
GO
ALTER TABLE [dbo].[Subir] CHECK CONSTRAINT [FK_Subir_Decision]
GO
ALTER TABLE [dbo].[Subir]  WITH CHECK ADD  CONSTRAINT [FK_Subir_Etape] FOREIGN KEY([SUB_numEtape])
REFERENCES [dbo].[Etape] ([ETP_num])
GO
ALTER TABLE [dbo].[Subir] CHECK CONSTRAINT [FK_Subir_Etape]
GO
ALTER TABLE [dbo].[Subir]  WITH CHECK ADD  CONSTRAINT [FK_Subir_Medicament] FOREIGN KEY([SUB_codeDepotLegal])
REFERENCES [dbo].[Medicament] ([MED_depotLegal])
GO
ALTER TABLE [dbo].[Subir] CHECK CONSTRAINT [FK_Subir_Medicament]
GO
/****** Object:  StoredProcedure [dbo].[prc_maj_etapes_normee]    Script Date: 17/12/2020 15:30:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:        <Author,,Name>
-- Create date: <Create Date,,>
-- Description:    <Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[prc_maj_etapes_normee](@numEtape as int, @norme as nchar, @dateNorme as date, @idUser as int)
AS
BEGIN

 

    SET NOCOUNT ON;
    UPDATE Etape
    SET ETP_dateNorme = @dateNorme, ETP_norme = @norme, ETP_dernier_user = @idUser
    WHERE ETP_num = @numEtape

 

END
GO
/****** Object:  StoredProcedure [dbo].[prc_newWorkflow]    Script Date: 17/12/2020 15:30:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[prc_newWorkflow](@dateDeci as datetime, @numEtape as int,@idDeci as int ,@depotLegal as nchar(50))


AS
BEGIN

	SET NOCOUNT ON;

	insert into dbo.Subir values (@dateDeci,@numEtape,@idDeci,@depotLegal)

END
GO
/****** Object:  StoredProcedure [dbo].[prc_nouveau_medicament]    Script Date: 17/12/2020 15:30:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[prc_nouveau_medicament](@depotLegal as nchar(50), @nomCommerciale as nchar(50),@composition as nchar(255),
@effet as nchar(255), @contreIndication as nchar(255), @codeFamille as nchar(50)) 

AS
BEGIN

	SET NOCOUNT ON;

	INSERT INTO Medicament values (@depotLegal, @nomCommerciale,@composition,@effet,@contreIndication,null,null,@codeFamille)

END
GO
/****** Object:  StoredProcedure [dbo].[prc_setAMM]    Script Date: 17/12/2020 15:30:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[prc_setAMM](@amm as nchar(50),@depot as nchar(50))

AS
BEGIN

	SET NOCOUNT ON;
update Medicament set MED_amm = @amm where MED_depotLegal = @depot
END
GO
/****** Object:  StoredProcedure [dbo].[prc_setLastEtape]    Script Date: 17/12/2020 15:30:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[prc_setLastEtape](@depot as nchar(50),@etape as int)
AS
BEGIN

	SET NOCOUNT ON;

	update Medicament set MEDderniereEtape = @etape where MED_depotLegal=@depot

END
GO
/****** Object:  StoredProcedure [dbo].[prc_tous_medicaments]    Script Date: 17/12/2020 15:30:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================

create PROCEDURE [dbo].[prc_tous_medicaments]
AS
BEGIN
	SET NOCOUNT ON;

	SELECT * FROM [dbo].Medicament
RETURN
end

GO
/****** Object:  StoredProcedure [dbo].[prc_tous_subir]    Script Date: 17/12/2020 15:30:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[prc_tous_subir]
AS
	SET NOCOUNT ON;

	SELECT * FROM [dbo].Subir
RETURN
GO
/****** Object:  StoredProcedure [dbo].[prc_tout_utilisateurs]    Script Date: 17/12/2020 15:30:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[prc_tout_utilisateurs]
AS
BEGIN
    SET NOCOUNT ON;

    SELECT * from Utilisateur
END
GO
/****** Object:  StoredProcedure [dbo].[prc_toutes_decisions]    Script Date: 17/12/2020 15:30:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


create PROCEDURE [dbo].[prc_toutes_decisions]
AS
BEGIN
	SET NOCOUNT ON;

	SELECT * FROM [dbo].Decision
RETURN
end

GO
/****** Object:  StoredProcedure [dbo].[prc_toutes_etapes]    Script Date: 17/12/2020 15:30:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 
CREATE PROCEDURE [dbo].[prc_toutes_etapes]
AS
    SET NOCOUNT ON;
 
    SELECT * FROM [dbo].Etape
RETURN
GO
/****** Object:  StoredProcedure [dbo].[prc_toutes_familles]    Script Date: 17/12/2020 15:30:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[prc_toutes_familles]
AS
	SET NOCOUNT ON;

	SELECT * FROM [dbo].Famille
RETURN
GO
/****** Object:  Trigger [dbo].[trg_update_etape_history]    Script Date: 17/12/2020 15:30:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE TRIGGER [dbo].[trg_update_etape_history]
   ON  [dbo].[Etape]
   INSTEAD OF UPDATE
AS 
BEGIN
	SET NOCOUNT ON;

	DECLARE @norme as nchar(30)
	DECLARE @numEtape as int
	DECLARE @dateNorme as date
	DECLARE @idUser as int
	DECLARE @numero as int
	DECLARE @normeBefore as nchar(30)
	DECLARE @dateBefore as date

	SELECT @norme = ETP_norme, @numEtape = ETP_num, @dateNorme = ETP_dateNorme, @idUser = ETP_dernier_user from inserted
	SELECT @dateBefore = ETP_dateNorme, @norme = ETP_norme FROM Etape
	SELECT @numero = MAX(numero) FROM Historique

	if(@numero is null)
	BEGIN
		SET @numero = 1
	end
	ELSE
	begin
		SET @numero = @numero + 1
	END

	INSERT INTO Historique 
	VALUES (@numero,GETDATE(),@idUser,@numEtape,@normeBefore,@dateBefore,@norme,@dateNorme)

	UPDATE Etape
    SET ETP_dateNorme = @dateNorme, ETP_norme = @norme, ETP_dernier_user = @idUser
    WHERE ETP_num = @numEtape


END
GO
ALTER TABLE [dbo].[Etape] ENABLE TRIGGER [trg_update_etape_history]
GO
/****** Object:  Trigger [dbo].[trg_validAmm]    Script Date: 17/12/2020 15:30:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE TRIGGER [dbo].[trg_validAmm]   ON  [dbo].[Medicament]
   AFTER UPDATE
AS 
BEGIN

	SET NOCOUNT ON;

   DECLARE @Famille as nchar(50)
   DECLARE @Amm as nchar(50)
   DECLARE @nbAMM as int

   Select @Amm = MED_amm, @Famille = MED_codeFamille from inserted   

   if (@Amm is NOT NULL) 
   BEGIN 

   Select @nbAMM = COUNT(*) from Medicament where MED_amm IS NOT NULL AND MED_codeFamille = @Famille
   UPDATE Famille SET FAM_nbMediAmm = @nbAMM  WHERE FAM_code = @Famille
   END

END
GO
ALTER TABLE [dbo].[Medicament] ENABLE TRIGGER [trg_validAmm]
GO
/****** Object:  Trigger [dbo].[trg_insertWorkflow]    Script Date: 17/12/2020 15:30:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE TRIGGER [dbo].[trg_insertWorkflow]
   ON  [dbo].[Subir]
   AFTER Insert
AS 
BEGIN

	SET NOCOUNT ON;

DECLARE @depot as nchar(50)
DECLARE @etape as int

SELECT @depot = SUB_codeDepotLegal, @etape = SUB_numEtape from inserted

Update Medicament set MEDderniereEtape = @etape where MED_depotLegal = @depot

END
GO
ALTER TABLE [dbo].[Subir] ENABLE TRIGGER [trg_insertWorkflow]
GO
USE [master]
GO
ALTER DATABASE [GSB_gesAMM] SET  READ_WRITE 
GO
