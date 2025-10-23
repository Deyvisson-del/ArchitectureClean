# Meu 1� Projeto em Clean Architecture (Em desenvolvimento...)
## _Gerenciador de frequ�ncias de estagi�rios_

## Configuration
## Stacks
[![My Skills](https://skillicons.dev/icons?i=html,css,js)](https://skillicons.dev) 
[![My Skills](https://skillicons.dev/icons?i=cs,dotnet,mysql,docker)](https://skillicons.dev)

## Tecnologias Utilizadas

- NET 8/ ASP.NET Core MVC
- Entity Framework Core 8.0.21
- Entity Framework Core Design 8.0.21
- Entity Framework Core Tools 8.0.21
- Microsoft Extensions Configuration 8.0.0
- Microsoft Extensions Configuration FileExtensions 8.0.1
- Microsoft Extensions Configuration Json 8.0.1
- Pomelo.EntityFrameworkCore.MySql
- Docker version 28.4.0

## Arquitetura do Projeto

?? **ArchitectureClean.sln** </br>
?? ?? **ArchitectureClean.Domain** ? Entidades e interfaces  
?? ?? **ArchitectureClean.Application** ? Casos de uso e DTOs  
?? ??? **ArchitectureClean.Infra.Data** ? DbContext e Reposit�rios  
?  ?? Context ? `AppDbContext.cs`  
?  ?? Migrations  
?  ?? Repositories  
?? ?? **ArchitectureClean.Infra.IoC** ? Configura��o de DI  
?  ?? `DependencyInjection.cs`  
?? ?? **ArchitectureClean.MVC** ? Apresenta��o  
   ?? `appsettings.json`  
   ?? `Program.cs`  
   ?? Controllers/



## Instala��o e Configura��o
```sh
git clone https://github.com/Deyvisson-del/ArchitectureClean.git

cd ArchitectureClean

````
