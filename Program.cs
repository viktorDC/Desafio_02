using System;
using System.Collections.Generic;

namespace desafioUbuntu2
{
    class Program
    {
        static void Main()
        // SOMAR A IDADE DE TODOS OS UBUNTUS VV
        // AGRUPAR OS NOMES DE TODOS OS UBUNTUS  VV
        // CALCULAR MEDIA DE IMC DE TODOS  VV
        // CONTAR QUANTOS UBUNTUS SAO DEV VV
        // EXIBIR SOMENTE UBUNTUS COM NOME SILVA VV
        {
            Console.WriteLine("UBUNTU 002 START...");
            Console.WriteLine("=====================================================");
            string nome1 = "Ubuntu1 Silva";
            int idade1 = 33;
            double peso1 = 70.50;
            double altura1 = 1.83;
            bool EhDev1 = true;

            string nome2 = "Ubuntu2 Silva";
            int idade2 = 45;
            double peso2 = 88.50;
            double altura2 = 1.65;
            bool EhDev2 = true;

            string nome3 = "Ubuntu3 Santos";
            int idade3 = 20;
            double peso3 = 55.50;
            double altura3 = 1.70;
            bool EhDev3 = false;

            Console.WriteLine("Lista de Todos os Ubuntus Silva:");
            List<string> snome = new List<string>();
            snome.Add("ubuntu1 Silva");
            snome.Add("Ubuntu2 Silva");
            //snome.Clear();
            foreach (string silva in snome)
            {
                Console.WriteLine("Nome:{0}", silva);
            }

            int SOidade = idade1 + idade2 + idade3;
            string Agrupamento = nome1 + "," + nome2 + "," + nome3;
            Console.WriteLine("=====================================================");
            Console.WriteLine("A soma da idade de nossos UBUNTUS :" + SOidade);
            Console.WriteLine("=====================================================");
            Console.WriteLine("Nome de todos os nossos UBUNTUS :" + Agrupamento);

            //imc = peso / (altura * altura)
            Console.WriteLine("=====================================================");
            double imc1 = peso1 / (altura1 * altura1);
            Console.WriteLine("Situação IMC de:" + nome1);
            {
                if (imc1 < 18.49)
                    Console.WriteLine("SITUAÇÃO: Você está abaixo do Peso.");
                else if (imc1 < 24.99)
                    Console.WriteLine("SITUAÇÃO: Você está com peso dentro da normalidade.");
                else if (imc1 < 29.99)
                    Console.WriteLine("SITUAÇÃO: Você está acima do peso.");
                else if (imc1 < 34.99)
                    Console.WriteLine("SITUAÇÃO: Atenção, você está com Obesidade Grau I.");
                else if (imc1 < 39.99)
                    Console.WriteLine("SITUAÇÃO: Atenção você está com Obesidade Grau II(SEVERA)");
                else if (imc1 >= 40.00)
                    Console.WriteLine("SITUAÇÃO: Atenção, você está com Obesidade Grau III (mórbida)");
            }
            double imc2 = peso2 / (altura2 * altura2);
            Console.WriteLine("Situação IMC de:" + nome2);
            {
                if (imc2 < 18.49)
                    Console.WriteLine("SITUAÇÃO: Você está abaixo do Peso.");
                else if (imc2 < 24.99)
                    Console.WriteLine("SITUAÇÃO: Você está com peso dentro da normalidade.");
                else if (imc2 < 29.99)
                    Console.WriteLine("SITUAÇÃO: Você está acima do peso.");
                else if (imc2 < 34.99)
                    Console.WriteLine("SITUAÇÃO: Atenção, você está com Obesidade Grau I.");
                else if (imc2 < 39.99)
                    Console.WriteLine("SITUAÇÃO: Atenção você está com Obesidade Grau II(SEVERA)");
                else if (imc2 >= 40.00)
                    Console.WriteLine("SITUAÇÃO: Atenção, você está com Obesidade Grau III (mórbida)");
            }
            double imc3 = peso3 / (altura3 * altura3);
            Console.WriteLine("Situação IMC de:" + nome3);
            {
                if (imc3 < 18.49)
                    Console.WriteLine("SITUAÇÃO: Você está abaixo do Peso.");
                else if (imc3 < 24.99)
                    Console.WriteLine("SITUAÇÃO: Você está com peso dentro da normalidade.");
                else if (imc3 < 29.99)
                    Console.WriteLine("SITUAÇÃO: Você está acima do peso.");
                else if (imc3 < 34.99)
                    Console.WriteLine("SITUAÇÃO: Atenção, você está com Obesidade Grau I.");
                else if (imc3 < 39.99)
                    Console.WriteLine("SITUAÇÃO: Atenção você está com Obesidade Grau II(SEVERA)");
                else if (imc3 >= 40.00)
                    Console.WriteLine("SITUAÇÃO: Atenção, você está com Obesidade Grau III (mórbida)");
            }
            Console.WriteLine("=====================================================");
            Console.WriteLine("Os nossos ubuntus devs são:");
            {
                if (EhDev1 == true)
                    Console.WriteLine(nome1);
                if (EhDev2 == true)
                    Console.WriteLine(nome2);
                if (EhDev3 == true)
                    Console.WriteLine(nome3);
            }
            Console.WriteLine("=====================================================");
            Console.WriteLine("UBUNTU 002 END...");
            Console.ReadKey();
        }
    }
}
