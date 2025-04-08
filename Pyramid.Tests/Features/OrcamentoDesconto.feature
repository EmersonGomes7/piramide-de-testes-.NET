@AcceptanceTests

Feature: Aplicação de desconto em orçamento
  cenario: Cliente com orçamento acima de 5000 recebe desconto
    Given um cliente chamado "joão"
    And ele adiciona um item chamado "celular" com valor 5500
    When o orçamento é verificado para desconto
    Then o orçamento deve ter desconto aplicado
