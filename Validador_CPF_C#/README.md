# Validador de CPF em C#

- Este trecho de código C# az diversas verificações e informa ce o cpf digitado é válido ou não.

- A primeira etapa de verificação, verifica se o valor digitado é nulo;

- Em seguida ignora os pontos e traços atribuidos na variável cpf na digitação do usuário, caso ele digite;

- Em seguida, verifica se o CPF tem uma quantidade de caracteres diferente de onze;

- Em seguida, verifica se todos os caracteres da variável CPF são dígitos;

- Em seguida, transforma os valores da variável CPF em um array;

- Somente nesta hora que começa realemnet a validação que é feita em duas partes:

- Primeira Parte (Primeiro Dígito Verificador)

- Segunda Parte (Segundo Dígito Verificador)

- Caso os dois testes retornem positivo, a classe validar CPF na classe main retorna o texto informando se é valido ou não.