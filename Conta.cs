using System.Collections.Generic;

namespace Banco
{   
public class Conta
    {
        public long Numero{get; set;}
        public double Limite{get; set;}
        public double Saldo{get; set;}
        public Agencia Agencia {get; set;}

        public void Depositar(double valor)
        {
            Saldo += valor;
        }
        public void Sacar(double valor)
        {
            if (Saldo >= valor)
            {
                Saldo -= valor;
            }
            else
            {
                Console.WriteLine("Saque maior do que o saldo na conta!");
            }
        }
        public void Transferir(double valor, Conta destino)
        {
            destino.Depositar(valor);
        }
        public void imprimir_extrato()
        {
            Console.WriteLine("Numero: {0}", Numero);
            Console.WriteLine("Agencia: {0}", Agencia.Numero);
            Console.WriteLine("Saldo: {0}", Saldo);
        }
    }
}