USE [Agency]
GO
/****** Object:  Table [dbo].[agents]    Script Date: 12.02.2024 14:09:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[agents](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [nvarchar](50) NOT NULL,
	[MiddleName] [nvarchar](50) NOT NULL,
	[LastName] [nvarchar](50) NOT NULL,
	[DealShare] [int] NULL,
 CONSTRAINT [PK_agents] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[clients]    Script Date: 12.02.2024 14:09:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[clients](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [nvarchar](50) NULL,
	[MiddleName] [nvarchar](50) NULL,
	[LastName] [nvarchar](50) NULL,
	[Phone] [nvarchar](50) NULL,
	[Email] [nvarchar](50) NULL,
 CONSTRAINT [PK_clients_1] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[agents] ON 

INSERT [dbo].[agents] ([Id], [FirstName], [MiddleName], [LastName], [DealShare]) VALUES (1, N'Фахрутдинов', N'Роман', N'Рубинович', 20)
INSERT [dbo].[agents] ([Id], [FirstName], [MiddleName], [LastName], [DealShare]) VALUES (4, N'Устинов', N'Максим', N'Алексеевич', 40)
INSERT [dbo].[agents] ([Id], [FirstName], [MiddleName], [LastName], [DealShare]) VALUES (7, N'Сысоева', N'Людмила', N'Валентиновна', 45)
INSERT [dbo].[agents] ([Id], [FirstName], [MiddleName], [LastName], [DealShare]) VALUES (9, N'Додонов', N'Илья', N'Геннадьевич', 45)
INSERT [dbo].[agents] ([Id], [FirstName], [MiddleName], [LastName], [DealShare]) VALUES (11, N'Мухтаруллин', N'Руслан', N'Расыхович', 45)
INSERT [dbo].[agents] ([Id], [FirstName], [MiddleName], [LastName], [DealShare]) VALUES (13, N'Мосеева', N'Любовь', N'Александровна', 45)
INSERT [dbo].[agents] ([Id], [FirstName], [MiddleName], [LastName], [DealShare]) VALUES (15, N'Киселев', N'Алексей', N'Геннадьевич', 45)
INSERT [dbo].[agents] ([Id], [FirstName], [MiddleName], [LastName], [DealShare]) VALUES (19, N'Клюйков', N'Евгений', N'Николаевич', 50)
INSERT [dbo].[agents] ([Id], [FirstName], [MiddleName], [LastName], [DealShare]) VALUES (24, N'Жданова', N'Галина', N'Николаевна', 45)
INSERT [dbo].[agents] ([Id], [FirstName], [MiddleName], [LastName], [DealShare]) VALUES (34, N'Басырова', N'Елена', N'Азатовна', 45)
INSERT [dbo].[agents] ([Id], [FirstName], [MiddleName], [LastName], [DealShare]) VALUES (37, N'Швецов', N'Виталий', N'Олегович', 45)
SET IDENTITY_INSERT [dbo].[agents] OFF
GO
SET IDENTITY_INSERT [dbo].[clients] ON 

INSERT [dbo].[clients] ([id], [FirstName], [MiddleName], [LastName], [Phone], [Email]) VALUES (2, N'Семенов', N'Евгений ', N'Николаевич', N'32-25-55', NULL)
INSERT [dbo].[clients] ([id], [FirstName], [MiddleName], [LastName], [Phone], [Email]) VALUES (3, N'Денисова', N'Олеся', N'Леонидовна', NULL, N'dummy@email.ru')
INSERT [dbo].[clients] ([id], [FirstName], [MiddleName], [LastName], [Phone], [Email]) VALUES (5, N'Сафронов', N'Алексей', N'Вячеславович', NULL, N'client@esoft.tech')
INSERT [dbo].[clients] ([id], [FirstName], [MiddleName], [LastName], [Phone], [Email]) VALUES (6, N'Кудряшов', N'Александр', N'Витальевич', N'551988', NULL)
INSERT [dbo].[clients] ([id], [FirstName], [MiddleName], [LastName], [Phone], [Email]) VALUES (8, N'Фёдоров', N'Алексей', N'Николаевич', NULL, N'fedorov@mail.ru')
INSERT [dbo].[clients] ([id], [FirstName], [MiddleName], [LastName], [Phone], [Email]) VALUES (10, N'Пелымская', N'Светлана', N'Александровна', N'83452112233', NULL)
INSERT [dbo].[clients] ([id], [FirstName], [MiddleName], [LastName], [Phone], [Email]) VALUES (12, N'Коновальчик', N'Татьяна', N'Геннадьевна', NULL, N'dummy@email.ru')
INSERT [dbo].[clients] ([id], [FirstName], [MiddleName], [LastName], [Phone], [Email]) VALUES (14, N'Молоковская', N'Светлана', N'Михайловна', N'898489848', NULL)
INSERT [dbo].[clients] ([id], [FirstName], [MiddleName], [LastName], [Phone], [Email]) VALUES (16, N'Моторина', N'Анастасия', N'Сергеевна', N'895159848', NULL)
INSERT [dbo].[clients] ([id], [FirstName], [MiddleName], [LastName], [Phone], [Email]) VALUES (17, N'Поспелова', N'Ольга', N'Александровна', NULL, N'angel@mail.ru')
INSERT [dbo].[clients] ([id], [FirstName], [MiddleName], [LastName], [Phone], [Email]) VALUES (18, N'Жиляков', N'Владимир', N'Владимирович', N'445588', N'445588@email.ru')
INSERT [dbo].[clients] ([id], [FirstName], [MiddleName], [LastName], [Phone], [Email]) VALUES (20, N'Ефремов', N'Владислав', N'Николаевич', NULL, N'parampampam@mail.ru')
INSERT [dbo].[clients] ([id], [FirstName], [MiddleName], [LastName], [Phone], [Email]) VALUES (21, N'Баль', N'Валентина', N'Сергеевна', N'+7998888444', NULL)
INSERT [dbo].[clients] ([id], [FirstName], [MiddleName], [LastName], [Phone], [Email]) VALUES (22, N'Стрелков', N'Артем', N'Николаевич', NULL, N'test@test.test')
INSERT [dbo].[clients] ([id], [FirstName], [MiddleName], [LastName], [Phone], [Email]) VALUES (23, N'Луканин', N'Павел', N'Валерьевич', NULL, N'foo@bar.ru')
INSERT [dbo].[clients] ([id], [FirstName], [MiddleName], [LastName], [Phone], [Email]) VALUES (25, N'Шарипова', N'Эльвира', N'Закирчановна', N'12345678910', NULL)
INSERT [dbo].[clients] ([id], [FirstName], [MiddleName], [LastName], [Phone], [Email]) VALUES (26, N'Фомина', N'Маргарита', N'Николаевна', NULL, N'fomina@email.ru')
INSERT [dbo].[clients] ([id], [FirstName], [MiddleName], [LastName], [Phone], [Email]) VALUES (27, N'Кремлев', N'Владислав', N'Юрьевич', N'777', N'kremlevvu@gmail.ru')
INSERT [dbo].[clients] ([id], [FirstName], [MiddleName], [LastName], [Phone], [Email]) VALUES (28, N'Пономарева', N'Елена', N'Сергеевна', NULL, N'ponomareva@gmail.ru')
INSERT [dbo].[clients] ([id], [FirstName], [MiddleName], [LastName], [Phone], [Email]) VALUES (29, N'Шелест', N'Тамара', N'Васильевна', N'112', NULL)
INSERT [dbo].[clients] ([id], [FirstName], [MiddleName], [LastName], [Phone], [Email]) VALUES (30, N'Шарипов', N'Рустам', N'Владимирович', NULL, N'sharipov@yandex.ru')
INSERT [dbo].[clients] ([id], [FirstName], [MiddleName], [LastName], [Phone], [Email]) VALUES (31, N'Романов', N'Сергей', N'Федорович', N'02', NULL)
INSERT [dbo].[clients] ([id], [FirstName], [MiddleName], [LastName], [Phone], [Email]) VALUES (32, N'Кручинин', N'Иван', N'Андреевич', NULL, N'kruch@list.ru')
INSERT [dbo].[clients] ([id], [FirstName], [MiddleName], [LastName], [Phone], [Email]) VALUES (33, N'Алферов', N'Алексей', N'Николаевич', N'+688899444', NULL)
INSERT [dbo].[clients] ([id], [FirstName], [MiddleName], [LastName], [Phone], [Email]) VALUES (35, N'Попов ', N'Алексей', N'Николаевич', N'+0489848565', N'popovan@bik.ru')
INSERT [dbo].[clients] ([id], [FirstName], [MiddleName], [LastName], [Phone], [Email]) VALUES (36, N'Неезжала', N'Наталья', N'Леонидовна', NULL, N'neez@mail.ru')
INSERT [dbo].[clients] ([id], [FirstName], [MiddleName], [LastName], [Phone], [Email]) VALUES (37, N'Глеб', N'Зуев', N'Сергеевич', N'айпхон11', N'')
SET IDENTITY_INSERT [dbo].[clients] OFF
GO
/****** Object:  StoredProcedure [dbo].[AddAgent]    Script Date: 12.02.2024 14:09:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[AddAgent]
@name nvarchar(50),
@family nvarchar(50),
@lastname nvarchar(50),
@comission int
AS
BEGIN
INSERT INTO agents(FirstName,MiddleName,LastName,DealShare)
VALUES (@name,@family,@lastname,@comission)
END
GO
/****** Object:  StoredProcedure [dbo].[AddClient]    Script Date: 12.02.2024 14:09:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[AddClient]
@name nvarchar(50),
@family nvarchar(50),
@lastname nvarchar(50),
@telephone nvarchar(50),
@email nvarchar(50)
AS
BEGIN
INSERT INTO clients(FirstName,MiddleName,LastName,Phone,Email)
VALUES (@name,@family,@lastname,@telephone,@email)
END
GO
/****** Object:  StoredProcedure [dbo].[DelAgent]    Script Date: 12.02.2024 14:09:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[DelAgent]
@id  int
AS
BEGIN
DELETE agents
WHERE Id = @id
END
GO
/****** Object:  StoredProcedure [dbo].[DelClient]    Script Date: 12.02.2024 14:09:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[DelClient]
@id  int
AS
BEGIN
DELETE clients
WHERE Id = @id
END
GO
/****** Object:  StoredProcedure [dbo].[RedacteAgent]    Script Date: 12.02.2024 14:09:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[RedacteAgent]
@id  int,
@name nvarchar(50),
@family nvarchar(50),
@lastname nvarchar(50),
@comission int
AS
BEGIN
UPDATE agents
SET FirstName = @name,MiddleName=@family,LastName = @lastname, DealShare = @comission
WHERE Id = @id
END
GO
/****** Object:  StoredProcedure [dbo].[RedacteClient]    Script Date: 12.02.2024 14:09:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[RedacteClient]
@id  int,
@name nvarchar(50),
@family nvarchar(50),
@lastname nvarchar(50),
@telephone nvarchar(50),
@email nvarchar(50)
AS
BEGIN
UPDATE clients
SET FirstName = @name, MiddleName = @family, LastName = @lastname, Phone = @telephone, Email = @email
WHERE Id = @id
END
GO
