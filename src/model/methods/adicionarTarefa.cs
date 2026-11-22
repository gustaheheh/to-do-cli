using Microsoft.VisualBasic;

namespace classTarefas;

public partial class Tarefas
{
    
    public void adicionarTarefa()
    {
        
        // Salva o nome da tarefa
        Console.WriteLine("Nome da tarefa: "); 
        string nomeTarefa = Console.ReadLine();
            // Impedimento de duplicatas no nome das tarefas
            for(int i = 0; i < tarefasToDoNome.Count; i++)
            {
            
                if(nomeTarefa == tarefasToDoNome[i])
                {   
                    Console.WriteLine("ERRO: Você não pode ter duas tarefas que compartilham do mesmo nome");
                    return;
                }
            }      
        tarefasToDoNome.Add(nomeTarefa);
        
        // Salva a descrição da tarefa
        Console.WriteLine("Descrição da tarefa: ");
        string DescTarefa = Console.ReadLine();
        tarefasToDoDescricao.Add(DescTarefa);
        
        // Salva a data da tarefa
        tarefasDataAdd.Add(DateTime.Now);
        
        // A tarefa adicionada já vem como pendente
        tarefasStatus.Add(false);

        Console.Clear();
        Console.WriteLine($"* A tarefa {nomeTarefa} foi adicionada! *");

    }
}