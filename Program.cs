using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividade2_ex1
{
    internal class Program
    {

        Empregado[] empregados = new Empregado[10];
        int index = 0;

        static void Main(string[] args)
        {
            Program program = new Program();

            Console.WriteLine("Bem-vindo(a) ao Menu de Contabilidade e Recursos Humanos");

            int input = 0;

            while(input < 4)
            {
                Console.WriteLine("\n[1] – Cadastrar Empregado CLT" +
                    "\n[2] – Cadastrar Empregado Horista"+
                    "\n[3] – Imprimir Relatório de Empregados"+
                    "\n[4] – Sair");
                input = int.Parse(Console.ReadLine());

                if (input == 1) program.InserirCLT();
                if (input == 2) program.InserirHorista();
                if (input == 3) program.Imprimir();            
            }
        }

        public void InserirCLT()
        {
            Console.Clear();
            EmpregadoCLT empregadoCLT = new EmpregadoCLT();
            empregadoCLT.InserirDadosCLT();
            empregados[index] = empregadoCLT;
            index++;
        }

        public void InserirHorista()
        {
            Console.Clear();
            EmpregadoHorista empregadoHorista = new EmpregadoHorista();
            empregadoHorista.InserirDadosHorista();
            empregados[index] = empregadoHorista;
            index++;
        }

        public void Imprimir()
        {
            Console.Clear();
            Console.WriteLine("Relatório de Empregados");

            for(int i = 0; i < index; i++) 
            {
                Console.WriteLine("Nome: " + empregados[i].Nome );
                Console.WriteLine("Cpf: " + empregados[i].Cpf);
                Console.WriteLine("Endereço: " + empregados[i].Endereco);
                if (empregados[i].GetType() == typeof(EmpregadoCLT))
                {
                    Console.WriteLine("Categoria: EmpregadoCLT");
                    EmpregadoCLT empregado = (EmpregadoCLT)empregados[i];
                    Console.WriteLine("Salário Bruto: " + empregado.SBrutoCLT);
                    Console.WriteLine("Salário Líquido " + empregado.SLiqCLT);
                }
                else
                {
                    Console.WriteLine("Categoria: EmpregadoHorista");
                    EmpregadoHorista empregado = (EmpregadoHorista)empregados[i];
                    Console.WriteLine("Número de Horas: " + empregado.NHoras);
                    Console.WriteLine("Preço Horas: " + empregado.PrecoH);
                    Console.WriteLine("Salário líquido: " + empregado.SalLiqH);
                }
            }
            
        }

    }
}
