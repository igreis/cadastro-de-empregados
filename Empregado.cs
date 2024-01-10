using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividade2_ex1
{
    internal class Empregado
    {
        private string nome;
        private string cpf;
        private string endereco;

        public Empregado() { }

        public string Nome { get => nome; set => nome = value; }
        public string Cpf { get => cpf; set => cpf = value; }
        public string Endereco { get => endereco; set => endereco = value; }

        public void InserirDadosEmpregados()
        {
            Console.WriteLine("Digite o nome:");
            Nome = Console.ReadLine();
            Console.WriteLine("Digite o cpf:");
            Cpf = Console.ReadLine();
            Console.WriteLine("Digite o endereço");
            Endereco = Console.ReadLine();  

        }
    }
}
