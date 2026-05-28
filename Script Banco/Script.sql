-- Garante que estamos no seu banco de dados correto
USE [TechFlow] 
GO

-- Limpa tudo primeiro para evitar erros de "já existe"
IF OBJECT_ID('dbo.FK_Chamados_Usuarios', 'F') IS NOT NULL ALTER TABLE [dbo].[Chamados] DROP CONSTRAINT [FK_Chamados_Usuarios]
GO
IF OBJECT_ID('dbo.Chamados', 'U') IS NOT NULL DROP TABLE [dbo].[Chamados]
GO
IF OBJECT_ID('dbo.Usuarios', 'U') IS NOT NULL DROP TABLE [dbo].[Usuarios]
GO

-- Cria a tabela Usuarios com os tipos CORRIGIDOS
CREATE TABLE [dbo].[Usuarios](
    [Id] [int] IDENTITY(1,1) NOT NULL,
    [Nome] [varchar](50) NOT NULL,
    [Usuario] [varchar](50) NOT NULL,
    [Email] [varchar](100) NOT NULL,
    [Senha] [nvarchar](max) NOT NULL,  -- CORRIGIDO: Aceita o Hash completo
    [TipoUsuario] [int] NOT NULL,      -- CORRIGIDO: Compatível com o seu C#
 CONSTRAINT [PK_Usuario] PRIMARY KEY CLUSTERED ([Id] ASC)
) ON [PRIMARY]
GO

-- Cria a tabela Chamados
CREATE TABLE [dbo].[Chamados](
    [Id] [int] IDENTITY(1,1) NOT NULL,
    [IdUsuario] [int] NOT NULL,
    [Nome] [varchar](50) NOT NULL,
    [Email] [varchar](150) NOT NULL,
    [Setor] [varchar](100) NOT NULL,
    [Assunto] [varchar](200) NOT NULL,
    [Descricao] [varchar](max) NOT NULL,
    [DataAbertura] [datetime] NOT NULL,
    [Prioridade] [bit] NOT NULL,
    [Status] [varchar](30) NOT NULL,
 CONSTRAINT [PK__Chamados__3214EC072593DEF5] PRIMARY KEY CLUSTERED ([Id] ASC)
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

-- Adiciona os Defaults e a Chave Estrangeira
ALTER TABLE [dbo].[Chamados] ADD CONSTRAINT [DF__Chamados__DataAb__693CA210] DEFAULT (getdate()) FOR [DataAbertura]
ALTER TABLE [dbo].[Chamados] ADD CONSTRAINT [DF__Chamados__Priori__6A30C649] DEFAULT ((0)) FOR [Prioridade]
ALTER TABLE [dbo].[Chamados] ADD DEFAULT ('Em Aberto') FOR [Status]
ALTER TABLE [dbo].[Chamados] WITH CHECK ADD CONSTRAINT [FK_Chamados_Usuarios] FOREIGN KEY([IdUsuario]) REFERENCES [dbo].[Usuarios] ([Id])
GO