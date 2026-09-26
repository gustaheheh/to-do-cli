namespace classTarefas;

public partial class Tarefas
{
    
    public void concluirTarefa()
    {

        Console.Clear();
        
        if(tarefasToDoNome.Count == 0)
        {
            
            Console.WriteLine("ERRO: Você não tem nenhuma tarefa cadastrada.\n");
            
        }
        
        else if(tarefasToDoNome.Count > 0)
        {
            
        Console.WriteLine("Qual tarefa você deseja marcar como concluída?\n");

        for (int i = 0; i < tarefasToDoNome.Count; i++)
        {

            string tarefasPendentes = tarefasToDoNome[i];
            
            if(tarefasStatus[i] == false)
            {
                Console.WriteLine($"\n{i + 1}. {tarefasPendentes}\n");
            }
            
            else
            {
                Console.WriteLine($"\n{i + 1}. {tarefasPendentes} [Concluída]\n");
            }
        }
            
            Console.Write("> ");
            var _escolha = Console.ReadLine();
            if(int.TryParse(_escolha, out int escolha))
            {

                if(tarefasStatus[escolha - 1] == true)
                {
                    
                    Console.WriteLine("ERRO: Esta tarefa já consta como concluída.");

                }
                
                else{
                    
                    tarefasStatus[escolha - 1] = true;
                    Console.WriteLine($"A tarefa {tarefasToDoNome[escolha - 1]} foi marcada como concluída.");

                }
            }
        }
    }
}