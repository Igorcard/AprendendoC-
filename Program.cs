using System;
using System.Collections.Generic;

namespace Banco
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Criando Agencia
            Agencia minha_agencia = new Agencia();
            minha_agencia.Nome = "BANCO CENTRAL";
            minha_agencia.Numero = 1001;
            formatacao_strings formatacao = new formatacao_strings();
            formatacao.cabecalho("BEM VINDO AO " + minha_agencia.Nome);
            Console.WriteLine("CADASTRO DE CLIENTE");
            formatacao.linha();
            Console.Write("QUANTOS CADASTROS? ");
            int num_cadastros = int.Parse(Console.ReadLine());
            formatacao.linha();
            //Criando cliente
            List<Cliente> clientes = new List<Cliente>();
            for (int i = 0; i < num_cadastros; i++)
            {
                Cliente novo_cliente = new Cliente();
                formatacao.cabecalho("CLIENTE " + (i + 1));
                Console.Write("NOME: ");
                novo_cliente.Nome = Console.ReadLine();
                Console.Write("CPF: ");
                novo_cliente.Documento = Console.ReadLine();
                //Criando conta do cliente
                novo_cliente.Conta = new Conta();
                Console.Write("NUMERO DA CONTA: ");
                novo_cliente.Conta.Numero = long.Parse(Console.ReadLine());
                Console.Write("LIMITE DA CONTA: ");
                novo_cliente.Conta.Limite = double.Parse(Console.ReadLine());
                Console.Write("SALDO DA CONTA: ");
                novo_cliente.Conta.Saldo = double.Parse(Console.ReadLine());
                Console.Write("QUANTOS CARTOES? ");
                int qtd_cartoes = int.Parse(Console.ReadLine());
                for (int j = 0; j < qtd_cartoes; j++)
                {
                    Cartao novo_cartao = new Cartao();
                    formatacao.cabecalho("CARTAO " + (j + 1));
                    Console.Write("NOME: ");
                    novo_cartao.Nome = Console.ReadLine();
                    Console.Write("NUMERO: ");
                    novo_cartao.Numero = int.Parse(Console.ReadLine());
                    novo_cliente.Cartoes.Add(novo_cartao);
                }
                novo_cliente.Conta.Agencia = minha_agencia;
                clientes.Add(novo_cliente);
            }
            //Programa
            //formatacao.cabecalho("Deseja depositar quanto? ");
            //clientes[1].Depositar(int.Parse(Console.ReadLine()));
            //Eu fico com 2050;
            for (int i = 0; i < clientes.Count; i++)
            {
                clientes[i].Conta.imprimir_extrato();
            }
        }
    }
}

