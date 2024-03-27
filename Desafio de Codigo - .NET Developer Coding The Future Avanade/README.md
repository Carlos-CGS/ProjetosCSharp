# Desafios de Código Básico C# - Coding The Future Avanade I- .NET Developer - DIO
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

# Desafios de Código Intermediário C# - Coding The Future Avanade II- .NET Developer - DIO

## Desafios de Código Coding The Future Avanade ll - Calculando o Dano
>Em jogos de RPG, é comum haver ações de ataque dos personagens, que causam um certo dano ao inimigo. Este dano pode ser calculado de diferentes formas, dependendo do sistema do jogo. Neste desafio, você deve criar uma função que calcula o dano de um ataque, levando em consideração o valor do ataque e a defesa do inimigo.

- Crie uma função chamada "calcular_dano" que recebe dois parâmetros: "ataque" e "defesa". A função deve retornar o valor do dano causado pelo ataque, utilizando a seguinte fórmula:

- dano = ataque - defesa

- Se o valor do dano for negativo, ele deve ser considerado zero.

- Entrada: Seu programa deverá receber uma  entrada para a função "calcular_dano", que irá solicitar ao usuário que insira dois valores: o valor do ataque e o valor da defesa do inimigo. Esses valores serão passados como parâmetros para a função.

- Saída: A saída deve ser exibida com a frase "O dano causado pelo ataque foi: " seguida do valor do dano calculado. Caso o valor do dano seja negativo, deve ser exibido zero.

- Por exemplo, se o valor do ataque for 10 e o valor da defesa do inimigo for 8, a chamada da função "calcular_dano" deve resultar na seguinte saída: "O dano causado pelo ataque foi: 2"

- Entrada	10   /   8

- Saída: O dano causado pelo ataque foi: 2

## Desafios de Código Coding The Future Avanade ll - O Guardião dos Atributos
> Em jogos de RPG, os personagens possuem atributos que determinam suas habilidades em diferentes áreas, como força, agilidade, inteligência, etc. Neste desafio, você deve criar uma função que verifica se o valor de um determinado atributo está dentro de um intervalo aceitável.

> Crie uma função chamada "verificar_atributo" que recebe três parâmetros: "atributo", "valor_minimo" e "valor_maximo". A função deve verificar se o valor do atributo está dentro do intervalo definido pelos valores mínimo e máximo.
Caso o valor esteja dentro do intervalo, a função deve retornar true. Caso contrário, deve retornar false.

- Entrada: A entrada do código deverá ser feita através do io.stream(). Serão necessários três valores para chamar a função "verificar_atributo", que são: o nome do atributo, o valor mínimo aceitável e o valor máximo aceitável. Além disso, também será necessário informar o valor atual do atributo que se deseja verificar.

- Saída: A saída do código será uma mensagem informando se o valor do atributo está dentro ou fora do intervalo especificado. Caso o valor esteja dentro do intervalo, a mensagem será "O valor do atributo está dentro do intervalo especificado". Caso contrário, a mensagem será "O valor do atributo está fora do intervalo especificado".

- Entrada:	força   /   1   /   10   /   7
- Saída: O valor do atributo está dentro do intervalo especificado

## Desafios de Código Coding The Future Avanade ll - Validando a Força de Senhas no IAM
> Você está trabalhando para uma empresa que utiliza extensivamente os serviços da AWS, e após algumas análises a equipe de segurança identificou que algumas senhas dos usuários no IAM são fracas e podem representar um risco à segurança dos dados da empresa. Para resolver esse problema, foi solicitado que você desenvolva um programa capaz de analisar as senhas dos usuários e fornecer uma validação de força com base em critérios predefinidos.

- Requisitos de segurança para a senha:

- A senha deve ter no mínimo 8 caracteres.
- A senha deve conter pelo menos uma letra maiúscula (A-Z).
- A senha deve conter pelo menos uma letra minúscula (a-z).
- A senha deve conter pelo menos um número (0-9).
- A senha deve conter pelo menos um caractere especial, como !, @, #, $, %, etc.
- Saiba mais sobre o Regex em: Java Regular Expressions

- Entrada: A entrada será uma única string representando a senha que precisa ser validada.

- Saída: Seu programa deve retornar uma mensagem indicando se a senha fornecida pelo usuário atende aos requisitos de segurança ou não, juntamente com um feedback explicativo sobre os critérios considerados.

- Entrada:	0101	
- Saída: Sua senha e muito curta. Recomenda-se no minimo 8 caracteres.
