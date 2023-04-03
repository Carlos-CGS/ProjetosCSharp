# Tratamento de Exceção em C# ( Try / Catch )

✅ Este trecho de código C# exemplifica como é feito o tratamento de exceções, onde elas vão subindo de nível, até que sejam tratadas na origem;

✅ A exceção deste exemplo foi forçada no nível do método 4, porém só é tratada no primeiro nível;

✅ Neste exemplo o método um(01), chama de inicio o método dois(02) utilizando o (Try), que quando é detectada a exceção chama o tratamento da mesma no (Catch), o método dois(2) chama o tres(03) e este chama o quatro(04) que contém uma exceção, e retorna ao método um(01) para ser tradada.
