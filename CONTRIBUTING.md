# Guia de Contribuição

Obrigado pelo interesse em contribuir com o **ZzzBnb**! 🙌

## Como contribuir

1. Faça um *fork* do repositório.
2. Crie uma branch a partir de `develop`:
   ```bash
   git checkout -b feature/minha-feature
   ```
3. Faça commits pequenos e descritivos seguindo
   [Conventional Commits](https://www.conventionalcommits.org/pt-br/):
   - `feat:` nova funcionalidade
   - `fix:` correção de bug
   - `refactor:` refatoração sem mudança de comportamento
   - `test:` adição/ajuste de testes
   - `docs:` documentação
4. Garanta que o build e os testes passam:
   ```bash
   dotnet build
   dotnet test
   ```
5. Abra um *Pull Request* para `develop` descrevendo a motivação e as mudanças.

## Padrões de código

- Siga as convenções de C# / .NET e os princípios SOLID.
- Mantenha a separação de camadas (Domain, Application, Infrastructure, API).
- Regras de negócio pertencem ao domínio, não aos controllers.
- Não versione artefatos de build (`bin/`, `obj/`) nem segredos.

## Reportando problemas

Abra uma *issue* descrevendo o comportamento esperado, o observado e os passos
para reproduzir.
