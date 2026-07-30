using POOIntermediario1.Classes;

namespace POOIntermediario1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cliente[] clientes = new Cliente[5];

            clientes[0] = new Cliente(1, "Gael", "gael@prevhab.com", "21999999999");
            clientes[1] = new Cliente(2, "Evandro", "evandro@prevhab.com", "21988888888");
            clientes[2] = new Cliente(3, "Denilson", "denilson@prevhab.com", "21977777777");
            clientes[3] = new Cliente(4, "Vitor", "vitor@prevhab.com", "21966666666");
            clientes[4] = new Cliente(5, "Gustavo", "gustavo@prevhab.com", "21955555555");
            
            clientes[0].AtualizarContato("21911111111");
            clientes[1].AtualizarContato("21922222222", "evandronovo@prevhab.com");

            clientes[2].DesativarCliente();

            for (int i = 0; i < clientes.Length; i++)
            {
                if (clientes[i].Ativo)
                {
                    clientes[i].ExibirInformacoes();
                }
            }
            Console.WriteLine("Deseja mostrar os cliente inativos? Digite (S) para continuar.");

            switch (Console.ReadLine().ToUpper())
            {
                case "S":
                    Console.Clear();
                    for (int i = 0; i < clientes.Length; i++)
                    {
                        if (!clientes[i].Ativo)
                        {
                            clientes[i].ExibirInformacoes();
                        }
                    }
                    return;
                    
                default:
                    break;
            }
        }
    }
}
