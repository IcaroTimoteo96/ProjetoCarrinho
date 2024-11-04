# ProjetoCarrinho

O ProjetoCarrinho é um desafio técnico que foi gerado pelo ChatGPT. 

# Tarefa

O desafio solicitou a resolução de problemas de concorrência e integridade de dados no carrinho de compras, garantindo a escalabilidade do sistema e mantendo a performance em cenários de alta carga.

# Especificações Técnicas

Especificações Técnicas:
Tecnologia:

Utilize C# com ASP.NET Core para desenvolver uma solução.
Utilize Entity Framework Core para manipulação do banco de dados.
O banco de dados pode ser SQL Server ou SQLite.
Implemente Testes Unitários usando xUnit ou NUnit.
Entidades:

Carrinho:
ID (int)
UserId (int)
Itens (lista de objetos ItemCarrinho)
ItemCarrinho:
ProdutoId (int)
Quantidade (int)
PreçoUnitário (decimal)
Funcionalidades Requeridas:

Adicionar um item ao carrinho: Se o item já existir, deve apenas atualizar a quantidade.

Remover um item do carrinho.

Atualizar a quantidade de um item.

Obter todos os itens do carrinho.

Garantir que não ocorra duplicação de itens.

Evitar problemas de concorrência quando dois ou mais usuários tentarem modificar o mesmo item simultaneamente.

Garantir alta performance em cenários de concorrência (múltiplas requisições simultâneas).

Cenário realista: Considere que o sistema terá picos de usuários durante eventos de promoção, onde milhares de pessoas podem estar adicionando e atualizando seus carrinhos ao mesmo tempo.

Requisitos adicionais:

Implementar uma solução que previna duplicidade de itens no carrinho em um ambiente concorrente.
Garantir a integridade dos dados mesmo quando múltiplos usuários tentarem modificar o mesmo carrinho simultaneamente.
Use transações ou locks (otimista/pessimista) para garantir consistência.
Implemente Testes Unitários cobrindo os principais cenários, incluindo casos de concorrência.
O código deve ser escalável e eficiente, com foco em resolver os problemas reportados.

# Desenvolvimento
O que foi feito:

Adicionar um item ao carrinho: Se o item já existir, deve apenas atualizar a quantidade.
Remover um item do carrinho.
Atualizar a quantidade de um item.
Obter todos os itens do carrinho.

O que falta fazer:

Garantir que não ocorra duplicação de itens.
Testes Unitários usando xUnit ou NUnit.


