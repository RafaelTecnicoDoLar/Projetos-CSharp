using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.IO;
using Newtonsoft.Json;
using System.Threading;

namespace CRUD
{
    internal class Program : Atributos
    {
        static List<Atributos> CarregarDados()
        {
            try
            {
                if (File.Exists("Lista.json"))
                {
                    string json = File.ReadAllText("Lista.json");
                    Console.WriteLine("Dados carregados com sucesso!");
                    Thread.Sleep(1000);
                    return JsonConvert.DeserializeObject<List<Atributos>>(json);
                }
                else
                {
                    Console.WriteLine("Arquivo Lista.json não encontrado. Criando uma nova lista.");
                    Thread.Sleep(3000);

                    return new List<Atributos>();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao carregar os dados: " + ex.Message);
                Thread.Sleep(3000);
                Console.ReadLine();
                return new List<Atributos>();
            }
        }
        static void Main()
        {
            Atributos atributo = new Atributos();
            Menu menu = new Menu();

            List<Atributos> atributos = CarregarDados();
            menu.ExibirMenu(atributos);
        }
    }
}