// Criação de um Dictionary

// Dicionário é um Array onde os elemementos são armazenados em ( Chave X Valor ).

Dictionary<string, string> estados = new Dictionary<string, string>();
estados.Add("SP", "São Paulo");
estados.Add("RJ", "Rio de Janeiro"); // Onde Rj é a chave e Rio de Janeiro é o valor armazenado.
estados.Add("BA", "Bahia");
estados.Remove("BA"); // << Remove item do Dictionary
estados["SP"] = "São_Paulo"; //<< altera o valor das variáveis 

foreach(var item in estados)
    {
        Console.WriteLine($"Chave: {item.Key}, Valor Armazenado: {item.Value}"); // << exibe a cahve e o valor armazenado
    }

string chave = "BA";
Console.WriteLine($"Verificando o elemento: {chave}");
if(estados.ContainsKey(chave))
    {
        Console.WriteLine($"O valor existe: {chave}");
    }else 
    {
        Console.WriteLine($"Valor não existe, pode adicionar a chave: {chave}");
    }