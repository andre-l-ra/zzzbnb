#                    ZzzBnb 

---
# Sistema de Gestão de Reservas de Hotéis e Pousadas 🛏️ 🏨 💻

## Visão Geral

Este projeto é um sistema de gestão de reservas de hotéis e pousadas, desenvolvido para permitir que os clientes façam reservas e para que os administradores gerenciem quartos, clientes e pagamentos. O sistema é construído usando ASP.NET Core 10, seguindo a arquitetura limpa e o Domain-Driven Design (DDD).

## Funcionalidades Principais

### 1. Gestão de Reservas

- **Criação de Reservas**: Permitir que clientes façam reservas.
- **Modificação de Reservas**: Permitir que clientes modifiquem suas reservas existentes.
- **Cancelamento de Reservas**: Permitir que clientes cancelem suas reservas.

### 2. Gestão de Quartos

- **Cadastro de Quartos**: Adicionar novos quartos com detalhes como tipo, preço, disponibilidade, etc.
- **Atualização de Quartos**: Modificar informações de quartos existentes.
- **Exclusão de Quartos**: Remover quartos do sistema.

### 3. Gestão de Clientes

- **Cadastro de Clientes**: Adicionar novos clientes ao sistema.
- **Atualização de Informações de Clientes**: Modificar informações de clientes existentes.
- **Histórico de Reservas**: Visualizar o histórico de reservas dos clientes.

### 4. Gestão de Pagamentos

- **Histórico de Pagamentos**: Manter um registro dos pagamentos feitos pelos clientes.

### 5. Relatórios e Análises

- **Relatórios de Ocupação**: Gerar relatórios sobre a ocupação dos quartos.
- **Relatórios Financeiros**: Gerar relatórios financeiros baseados nas reservas e pagamentos.
- **Análise de Tendências**: Analisar tendências de reservas e ocupação.

### 6. Autenticação e Autorização

- **Autenticação de Usuários**: Sistema de login para clientes e administradores.
- **Autorização de Acesso**: Controle de acesso baseado em roles (ex.: administrador, recepcionista, cliente).

## Tecnologias Utilizadas

- ASP.NET Core 10
- Entity Framework Core
- Mysql
- Swagger
- IdentityServer

## Bibliotecas Utilizadas

- AutoMapper
- FluentValidation
- MediaTR

## Arquitetura

Este projeto segue a arquitetura limpa e o Domain-Driven Design (DDD), garantindo uma separação clara entre as diferentes camadas e responsabilidades do sistema.

### Camadas do Sistema

- **Apresentação**: Contém os controladores e a interface do usuário.
- **Aplicação**: Contém os serviços de aplicação e os DTOs.
- **Domínio**: Contém as entidades, agregados, repositórios e regras de negócio.
- **Infraestrutura**: Contém a implementação dos repositórios, serviços externos e a configuração do banco de dados.

## Como Executar o Projeto

1. Clone o repositório:
   ```bash
   git clone https://github.com/seu-usuario/seu-repositorio.git


2. Navegue até o diretório do projeto::
   ```bash
   cd seu-repositorio

3. Restaure os pacotes NuGet:
   ```bash
   dotnet restore

4. Atualize o Banco de dados:
   ```bash
   dotnet ef database update

5. Execute o projeto:
   ```bash
   dotnet run

# Contribuição
## Contribuições são bem-vindas! ❤️ Sinta-se à vontade para abrir issues ou pull requests.



==Certifique-se de substituir os placeholders como ```https://github.com/seu-usuario/seu-repositorio.git``` pelo URL real do seu repositório e ajustar quaisquer detalhes específicos ao seu projeto.== 

---



# ZzzBnb
# Hotel and Guesthouse Reservation Management System

## Overview

This project is a hotel and guesthouse reservation management system, developed to allow customers to make reservations and for administrators to manage rooms, customers, and payments. The system is built using ASP.NET Core 10, following clean architecture and Domain-Driven Design (DDD).

## Main Features

### 1. Reservation Management

- **Create Reservations**: Allow customers to make reservations.
- **Modify Reservations**: Allow customers to modify their existing reservations.
- **Cancel Reservations**: Allow customers to cancel their reservations.

### 2. Room Management

- **Add Rooms**: Add new rooms with details such as type, price, availability, etc.
- **Update Rooms**: Modify existing room information.
- **Delete Rooms**: Remove rooms from the system.

### 3. Customer Management

- **Add Customers**: Add new customers to the system.
- **Update Customer Information**: Modify existing customer information.
- **Reservation History**: View the reservation history of customers.

### 4. Payment Management

- **Process Payments**: Integrate with payment gateways to process reservation payments.
- **Payment History**: Maintain a record of payments made by customers.

### 5. Reports and Analytics

- **Occupancy Reports**: Generate reports on room occupancy.
- **Financial Reports**: Generate financial reports based on reservations and payments.
- **Trend Analysis**: Analyze reservation and occupancy trends.

### 6. Authentication and Authorization

- **User Authentication**: Login system for customers and administrators.
- **Access Authorization**: Role-based access control (e.g., administrator, receptionist, customer).

## Technologies Used

- ASP.NET Core 10
- Entity Framework Core
- MySQL
- Swagger
- IdentityServer

## Libraries Used

- AutoMapper
- FluentValidation
- MediatR

## Architecture

This project follows clean architecture and Domain-Driven Design (DDD), ensuring a clear separation between different layers and system responsibilities.

### System Layers

- **Presentation**: Contains controllers and the user interface.
- **Application**: Contains application services and DTOs.
- **Domain**: Contains entities, aggregates, repositories, and business rules.
- **Infrastructure**: Contains repository implementations, external services, and database configuration.

## How to Run the Project

1. Clone the repository:
   ```bash
   git clone https://github.com/your-username/your-repository.git
