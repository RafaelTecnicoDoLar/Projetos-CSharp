using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace CRUD
{
    internal class Atributos
    {
        public string Nome;
        public string Sobrenome;
        public DateTime DataNascimento;

        public static void SalvarDados(List<Atributos> atributos)
        {
            try
            {
                string json = JsonConvert.SerializeObject(atributos, Formatting.Indented);
                File.WriteAllText("Lista.json", json);
                Console.WriteLine("Dados salvos com sucesso!");
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao salvar os dados: " + ex.Message);
                Console.ReadLine();
            }
        }
    }
}