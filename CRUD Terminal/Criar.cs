using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD
{
    internal class Criar : Atributos
    {
        public void AdicionarAtributo(List <Atributos> atributos)
        {
            Console.Clear();
            Atributos novoAtributo = new Atributos();
            Menu menu = new Menu();
            Console.Write("Insira seu primeiro nome: ");
            novoAtributo.Nome = Console.ReadLine();

            Console.Write("Insira seu sobrenome: ");
            novoAtributo.Sobrenome = Console.ReadLine();

            Console.Write("Insira sua data de nascimento: ");
            novoAtributo.DataNascimento = Convert.ToDateTime(Console.ReadLine());

            atributos.Add(novoAtributo);
            Atributos.SalvarDados(atributos);

            menu.ExibirMenu(atributos);
        }
    }
}