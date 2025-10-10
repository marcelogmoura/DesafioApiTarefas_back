# 🚀 Desafio Técnico - API de Gerenciamento de Tarefas

[![C#](https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=c-sharp&logoColor=white)](https://docs.microsoft.com/pt-br/dotnet/csharp/)
[![.NET Core 9.0](https://img.shields.io/badge/.NET_9.0-512BD4?style=for-the-badge&logo=dotnet&logoColor=white)](https://dotnet.microsoft.com/en-us/download/dotnet/9.0)
[![ASP.NET Core](https://img.shields.io/badge/ASP.NET_Core-512BD4?style=for-the-badge&logo=dot-net&logoColor=white)](https://dotnet.microsoft.com/pt-br/apps/aspnet)
[![SQL Server](https://img.shields.io/badge/SQL_Server-CC2927?style=for-the-badge&logo=microsoft-sql-server&logoColor=white)](https://www.microsoft.com/pt-br/sql-server)
[![Entity Framework Core](https://img.shields.io/badge/EF_Core-512BD4?style=for-the-badge&logo=dot-net&logoColor=white)](https://docs.microsoft.com/pt-br/ef/core/)
[![Swagger](https://img.shields.io/badge/Swagger/OpenAPI-85EA2D?style=for-the-badge&logo=swagger&logoColor=black)](https://swagger.io/)
[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)

> Este projeto é uma API RESTful para gerenciamento de tarefas, desenvolvida em **ASP.NET Core 9.0** como um desafio técnico. Focada em **Clean Code** e **SOLID**, a API oferece um CRUD completo para a entidade Tarefa.

## 📄 Enunciado do Desafio

O enunciado completo do desafio técnico está disponível para consulta.

* **Arquivo Local:** O PDF original está na pasta `Pdf` deste repositório.
* **Link Direto:** [DesafioApiTarefas.pdf](https://github.com/marcelogmoura/DesafioApiTarefas_back/blob/main/Pdf/DesafioApiTarefas.pdf)

---

---

## 💻 Tecnologias Utilizadas

* **.NET Core 9.0** (Target Framework)
* **C#**
* **ASP.NET Core Web API**
* **Entity Framework Core** para persistência de dados.
* **SQL Server** como banco de dados.
* **FluentValidation** para regras de negócio e validação de dados.
* **Swagger (OpenAPI)** para documentação e testes interativos da API.
* **Git** para controle de versão.

---

## ✨ Requisitos Funcionais

A API implementa o **CRUD (Create, Read, Update, Delete)** para tarefas, com os seguintes recursos:

* ✅ **Cadastro de Tarefas:** Campos como Título, Descrição, Status e Data de Conclusão.
* ✅ **Listagem de Tarefas:** Permite listar todas as tarefas cadastradas.
* ✅ **Atualização de Tarefas:** Edição de dados de uma tarefa específica.
* ✅ **Exclusão de Tarefas:** Remove uma tarefa pelo seu ID.
* ✅ **Validação de Dados:** O Título é obrigatório, e a Data de Conclusão não pode ser anterior à Data de Criação (validado via FluentValidation).
* ✅ **Tratamento de Erros:** Respostas HTTP apropriadas (`200`, `201`, `400`, `404`, `500`).

---

## 🚀 Como Executar o Projeto

### Pré-requisitos

* **.NET SDK 9.0** instalado na máquina.
* **SQL Server** (a string de conexão atual aponta para o LocalDB).
* **Ferramenta de Desenvolvimento:** Visual Studio 2022 ou VS Code.

### Passos para Rodar Localmente

1.  **Clone o repositório:**
    ```bash
    git clone [https://github.com/marcelogmoura/DesafioApiTarefas_back.git](https://github.com/marcelogmoura/DesafioApiTarefas_back.git)
    cd DesafioApiTarefas_back
    ```

2.  **Configure a Conexão:**
    * Verifique a *connection string* no arquivo `DesafioApiTarefas.Infra/Contexts/ApiContext.cs` ou ajuste no `appsettings.json` do projeto da API.

3.  **Execute as Migrações:**
    * Garanta que o banco de dados e as tabelas sejam criadas (usando EF Core Migrations):
    ```bash
    dotnet ef database update --project DesafioApiTarefas.Infra --startup-project DesafioApiTarefas.API
    ```

4.  **Execute a API:**
    ```bash
    dotnet run --project DesafioApiTarefas.API/DesafioApiTarefas.API.csproj
    ```

5.  **Acesse a Documentação Swagger:**
    * A API estará documentada e pronta para testes no seu navegador:
    `http://localhost:5070/swagger` (Verifique a porta no `launchSettings.json`).

---

## 🧪 Testes

* A interface do **Swagger** (`/swagger`) é a maneira mais rápida de testar os endpoints do CRUD (Criação, Leitura, Atualização, Exclusão).
* Recomenda-se utilizar ferramentas como **Postman** ou **Insomnia** para testes mais detalhados e validação dos *Status Codes*.

---

## 📽 Vídeo Demonstrativo

Foi criado um vídeo demonstrando o funcionamento do Frontend (se houver) se comunicando com o Backend, incluindo uma breve explicação das funcionalidades implementadas e a **arquitetura adotada** no projeto.

---

## 🧑‍💻 Autor

| Autor | GitHub | LinkedIn | Email |
| :---: | :---: | :---: | :---: |
| **Marcelo Moura** | [![GitHub Badge](https://img.shields.io/badge/-GitHub-100000?style=for-the-badge&logo=github&logoColor=white)](https://github.com/marcelogmoura) | [![LinkedIn Badge](https://img.shields.io/badge/-LinkedIn-0A66C2?style=for-the-badge&logo=linkedin&logoColor=white)](https://linkedin.com/in/marcelogmoura) | `mgmoura@gmail.com` |

---

Desenvolvido por Marcelo Moura © 2025
