using System;
using System.Collections.Generic;

namespace Exercício08
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Criando Agencia
            Agencia minha_agencia = new Agencia();
            minha_agencia.Nome = "BANCO CENTRAL";
            minha_agencia.Numero = 1001;
            Console.WriteLine("BEM VINDO AO {0}", minha_agencia.Nome);
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("CADASTRO DE CLIENTE");
            Console.Write("Quantos cadastros? ");
            int num_cadastros = int.Parse(Console.ReadLine());
            //Criando cliente
            List<Cliente> clientes = new List<Cliente>();
            for (int i = 0; i < num_cadastros; i++)
            {
                Cliente novo_cliente = new Cliente();
                Console.Write("Nome: ");
                novo_cliente.Nome = Console.ReadLine();
                Console.Write("CPF: ");
                novo_cliente.Documento = Console.ReadLine();
                //Criando conta do cliente
                novo_cliente.Conta = new Conta();
                Console.Write("Numero da conta: ");
                novo_cliente.Conta.Numero = long.Parse(Console.ReadLine());
                Console.Write("Limite da conta: ");
                novo_cliente.Conta.Limite = double.Parse(Console.ReadLine());
                Console.Write("Saldo da conta: ");
                novo_cliente.Conta.Saldo = double.Parse(Console.ReadLine());
                novo_cliente.Conta.Agencia = minha_agencia;
                clientes.Add(novo_cliente);
            }
            //Programa
            clientes[1].Depositar(50);
            //Eu fico com 2050;
            clientes[1].Conta.imprimir_extrato();
        }
    }
}

