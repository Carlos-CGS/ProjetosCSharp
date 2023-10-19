# Desafios de Código - Bootcamp WEX - Desenvolvimento .NET e QA

- Desafio de Código proposto em um BootCamp da plataforma do site DIO, o qual nos faz rever os códigos e complementa-los para que ele alcance os objetivos solicitados.

## Desafio 1 - Entradas e Tipos de Dados com C# - Simulando Falhas de Testes

> Neste desafio, vamos criar um programa que simula um algoritmo para registrar falhas em testes de um sistema. O programa solicitará ao usuário que insira o nome do teste e a descrição do erro correspondente. Em seguida, ele exibirá uma mensagem do erro formatado.

- Entrada: A entrada do programa consiste em duas strings. A primeira string deve conter o nome do teste que falhou, e a segunda string deve conter a descrição do erro ocorrido durante o teste.\
Exemplo: Teste de Compra Online\
O carrinho de compras nao atualiza

- Saída: A saída do programa consiste em uma string formatada da seguinte maneira:
"O teste falhou: Descrição do erro: [descricaoDoErro]"\
Exemplo: O teste falhou. Descricao: O carrinho de compras nao atualiza

## Desafio 2 - Variáveis com C# - Avaliação de Testes Automatizados

> Neste desafio, seu objetivo é criar um algoritmo que avalie o desempenho de testes automatizados. O algoritmo deve receber como entrada o número de testes automatizados bem-sucedidos e o número total de testes automatizados realizados. Com base nessas informações, ele determinará a taxa de sucesso do teste.
Críterios da taxa:
Taxa de Sucesso = (Número de Testes Automatizados Bem-sucedidos / Número Total de Testes Automatizados Realizados) * 100

- Entrada: A entrada consiste em dois números inteiros: o número de testes automatizados bem-sucedidos e o número total de testes automatizados realizados.\
Exemplo: 10  20

- Saida: A saída é uma string que informa a porcentagem ( taxaSucesso) da taxa de sucesso dos testes automatizados, indicando se a funcionalidade testada está estável. A saída deve considerar duas casas decimais para essa solução.\ 
Exemplo: Taxa de sucesso: 50.00%    

## Desafio 3 - Tipos e Operadores Aritméticos com C# - Análise de Dados de Teste

> Neste desafio de código, você será encarregado de criar um programa que avalia a prontidão de uma funcionalidade com base nos resultados de um conjunto de testes. O programa solicitará ao usuário que insira a quantidade de testes bem-sucedidos e a quantidade total de testes realizados. Em seguida, o programa calculará a taxa de sucesso dos testes e aplicará os seguintes critérios para determinar se a funcionalidade está pronta para ser lançada:

    * Se a taxa de sucesso for maior ou igual a 80%, o programa exibirá a mensagem "A funcionalidade esta pronta para lancamento."
    * Caso contrário, se a taxa de sucesso for menor que 80%, o programa exibirá a mensagem "A funcionalidade nao esta pronta para lancamento."

Lembre-se de que a taxa de sucesso é calculada como a proporção de testes bem-sucedidos em relação ao total de testes, usando a fórmula: taxaSucesso = (double)testesBemSucedidos / testesTotais.

- Entrada - A entrada consiste em dois números inteiros separados por quebras de linha. O primeiro número representa a quantidade de testes bem-sucedidos, e o segundo número representa a quantidade total de testes realizados.\
Exemplo: 7  12

- Saída - O programa exibirá uma mensagem que indicará se a funcionalidade está pronta para o lançamento ou não, de acordo com os critérios mencionados acima.\
Exemplo: A funcionalidade nao esta pronta para lancamento.

## Desafio 4 - Estruturas Condicionais com C# - Verificação de Dados de Teste

> Para este desafio de código, desenvolva um algoritmo com objetivo a verificação de dados de entrada que atendam aos critérios especificados. O usuário é solicitado a inserir um número inteiro sendo um ID de teste, seguido de uma breve descrição do teste. O programa avalia se o ID é válido e se a descrição possui menos de 50 caracteres.

O programa deve verificar duas condições principais:

1. Validade do ID: O ID de teste deve ser um número inteiro.
2. Comprimento da Descrição: A descrição do teste deve ter menos de 50 caracteres.

Critérios Específicos de Validação:

1. ID de Teste Inválido:
        Se o ID de teste inserido não for um número inteiro (por exemplo, se for uma string de texto ou um número decimal), o programa deve informar que o ID é inválido.

2. Descrição Longa:
        Se a descrição do teste tiver 50 ou mais caracteres, o programa deve informar que a descrição é longa demais.  

3. Dados Válidos:
Se o ID de teste for um número inteiro e a descrição tiver menos de 50 caracteres, o programa deve informar que os dados estão corretos.

- Entrada: A entrada consiste em um valor inteiro que representa o ID de teste e a inserção da descrição do teste.\
Exemplo: 456\
 Esta e uma descricao que excede o limite de 50 caracteres

- Saída: A saída é uma mensagem informativa que utiliza condicionais para indicar se o ID é válido e se a descrição possui menos de 50 caracteres.\
Exemplo: ID de teste invalido ou descricao muito longa.

## Desafio 5 - Arrays e Listas em C# - Priorizando Casos de Teste

> Neste desafio, o objetivo é criar um programa que ajude na priorização de testes de acordo com sua complexidade. O usuário deverá inserir a complexidade (baixa, media ou alta) de três testes distintos, utilizando conceitos de arrays ou listas. Com base nas complexidades fornecidas, o programa calculará e apresentará qual teste deve ser executado primeiro.

- Entrada: 
O programa requer a entrada de três strings que representam os níveis de prioridade atribuídos aos três testes.\
Exemplo 1: Alta - Media - Baixa\
Exemplo 2: Media - Baixa - Alta

- Saída: 
A saída do programa consiste na indicação do teste que deve ser priorizado com base nas complexidades fornecidas.\
Exemplo 1: O teste a ser executado primeiro e o Teste 1.\
Exemplo 2:O teste a ser executado primeiro e o Teste 3.