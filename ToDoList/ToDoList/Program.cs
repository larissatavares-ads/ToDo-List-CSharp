using System;
using System.Collections.Generic;

namespace ToDoList
{
    class Program
    {
        static void Main(string[] args)
        {
            Tarefas t1 = new Tarefas();
            t1.CriarLista();
            t1.AdicionarTarefa();
            t1.MostrarLista();
            t1.ConcluirTarefa();
            t1.TarefasConcluidas();
            t1.MostrarLista();

            //t1.RemoverTarefa();
            //t1.ExcluirLista();


        }
        public class Tarefas
        {
            public List<string> tarefas;
            public List<string> tarefasConcluidas;
            public bool resposta = true;
            public string concluidas;
            public void CriarLista()
            {
                Console.WriteLine("Sua ToDo List foi criada com sucesso!");

                this.tarefas = new List<string>();
            }
            public void AdicionarTarefa()
            {
                while (resposta == true)
                {
                    Console.WriteLine("Escreva sua task: ");
                    var item = Console.ReadLine();
                    this.tarefas.Add(item);
                    for (int i = 0; i < tarefas.Count; i++)
                    //Para i valendo 0, faça tal coisa, enquanto i for menor que tanto, e incremente mais um a cada passo
                    {
                        Console.WriteLine($"Item {i}: " + tarefas[i]);
                    }
                    Console.WriteLine("Gostaria de adicionar mais uma task? \nS para 'Sim'\nN para 'Não");
                    var r = Console.ReadLine();
                    if (r == "N")
                    {
                        resposta = false;
                        Console.WriteLine("Sua lista foi finalizada.");
                    }
                }
            }
            public void MostrarLista()
            {
                Console.WriteLine($"-----LISTA DE TAREFAS-----");
                for (int i = 0; i < tarefas.Count; i++)
                {
                    Console.WriteLine($"Item {i}: " + tarefas[i]);
                }
            }
            public void RemoverTarefa()
            {
                Console.WriteLine("Qual item você gostaria de remover?");
                var i = int.Parse(Console.ReadLine());
                this.tarefas.RemoveAt(i);
            }
            public void ExcluirLista()
            {
                Console.WriteLine("---Sua lista foi excluída---");
                this.tarefas.Clear();
            }
            public void ConcluirTarefa()
            {
                Console.WriteLine("Qual tarefa você concluiu?");
                concluidas = Console.ReadLine();
                this.tarefas.Remove(concluidas);
            }
            public void TarefasConcluidas()
            {
                Console.WriteLine("---Tarefas conluídas---");
                tarefasConcluidas = new List<string>();
                for (int i = 0; i <= tarefasConcluidas.Count; i++)
                {
                    Console.WriteLine($"Item {concluidas} concluído");
                }
            }
        }


    }
}
