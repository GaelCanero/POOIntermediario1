using POOIntermediario1.Classes;

namespace POOIntermediario1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cliente[] clientes = new Cliente[5];

            clientes[0] = new Cliente(
                1,
                "Gael",
                "gael@empresa.com",
                "21999999999");

            clientes[1] = new Cliente(
                2,
                "Evandro",
                "evandro@empresa.com",
                "21988888888");

            clientes[2] = new Cliente(
                3,
                "Denilson",
                "denilson@empresa.com",
                "21977777777");

            clientes[3] = new Cliente(
                4,
                "Vitor",
                "vitor@empresa.com",
                "21966666666");

            clientes[4] = new Cliente(
                5,
                "Gustavo",
                "gustavo@empresa.com",
                "21955555555");
            
            clientes[0].AtualizarContato("21911111111");

            clientes[1].AtualizarContato(
                "21922222222",
                "evandronovo@empresa.com");

            clientes[2].DesativarCliente();

            for (int i = 0; i < clientes.Length; i++)
            {
                if (clientes[i].Ativo)
                {
                    clientes[i].ExibirInformacoes();
                }
            }
        }
    }
}