using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace ToDoList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-c : para criar uma nova ToDo List\n-a : para adicionar uma tarefa" +
                "\n-m : para mostrar a lista criada\n-rmv : para remover um item da lista\n" +
                "-del : para deletar uma lista\n-ccl : para concluir uma tarefa e remover ela da lista");
            Tarefas t1 = new Tarefas();
            t1.MetodoGeral();

        }
        public class Tarefas
        {
            public List<string> tarefas;
            public List<string> tarefasConcluidas;
            public bool resposta = true;
            public int concluidas;
            string teste = Console.ReadLine();
            string criarLista = "-c";

            internal void MetodoGeral()
            {
                Match resultado = Regex.Match(criarLista, teste);
                if (resultado.Success)
                {
                    Console.WriteLine("Sua ToDo List foi criada com sucesso!");
                    this.tarefas = new List<string>();
                }
                else
                {
                    Console.WriteLine("Você deve inserir um código válido!");
                }
                while (resultado.Success)
                {
                    string funcao = Console.ReadLine();
                    string addTarefa = "-a";
                    string mostrarLista = "-m";
                    string removerItem = "-rmv";
                    string excluirLista = "-del";
                    string concluirTarefa = "-ccl";

                    Match resultado_2 = Regex.Match(funcao, addTarefa);
                    if (resultado_2.Success)
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
                    //---------------------
                    Match resultado_3 = Regex.Match(funcao, mostrarLista);
                    if (resultado_3.Success)
                    {
                        Console.WriteLine($"-----LISTA DE TAREFAS-----");
                        for (int i = 0; i < tarefas.Count; i++)
                        {
                            Console.WriteLine($"Item {i}: " + tarefas[i]);
                        }
                    }
                    //---------------------
                    Match resultado_4 = Regex.Match(funcao, removerItem);
                    if (resultado_4.Success)
                    {
                        Console.WriteLine("Qual item você gostaria de remover?");
                        var i = int.Parse(Console.ReadLine());
                        this.tarefas.RemoveAt(i);

                        Console.WriteLine("O que você gostaria de fazer agora?");
                    }
                    //---------------------
                    Match resultado_5 = Regex.Match(funcao, excluirLista);
                    if (resultado_5.Success)
                    {
                        Console.WriteLine("---Sua lista foi excluída---");
                        this.tarefas.Clear();
                    }
                    //---------------------
                    Match resultado_6 = Regex.Match(funcao, concluirTarefa);
                    if (resultado_6.Success)
                    {
                        Console.WriteLine("Qual tarefa você concluiu?");
                        var c = int.Parse(Console.ReadLine());
                        concluidas = c;
                        tarefas.RemoveAt(c);

                        Console.WriteLine("---Tarefas concluídas---");
                        tarefasConcluidas = new List<string>();
                        for (int i = 0; i <= tarefasConcluidas.Count; i++)
                        {
                            Console.WriteLine($"Item {concluidas} concluído");
                        }
                    }
                }

            }
        }
        static void AntesDoRegex()
        {
            //public void CriarLista()
            //{
            //    Match resultado = Regex.Match(criarLista, teste);
            //    Console.WriteLine("Sua ToDo List foi criada com sucesso!");
            //    if (resultado.Success)
            //    {
            //        this.tarefas = new List<string>();
            //    }
            //}
            //public void AdicionarTarefa()
            //{
            //    while (resposta == true)
            //    {
            //        Console.WriteLine("Escreva sua task: ");
            //        var item = Console.ReadLine();
            //        this.tarefas.Add(item);
            //        for (int i = 0; i < tarefas.Count; i++)
            //        //Para i valendo 0, faça tal coisa, enquanto i for menor que tanto, e incremente mais um a cada passo
            //        {
            //            Console.WriteLine($"Item {i}: " + tarefas[i]);
            //        }
            //        Console.WriteLine("Gostaria de adicionar mais uma task? \nS para 'Sim'\nN para 'Não");
            //        var r = Console.ReadLine();
            //        if (r == "N")
            //        {
            //            resposta = false;
            //            Console.WriteLine("Sua lista foi finalizada.");
            //        }
            //    }
            //}
            //public void MostrarLista()
            //{
            //    Console.WriteLine($"-----LISTA DE TAREFAS-----");
            //    for (int i = 0; i < tarefas.Count; i++)
            //    {
            //        Console.WriteLine($"Item {i}: " + tarefas[i]);
            //    }
            //}
            //public void RemoverTarefa()
            //{
            //    Console.WriteLine("Qual item você gostaria de remover?");
            //    var i = int.Parse(Console.ReadLine());
            //    this.tarefas.RemoveAt(i);
            //}
            //public void ExcluirLista()
            //{
            //    Console.WriteLine("---Sua lista foi excluída---");
            //    this.tarefas.Clear();
            //}
            //public void ConcluirTarefa()
            //{
            //    Console.WriteLine("Qual tarefa você concluiu?");
            //    var c = int.Parse(Console.ReadLine());
            //    concluidas = c;
            //    this.tarefas.RemoveAt(c);
            //}
            //public void TarefasConcluidas()
            //{
            //    Console.WriteLine("---Tarefas concluídas---");
            //    tarefasConcluidas = new List<string>();
            //    for (int i = 0; i <= tarefasConcluidas.Count; i++)
            //    {
            //        Console.WriteLine($"Item {concluidas} concluído");
            //    }
            //}
        }
        static void TestaRegex()
        {
            string adicionarPadrao = "[Adicionar]";
            string testeAdicionar = Console.ReadLine();
            Match resultado = Regex.Match(adicionarPadrao, testeAdicionar);
            Console.WriteLine(resultado.Value);
        }
    }
}

