using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoList
{
    public static class ListExtensoes
    {
        public static void AdicionarTarefa<T>(this List<T> addTarefa, params T[] tarefas)
        {
            foreach (T tarefa in tarefas)
            {
                addTarefa.Add(tarefa);
            }

        }
    }
}
