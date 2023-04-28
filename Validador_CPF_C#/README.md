# Validador de CPF em C#

## Este trecho de código executa diversas verificações e informa se o cpf digitado é válido.

- A primeira etapa de verificação, verifica se o valor digitado é nulo;

- Em seguida ignora os pontos e traços atribuidos na variável cpf na digitação do usuário, caso ele digite;

- Em seguida, verifica se o CPF tem uma quantidade de caracteres diferente de onze;

- Em seguida, verifica se todos os caracteres da variável CPF são dígitos;

- Em seguida, transforma os valores da variável CPF em um array;

- Somente nesta hora que começa realemnet a validação que é feita em duas partes:

- Primeira Parte (Primeiro Dígito Verificador)

- Segunda Parte (Segundo Dígito Verificador)

- Caso os dois testes retornem verdadeiro, o método validar_CPF na classe main retorna um texto, informando se é valido ou não.
