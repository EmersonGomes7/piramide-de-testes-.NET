- Sistema de Orçamento simples

1- Propósito do Projeto

Este projeto simula a criação e validação de orçamentos para clientes,
aplicando os princípios da pirâmide de testes com .NET. por meio de testes automatizados.

------------------------------------------------------------

2- Entidades e Funcionalidades

2.1 Cliente
- Nome do cliente
- Lista de orçamentos associados

2.2 Orçamento
- ID do orçamento
- Lista de itens (nome e preço)
- Valor total do orçamento

2.3 Funcionalidades:
- Adicionar item ao orçamento
- Remover item do orçamento
- Validar se o orçamento é válido (valor total > 0)
- Aplicar desconto de 10% se o valor total for superior a R$ 5.000

---------------------------------------------------------

 Cobertura de Código

O projeto utiliza Coverlet para medir a cobertura de código e atingiu 96% de cobertura.

----------------------------------------------------------

 Como Executar o Projeto Localmente:

Pré-requisitos
- .NET 8 ou mais instalado
- terminal

Clonar o Repositório

Restaurar e Compilar:

dotnet restore
dotnet build

para rodar os 
Testes Unitários, Integração, sistema e aceitação:

dotnet test Pyramid.Tests/Pyramid.Tests.csproj

----------------------------------------------------------

jpara gerar o relatório de cobertura de código e visualizar no navegador: 
  
Instale o ReportGenerator 

dotnet tool install --global dotnet-reportgenerator-globaltool

Gerar o relatório:

reportgenerator -reports:"Pyramid.Tests\TestResults\*\coverage.cobertura.xml" -targetdir:coverage-report -reporttypes:Html

Abra no navegador:

start coverage-report/index.html

-----------------------------------------------------------

Tecnologias Utilizadas:
.NET 9
xUnit para testes unitários
SpecFlow para testes de aceitação
Coverlet para análise de cobertura
ReportGenerator para relatório em HTML
