# Agendamento de Consultas
Descrição
Este projeto é um sistema de agendamento de consultas para clínicas veterinárias. O objetivo é permitir que os clientes marquem, cancelem ou reagendem consultas online, além de receber notificações automáticas para lembrar das consultas. O sistema também oferece uma visualização de calendário para os veterinários, ajudando a evitar conflitos de horários.

## Funcionalidades

### Clientes:

-   Cadastro e edição de perfil
-   Verificação da disponibilidade de horários
-   Marcar, desmarcar e reagendar consultas

### Secretárias:

- Cadastro, edição e exclusão de clientes e veterinários
- Visualização completa da agenda de consultas

### Veterinários:

- Visualização da própria agenda
- Acesso aos detalhes das consultas, incluindo o nome dos clientes

### Consultas:

- Registro de consultas com dia, cliente, pet e veterinário
### Pets:

- Cadastro de pets vinculados a clientes

## Requisitos
- .NET 6.0
- Visual Studio 2022 (ou outra IDE compatível)
- SQL Server (ou outro banco de dados compatível)
- Twilio (para envio de notificações SMS)
- SendGrid (para envio de notificações por e-mail)
## Instalação
### Pré-requisitos
- Instalar o .NET 6.0 SDK: Download .NET 6.0
- Instalar o Visual Studio 2022: Download Visual Studio 2022
- Configurar o SQL Server: Download SQL Server
- Registrar-se no Twilio: Twilio
- Registrar-se no SendGrid: SendGrid
### Clonar o Repositório

```bash
git clone https://github.com/seu-usuario/AgendarConsultas.git
cd AgendarConsultas
```
### Configurar o Banco de Dados
Crie o banco de dados no SQL Server.
Configure a string de conexão no arquivo appsettings.json:

```json
"ConnectionStrings": {
  "ScheduleContext": "Data Source=Schedule.db"
}
```

### Executar as Migrações do Entity Framework

```bash
dotnet ef database update
```

### Executar as Migrações do Entity Framework

```bash
dotnet run
```

## Uso
- Acesse a aplicação: http://localhost:5000
