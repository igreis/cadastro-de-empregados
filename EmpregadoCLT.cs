using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividade2_ex1
{
    internal class EmpregadoCLT : Empregado
    {
        private double sBrutoCLT;
        private double sLiqCLT;

        public EmpregadoCLT() { }

        public double SBrutoCLT {  get { return sBrutoCLT; } set { sBrutoCLT = value; } } 
        public double SLiqCLT { get { return sLiqCLT; } set { sLiqCLT = value; } }

        public double SalarioCLT()
        {
            if (SBrutoCLT <= 5000) return (SBrutoCLT * 0.85);
            else return (SBrutoCLT * 0.725);               
        }

        public void InserirDadosCLT()
        {
            try
            {
                InserirDadosEmpregados();
                Console.WriteLine("Informa o salario bruto:");
                SBrutoCLT = double.Parse(Console.ReadLine());
                SLiqCLT = SalarioCLT();
            } catch (FormatException ex)
            {
                Console.WriteLine($"Erro: { ex.Message}");
            }
        }

    }
}
