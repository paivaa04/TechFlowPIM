TechFlow Solutions
Sistema de gestão de chamados de suporte técnico desenvolvido para otimizar o fluxo de atendimento entre colaboradores e técnicos.

🚀 Sobre o Projeto
O TechFlow é uma aplicação Desktop desenvolvida em C# (.NET) com o objetivo de centralizar a abertura e o acompanhamento de tickets de suporte. O sistema conta com autenticação segura, controle de acesso baseado em perfis (Técnico/Colaborador) e persistência de dados utilizando Entity Framework.

🛠️ Tecnologias Utilizadas
Linguagem: C# (.NET)

Interface: Windows Forms

Banco de Dados: SQL Server

ORM: Entity Framework

Segurança: Criptografia de senhas (Password Hashing)

🏗️ Estrutura do Sistema
Models: Entidades do sistema (Login, Chamados, Sessão).

Db: Camada de acesso a dados (CRUDs e regras de negócio do banco).

UI: Interfaces gráficas do usuário.

⚙️ Como executar
Certifique-se de ter o SQL Server instalado.

Execute o script SQL disponível na pasta /scripts para criar o banco de dados TechFlow.

Configure a Connection String no seu AppDbContext para apontar para o seu servidor local.

Abra a solução no Visual Studio e execute o projeto.

👤 Desenvolvedor
Matheus Emanuel de Paiva

