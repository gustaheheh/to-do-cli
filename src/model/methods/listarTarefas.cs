namespace classTarefas;

public partial class Tarefas
{

// Método para listar as tarefas adicionadas pelo usuário
    public void listarTarefas()
    {
        
        if(tarefasToDoNome.Count <= 0)
        {
            
            Console.WriteLine("ERRO: Você não tem nenhuma tarefa cadastrada.\n");
            
        } 
        else{

        Console.WriteLine("Você tem as seguintes tarefas pendentes:");
        
        for (int i = 0; i < tarefasStatus.Count && i < tarefasToDoNome.Count && i < tarefasToDoDescricao.Count && i < tarefasDataAdd.Count; i++)
        {
            
            bool status = tarefasStatus[i];
            string pendentes = tarefasToDoNome[i];
            string desc = tarefasToDoDescricao[i];
            DateTime data = tarefasDataAdd[i];
            var situacaoTarefa = "";

            if(status == false)
            {
                situacaoTarefa = "Pendente";

            } else if (status == true)
            {
                
                situacaoTarefa = "Concluída";

            }

            Console.WriteLine($"\nStatus: {situacaoTarefa}\nNome: {pendentes}\nDescrição: {desc}\nData Adicionada: {data}\n");
        }
    }
}
}