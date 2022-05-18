using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_saque
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Programa: Finanças
             Problema.: Permitir a entrada dos gastos do mês, subtrair pelo saldo anterior, exibir o saldo atual, permitir a entrada do valor a ser sacado, determinar se será possível realizar o saque, e exibir o novo saldo pós-saque.
             Data.....: 01/04/2022
             Autor(es): Felipe Rocha e Gustavo Neves
            */

            //Título
            Console.WriteLine("****Realizando um saque****");

            //Variáveis
            double gastos, saldo, saque, saldoPosSaque;
            double saldoAnterior = 1000;

            Console.WriteLine("\n\n\n#### Saldo Atual: R$1000");


            Console.Write("\n\nDigite o quanto gastou esse mês: R$");
            gastos = double.Parse(Console.ReadLine()); //Entrada

            //Processamento
            saldo = saldoAnterior - gastos;

            Console.WriteLine("\n\n#### Saldo Atual: R${0, 4:F2}", saldo);

            //Condições
            if (saldo >= 20)
            {
                Console.Write("\n\nDigite o valor que deseja sacar: R$");
                saque = double.Parse(Console.ReadLine()); //Entrada 2

                //Processamento 2
                saldoPosSaque = saldo - saque;

                if (saldoPosSaque < 0)
                {
                    Console.Write("\n\nSaldo insuficiente para realizar o saque\n\n"); //saída
                    Console.Write("\nTente novamente\n\n");

                    saque = saldoPosSaque + saldoPosSaque;

                    Console.Write("\n\nDigite o valor que deseja sacar: R$");
                    saque = double.Parse(Console.ReadLine()); //Entrada 2

                    //Processamento 2
                    saldoPosSaque = saldo - saque;

                    Console.WriteLine("\n\nSaque realizado com sucesso!");//Saída
                    Console.WriteLine("\n\n#### Saldo Atual: R${0, 4:F2}\n\n", saldoPosSaque);//Saída
                }
                else
                {
                    if (saque >= 20)
                    {
                        Console.WriteLine("\n\nSaque realizado com sucesso!");//Saída
                        Console.WriteLine("\n\n#### Saldo Atual: R${0, 4:F2}\n\n", saldoPosSaque);//Saída
                    }
                    else
                    {
                        Console.WriteLine("\n\nO valor mínimo de saque é de: R$20,00!\n\n");
                    }
                }
            }
            else
            {
                Console.WriteLine("\n\nOperação de saque indisponível. Seu saldo é insuficiente\n\n");//Saída 2
            }

            Console.WriteLine("Aperte qualquer tecla para sair...");
            Console.ReadKey();
        }
    }
}
