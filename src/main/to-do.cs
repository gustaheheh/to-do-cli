namespace classTarefas;

class Program
{
    
    static void Main()
    {
        
        Console.Clear();
        
        Console.WriteLine("Bem-vindo à lista de tarefas! \nQual é o seu nome de usuário? (Deixe em branco para continuar como visitante)");
        string ?nome = Console.ReadLine();
        
        if (nome == "")
        {
            nome = "Visitante";
        }

        Tarefas usuario = new Tarefas();
        
        Console.Clear();

        bool rodando = true;

        while (rodando)
        {

            Console.WriteLine($"Olá, {nome}! O que deseja fazer?");

            Console.WriteLine("1. Adicionar Tarefa \n2. Listar Tarefas \n3. Concluir tarefa \n4. Sair");
            var _escolha = Console.ReadLine();

            if(int.TryParse(_escolha, out int escolha)){
                switch (escolha)
                {
                    case 1:
                    Console.Clear();
                    usuario.adicionarTarefa();
                    break;

                    case 2:
                    Console.Clear();
                    usuario.listarTarefas();
                    break;

                    case 3:
                    usuario.concluirTarefa();
                    break;

                    case 4:
                    Console.WriteLine("Certo, até logo!");
                    rodando = false;
                    break;

                    default:
                    Console.WriteLine("Por favor, selecione uma opção válida para a escolha.\n");
                    break;
                    
                }
            }
        }
    }
}