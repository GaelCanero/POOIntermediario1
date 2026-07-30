using System;
using System.Collections.Generic;
using System.Text;

namespace POOIntermediario1.Classes
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public bool Ativo { get; set; }
        public Cliente()
        {
        }
        public Cliente(int id, string nome, string email, string telefone)
        {
            Id = id;
            Nome = nome;
            Email = email;
            Telefone = telefone;
            Ativo = true;
        }
        public void AtualizarContato(string telefone)
        {
            Telefone = telefone;
        }
        public void AtualizarContato(string telefone, string email)
        {
            Telefone = telefone;
            Email = email;
        }
        public void DesativarCliente()
        {
            Ativo = false;
        }
        public void AtivarCliente()
        {
            Ativo = true;
        }
        public void ExibirInformacoes()
        {
            Console.WriteLine($"ID: {Id}");
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Email: {Email}");
            Console.WriteLine($"Telefone: {Telefone}");
            if (Ativo == true)
            {
                Console.WriteLine($"O cliente {Nome} está ativo\n");
            }
            else
            {
                Console.WriteLine($"O cliente {Nome} está inativo.\n");
            }
        }
    }
}
