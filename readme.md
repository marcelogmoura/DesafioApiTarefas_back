# ?? Desafio T�cnico - API de Gerenciamento de Tarefas

[![C#](https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=c-sharp&logoColor=white)](https://docs.microsoft.com/pt-br/dotnet/csharp/)
[![.NET Core 9.0](https://img.shields.io/badge/.NET_9.0-512BD4?style=for-the-badge&logo=dotnet&logoColor=white)](https://dotnet.microsoft.com/en-us/download/dotnet/9.0)
[![ASP.NET Core](https://img.shields.io/badge/ASP.NET_Core-512BD4?style=for-the-badge&logo=dot-net&logoColor=white)](https://dotnet.microsoft.com/pt-br/apps/aspnet)
[![SQL Server](https://img.shields.io/badge/SQL_Server-CC2927?style=for-the-badge&logo=microsoft-sql-server&logoColor=white)](https://www.microsoft.com/pt-br/sql-server)
[![Entity Framework Core](https://img.shields.io/badge/EF_Core-512BD4?style=for-the-badge&logo=dot-net&logoColor=white)](https://docs.microsoft.com/pt-br/ef/core/)
[![Swagger](https://img.shields.io/badge/Swagger/OpenAPI-85EA2D?style=for-the-badge&logo=swagger&logoColor=black)](https://swagger.io/)
[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)

> Este projeto � uma API RESTful para gerenciamento de tarefas, desenvolvida em **ASP.NET Core 9.0** como um desafio t�cnico. Focada em **Clean Code** e **SOLID**, a API oferece um CRUD completo para a entidade Tarefa.

## ?? Enunciado do Desafio

O enunciado completo do desafio t�cnico est� dispon�vel para consulta.

* **Arquivo Local:** O PDF original est� na pasta `Pdf` deste reposit�rio.
* **Link Direto:** [DesafioApiTarefas.pdf](https://github.com/marcelogmoura/DesafioApiTarefas_back/blob/main/Pdf/DesafioApiTarefas.pdf)

---

---

## ?? Tecnologias Utilizadas

* **.NET Core 9.0** (Target Framework)
* **C#**
* **ASP.NET Core Web API**
* **Entity Framework Core** para persist�ncia de dados.
* **SQL Server** como banco de dados.
* **FluentValidation** para regras de neg�cio e valida��o de dados.
* **Swagger (OpenAPI)** para documenta��o e testes interativos da API.
* **Git** para controle de vers�o.

---

## ? Requisitos Funcionais

A API implementa o **CRUD (Create, Read, Update, Delete)** para tarefas, com os seguintes recursos:

* ? **Cadastro de Tarefas:** Campos como T�tulo, Descri��o, Status e Data de Conclus�o.
* ? **Listagem de Tarefas:** Permite listar todas as tarefas cadastradas.
* ? **Atualiza��o de Tarefas:** Edi��o de dados de uma tarefa espec�fica.
* ? **Exclus�o de Tarefas:** Remove uma tarefa pelo seu ID.
* ? **Valida��o de Dados:** O T�tulo � obrigat�rio, e a Data de Conclus�o n�o pode ser anterior � Data de Cria��o (validado via FluentValidation).
* ? **Tratamento de Erros:** Respostas HTTP apropriadas (`200`, `201`, `400`, `404`, `500`).

---

## ?? Como Executar o Projeto

### Pr�-requisitos

* **.NET SDK 9.0** instalado na m�quina.
* **SQL Server** (a string de conex�o atual aponta para o LocalDB).
* **Ferramenta de Desenvolvimento:** Visual Studio 2022 ou VS Code.

### Passos para Rodar Localmente

1.  **Clone o reposit�rio:**
    ```bash
    git clone [https://github.com/marcelogmoura/DesafioApiTarefas_back.git](https://github.com/marcelogmoura/DesafioApiTarefas_back.git)
    cd DesafioApiTarefas_back
    ```

2.  **Configure a Conex�o:**
    * Verifique a *connection string* no arquivo `DesafioApiTarefas.Infra/Contexts/ApiContext.cs` ou ajuste no `appsettings.json` do projeto da API.

3.  **Execute as Migra��es:**
    * Garanta que o banco de dados e as tabelas sejam criadas (usando EF Core Migrations):
    ```bash
    dotnet ef database update --project DesafioApiTarefas.Infra --startup-project DesafioApiTarefas.API
    ```

4.  **Execute a API:**
    ```bash
    dotnet run --project DesafioApiTarefas.API/DesafioApiTarefas.API.csproj
    ```

5.  **Acesse a Documenta��o Swagger:**
    * A API estar� documentada e pronta para testes no seu navegador:
    `http://localhost:5070/swagger` (Verifique a porta no `launchSettings.json`).

---

## ?? Testes

* A interface do **Swagger** (`/swagger`) � a maneira mais r�pida de testar os endpoints do CRUD (Cria��o, Leitura, Atualiza��o, Exclus�o).
* Recomenda-se utilizar ferramentas como **Postman** ou **Insomnia** para testes mais detalhados e valida��o dos *Status Codes*.


---

## ????? Autor

| Autor | GitHub | LinkedIn | Email |
| :---: | :---: | :---: | :---: |
| **Marcelo Moura** | [![GitHub Badge](https://img.shields.io/badge/-GitHub-100000?style=for-the-badge&logo=github&logoColor=white)](https://github.com/marcelogmoura) | [![LinkedIn Badge](https://img.shields.io/badge/-LinkedIn-0A66C2?style=for-the-badge&logo=linkedin&logoColor=white)](https://linkedin.com/in/marcelogmoura) | `mgmoura@gmail.com` |

---

Desenvolvido por Marcelo Moura � 2025
