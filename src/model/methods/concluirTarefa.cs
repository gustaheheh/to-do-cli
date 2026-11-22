using System.Linq.Expressions;

namespace classTarefas;

public partial class Tarefas
{
    
    public void concluirTarefa()
    {

        Console.Clear();
        
        // Verificar se há tarefas cadastradas
        if(tarefasToDoNome.Count == 0)
        {
            
            Console.WriteLine("ERRO: Você não tem nenhuma tarefa cadastrada.\n");
            
        }
        
        // Lista as tarefas pendentes e as concluídas (se houver)
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
            
            // Input do usuário para escolher qual tarefa pendente será convertida para concluída
            Console.Write("> ");
            var _escolha = Console.ReadLine();
            if(int.TryParse(_escolha, out int escolha))
            {

                // Tentativa de Try Catch caso o usuário tenha uma escolha inválida para a validação de Status pendente
                try
                {
                    if(tarefasStatus[escolha - 1] == true)
                    {
                        
                        Console.WriteLine("ERRO: Esta tarefa já consta como concluída.");

                    }
                    
                    else{
                        
                        tarefasStatus[escolha - 1] = true;
                        Console.WriteLine($"* A tarefa {tarefasToDoNome[escolha - 1]} foi marcada como concluída. *");

                    }  
                
                }  

                // Tratativa de erro e mensagem explícita
                catch (ArgumentOutOfRangeException){
                    Console.WriteLine("ERRO: Selecione um valor válido dentro do número de tarefas que você possui.");
                }

                }
            // Caso o TryParse não dê certo
            else
            {
                    
                Console.WriteLine("ERRO: Insira um valor válido para a escolha.");

            }

        }
    }
}