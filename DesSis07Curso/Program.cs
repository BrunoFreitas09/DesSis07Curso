using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesSis07Empresa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double Funcionario = 0;
            int resp;       
             resp = 1;
             double salTota = 0;

            while (resp == 1)
            {
                Console.WriteLine("Informe o tipo de contratacao do funcionário: " +
                    "Assaláriado{1}/Comisssionado{2}/Horista{3}");
                double tipo = double.Parse(Console.ReadLine());


                switch (tipo)
                {
                    case 1:
                        Console.WriteLine("Informe o valor do salário: ");
                        double salario = double.Parse(Console.ReadLine());

                        Console.WriteLine("Informe o valor do desconto: ");
                        double desc = double.Parse(Console.ReadLine());

                         salario = salario - desc;
                    break;

                    case 2:
                        Console.WriteLine("Informe o valor da comissão ganha por venda: ");
                        double comis = double.Parse(Console.ReadLine());

                        Console.WriteLine("Informe quantas vendas ele fez: ");
                        double qtdVen = double.Parse(Console.ReadLine());

                         salario = comis * qtdVen;
                    break;

                    case 3:
                        Console.WriteLine("Valor ganho por hora trabalhada: ");
                        double ValHr = double.Parse(Console.ReadLine());

                        Console.WriteLine("Informe quantas horas ele trabalhou: ");
                        double qtdHr = double.Parse(Console.ReadLine());

                        salario = ValHr * qtdHr;
                        break;
                        salTota = salTota + salario;
                        Funcionario++;
                        Console.WriteLine("Deseja continuar? {s=1/n=2}");
                        Console.ReadLine();
                }

                Console.WriteLine("Deseja continuar? {s=1/n=2}");
                Console.ReadLine();


                    Console.ReadKey();
            }










            Console.ReadKey();
        }
    }
}
