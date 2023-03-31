using System;
using System.Collections.Generic;

namespace Exercício08{
    class Program{
         public static void Main(string[] args){
            //Criando Agencia
            Agencia minha_agencia = new Agencia();
            minha_agencia.Nome="BancoCentral";
            minha_agencia.Numero=0010010;
            //Criando cliente
            Cliente eu = new Cliente();
            eu.Nome = "Igor";
            eu.Documento = "0723.5";
            //Criando cartão do cliente
            eu.Conta = new Conta();
            eu.Conta.Numero = 325;
            eu.Conta.Limite = 1500;
            eu.Conta.Saldo = 2000;
            eu.Conta.Agencia = minha_agencia;
            //Cliente 2
            Cliente voce = new Cliente();
            voce.Nome = "Roger";
            voce.Documento = "0553.5";
            //Criando cartão do cliente
            voce.Conta = new Conta();
            voce.Conta.Numero = 100;
            voce.Conta.Limite = 10;
            voce.Conta.Saldo = 50;
            voce.Conta.Agencia = minha_agencia;
            //Programa
            eu.Depositar(50);
            //Eu fico com 2050;
            eu.Conta.imprimir_extrato();
        }
    }
}

