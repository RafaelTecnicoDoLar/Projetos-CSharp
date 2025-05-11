using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace CRUD
{
    internal class Deletar : Atributos
    {
        public void DeletarAtributo(List<Atributos> atributos)
        {
            Menu menu = new Menu();
            LerAtributo(atributos);
            
            Console.Write("Insira o código do perfil a ser exclído: ");
            int Resposta = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Você tem certeza que deseja apagar o perfil abaixo?");
            var atributo = atributos[Resposta - 1];

            Console.WriteLine($"Nome: {atributo.Nome}");
            Console.WriteLine($"Sobrenome: {atributo.Sobrenome}");
            Console.WriteLine($"Data de Nascimento: {atributo.DataNascimento.ToShortDateString()}");

            Console.Write("Digite 'sim' para confirmar: ");
            string Resposta1 = Console.ReadLine();
            if (Resposta1 == "sim")
            {
                atributos.RemoveAt(Resposta - 1);
                Atributos.SalvarDados(atributos);
            }
            else
            {
                Console.WriteLine("Dados inválidos, tente novamente!");
                Console.WriteLine("Precione enter para continuar...");
                Console.ReadLine();
                DeletarAtributo(atributos);
            }
            menu.ExibirMenu(atributos);
        }
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
