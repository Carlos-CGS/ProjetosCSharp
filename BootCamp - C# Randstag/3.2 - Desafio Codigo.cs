using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        // Leitura da entrada do usuário
        List<string> entradas = new List<string>();
        string entrada;

        // Loop para ler múltiplas linhas de entrada até que uma linha vazia seja detectada
        while (!string.IsNullOrEmpty(entrada = Console.ReadLine()))
        {
            entradas.Add(entrada);
        }

        // Conversão da entrada em uma lista de tuplas (nome do candidato, horário de início, horário de fim)
        List<(string nomeCandidato, TimeSpan horarioInicio, TimeSpan horarioFim)> listaCandidatos = entradas.Select(entradaAtual =>
        {
            var partes = entradaAtual.Split(',');
            var nomeCandidato = partes[0];
            var intervaloHorarios = partes[1].Trim().Split('-');
            var horarioInicio = TimeSpan.Parse(intervaloHorarios[0]);
            var horarioFim = TimeSpan.Parse(intervaloHorarios[1]);
            return (nomeCandidato, horarioInicio, horarioFim);
        }).ToList();

        // Otimização dos horários das entrevistas
        var agendaAjustada = ReagendarHorarios(listaCandidatos); // Chama o método que ajusta os horários das entrevistas

        // Formatação da saída
        foreach (var candidato in agendaAjustada) // Percorre cada candidato na lista ajustada
        {
            // Imprime o nome do candidato e o intervalo de horário formatado
            Console.WriteLine($"{candidato.nomeCandidato}, {candidato.horarioInicio:hh\\:mm}-{candidato.horarioFim:hh\\:mm}");
        }
    }

    // Método que ajusta os horários das entrevistas para evitar sobreposição
    static List<(string nomeCandidato, TimeSpan horarioInicio, TimeSpan horarioFim)> ReagendarHorarios(List<(string nomeCandidato, TimeSpan horarioInicio, TimeSpan horarioFim)> listaCandidatos)
    {
        // Ordena os candidatos por horário de início
        listaCandidatos = listaCandidatos.OrderBy(c => c.horarioInicio).ToList();

        List<(string nomeCandidato, TimeSpan horarioInicio, TimeSpan horarioFim)> agendaAjustada = new List<(string nomeCandidato, TimeSpan horarioInicio, TimeSpan horarioFim)>(); // Cria uma nova lista para armazenar a agenda ajustada
        TimeSpan horarioAtual = listaCandidatos[0].horarioInicio; // Define o horário atual como o horário de início do primeiro candidato

        foreach (var candidato in listaCandidatos) // Percorre cada candidato na lista ordenada
        {
            if (candidato.horarioInicio >= horarioAtual) // Se o horário de início do candidato for maior ou igual ao horário atual
            {
                // TODO: Adiciona o candidato à agenda ajustada
                agendaAjustada.Add(candidato);
                horarioAtual = candidato.horarioFim; // Atualiza o horário atual para o fim do horário do candidato
            }
            else // Se o horário de início do candidato for menor que o horário atual (conflito)
            {
                // Calcula a nova duração com base no intervalo original
                var duracao = candidato.horarioFim - candidato.horarioInicio;

                // Define um novo horário de início e fim baseado no horário atual
                var novoHorarioInicio = horarioAtual;
                var novoHorarioFim = novoHorarioInicio + duracao;

                // TODO: Calcule um novo horário de fim baseado na duração original do horário do candidato

                agendaAjustada.Add((candidato.nomeCandidato, novoHorarioInicio, novoHorarioFim)); // Adiciona o candidato à agenda ajustada com os novos horários
                horarioAtual = novoHorarioFim; // Atualiza o horário atual para o novo fim do horário do candidato
            }
        }

        return agendaAjustada;
    }
}