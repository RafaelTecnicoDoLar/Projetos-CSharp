using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD
{
    internal class Ler : Atributos
    {
        
        public void LerAtributo(List<Atributos> atributos)
        {
            Console.Clear();
            Menu menu = new Menu();

            if (atributos.Count == 0)
            {
                Console.WriteLine("Nenhum atributo encontrado.");
            }

            else
            {
                int contador = 001;
                foreach (var atributo in atributos)
                {

                    int idade = CalcularIdade(atributo.DataNascimento);
                    Console.WriteLine($"Codígo: [{contador}]");
                    Console.WriteLine($"Nome: {atributo.Nome}");
                    Console.WriteLine($"Sobrenome: {atributo.Sobrenome}");
                    Console.WriteLine($"Data de Nascimento: {atributo.DataNascimento.ToShortDateString()}");
                    Console.WriteLine($"Idade: {idade} anos");
                    Console.WriteLine("-------------------------------");
                    contador++;
                }
            }
                Console.ReadLine();
                menu.ExibirMenu(atributos);
        }
        private int CalcularIdade(DateTime dataNascimento)
        {
            DateTime hoje = DateTime.Today;
            int idade = hoje.Year - dataNascimento.Year;
            if (dataNascimento.Date > hoje.AddYears(-idade)) idade--;
            return idade;
        }
    }
}
