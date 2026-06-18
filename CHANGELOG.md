# Changelog

Todos os mudanças relevantes deste projeto são documentadas aqui.

O formato segue o [Keep a Changelog](https://keepachangelog.com/pt-BR/1.1.0/),
e o projeto adere ao [Versionamento Semântico](https://semver.org/lang/pt-BR/).

## [Unreleased]

### Adicionado
- Modelagem de domínio (DDD): agregado `Client`, entidades `Reservation`, `Room`,
  `Payment`, Value Object `Address`, eventos e exceções de domínio.
- Estrutura de solução em camadas (Domain, Application, Infrastructure).

### Pendente (roadmap)
- Camada de Application com CQRS + MediatR.
- Persistência com Entity Framework Core + migrations (PostgreSQL).
- API REST com endpoints e documentação Swagger/OpenAPI.
- Autenticação e autorização (JWT).
- Testes automatizados (xUnit).
- Containerização (Docker + docker-compose).

### Infraestrutura de projeto
- `.gitignore` para .NET (remoção de artefatos de build do versionamento).
- Licença MIT, guia de contribuição e este changelog.
