# Sistema de Sorteio de Equipes e Temas

Um sistema web desenvolvido em ASP.NET 9 Core com Razor Pages para automatizar o sorteio de equipes e a atribuição de temas para trabalhos em grupo.

## Sobre o Projeto

Este sistema permite cadastrar pessoas e temas, e então realizar sorteios automáticos que distribuem os participantes em equipes de forma equilibrada e atribuem temas aleatoriamente. Ideal para professores, coordenadores de projetos e qualquer pessoa que precise organizar grupos de trabalho de forma justa e eficiente.

## Funcionalidades Principais

- **Cadastro de Pessoas**: Interface intuitiva para registrar participantes com nome, idade e endereço
- **Cadastro de Temas**: Formulário para adicionar temas com nome e descrição detalhada
- **Sorteio Automático**: Algoritmo que distribui pessoas em equipes de forma equilibrada
- **Atribuição de Temas**: Associação aleatória de temas às equipes formadas
- **Interface Responsiva**: Design moderno que se adapta a diferentes dispositivos

## Tecnologias Utilizadas

- ASP.NET Core MVC
- Razor Pages
- Bootstrap 5
- JavaScript para validações em tempo real
- CSS personalizado para elementos visuais

## Destaques do Projeto

- **Algoritmo de Distribuição Equilibrada**: Garante que a diferença no número de pessoas entre equipes seja no máximo 1
- **Validação em Tempo Real**: Feedback visual imediato nos formulários
- **Design Moderno**: Interface com cards, sombras e elementos visuais atrativos
- **Política de Privacidade Detalhada**: Informações claras sobre o tratamento de dados

## Como Usar

1. Instale o .NET 9 SDK
Se ainda não estiver instalado em sua máquina, faça o download em:
https://dotnet.microsoft.com/download/dotnet/9.0
2. Clone o repositório
3. Abra o projeto no Visual Studio Code ou editor de sua preferência
4. Use o Comando Dotnet watch no terminal
4. Cadastre pessoas e temas através dos formulários
5. Configure o número de equipes desejado e realize o sorteio
6. Visualize os resultados com as equipes formadas e temas atribuídos
