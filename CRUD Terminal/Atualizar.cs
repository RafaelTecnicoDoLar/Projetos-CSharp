using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD
{
    internal class Atualizar
    {
        
        public void AtualizarAtributo(List<Atributos> atributos)
        {
            Menu menu = new Menu();
            LerAtributo(atributos);
            Atributos novoAtributo = new Atributos();

            Console.Write("Insira o código do perfil a ser editado: ");
            int Resposta = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("Insira seu primeiro nome: ");
            novoAtributo.Nome = Console.ReadLine();
            
            Console.Write("Insira seu sobrenome: ");
            novoAtributo.Sobrenome = Console.ReadLine();

            Console.Write("Insira sua data de nascimento: ");
            novoAtributo.DataNascimento = Convert.ToDateTime(Console.ReadLine());

            atributos.Add(novoAtributo);
            atributos.RemoveAt(Resposta - 1);
            Atributos.SalvarDados(atributos);

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
