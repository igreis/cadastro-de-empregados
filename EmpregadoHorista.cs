using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividade2_ex1
{
    internal class EmpregadoHorista : Empregado
    {
        private int nHoras;
        private double precoH;
        private double salLiqH;

        public EmpregadoHorista() { }

        public int NHoras { get => nHoras; set => nHoras = value; }
        public double PrecoH { get => precoH; set => precoH = value; }
        public double SalLiqH { get => salLiqH; set => salLiqH = value; }

        public double SalarioH()
        {
            return NHoras * PrecoH * 0.85;
        }

        public void InserirDadosHorista()
        {
            InserirDadosEmpregados();
            Console.WriteLine("Informe o preco por hora");
            
            try
            {
                PrecoH = double.Parse(Console.ReadLine());
                Console.WriteLine("informe numero de horas");
                NHoras = int.Parse(Console.ReadLine());
            } catch (FormatException ex) { Console.WriteLine($"Erro: {ex.Message} Tente novamente!");}
            
            SalLiqH = SalarioH();
            
        }
    }
}
