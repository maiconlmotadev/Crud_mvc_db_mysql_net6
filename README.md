
CRUD MVC usando o novo .NET6 com visual studio 2022. 


Pacotes instalados
Install-Package Microsoft.EntityFrameworkCore
Install-Package Microsoft.EntityFrameworkCore.Design
Install-Package Pomelo.EntityFrameworkCore.MySql

Comandos do Migration executados para criação do banco
Add-Migration Criacao-Inicial -Context Contexto
Update-Database -Context Contexto
