# Desafios de Código Básico C# - Coding The Future Avanade - .NET Developer - DIO
- Desafio de Código proposto em um BootCamp da plataforma do site DIO, o qual nos faz rever o código e complementa-lo para que ele alcance os objetivos solicitados.

## Desafio 1 - Básico - Desafios de Código Coding The Future Avanade l - Condicionalmente Rico: Tomadas de Decisão no Código
> Uma nova feature para um sistema bancário foi analisada pela equipe de desenvolvimento e será uma das tarefas a serem trabalhadas durante a sprint, como desenvolvedor da empresa você recebeu os requisitos para a nova implementação que consiste em uma solução algorítmica que permita aos clientes realizarem saques em caixas eletrônicos. No entanto, existem algumas regras a serem seguidas para garantir que um saque possa ser realizado com sucesso.

> Regras do saque:
- Cada cliente digitará o valor do seu saldoTotal de sua conta bancária e o valorSaque.
- Um saque só pode ser realizado se o saldoDisponível na conta for igual ou superior ao valor solicitado.
- Se o saldo for suficiente, o valor solicitado deve ser subtraído do saldo disponível, indicando que o saque foi realizado.
- Se o saldo for insuficiente, o saque não deve ser realizado e uma mensagem adequada deve ser exibida.

- Entrada: A entrada consiste em dois valores inteiros que representam o total do saldo da conta e o valor do saque.

- Saída: Se o saque for realizado com sucesso, exibir a mensagem "Saque realizado com sucesso! Novo saldo: {saldo}", onde {saldo} é o novo saldo disponível na conta.

- Se o saque não for possível devido a saldo insuficiente, exibir a mensagem "Saldo insuficiente. Saque nao realizado!"

- Entrada: 	1000  /   200
- Saída: Saque realizado com sucesso. Novo saldo: 800

## Desafio 2 - Básico - Desafios de Código Coding The Future Avanade - Lista de itens
> Em um jogo de RPG, os personagens geralmente possuem uma lista de itens que podem ser utilizados durante o jogo. Esses itens podem ser armas, armaduras, poções de cura, entre outros. É importante que o jogador tenha um controle desses itens para poder utilizá-los no momento adequado.

- Crie um programa que permita cadastrar uma lista de itens que o personagem possui. A lista deve conter o valor fixo de 3 itens e deve ser exibida na tela.

- Entrada: O programa deve solicitar ao usuário o nome dos 3 itens que o personagem possui. Cada item deve ser cadastrado separadamente.

- Saída: Após receber os itens cadastrados pelo usuário, o programa deve exibir na tela a lista de itens que o personagem possui. A saída deve ter o seguinte formato:

Lista de itens:
- [item1]
- [item2]
- [item3]

> Entrada:   Espada   /   Escudo   /   Poção

> Saída:
Lista de itens:
- Espada
- Escudo
- Poção

