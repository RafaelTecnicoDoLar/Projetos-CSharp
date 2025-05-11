using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CRUD
{
    internal class Menu : Atributos
    {
        Criar criar = new Criar();
        Ler ler = new Ler();
        Atualizar atualizar = new Atualizar();
        Deletar deletar = new Deletar();

        public void ExibirMenu(List<Atributos> atributos)
        {
            Console.Clear();
            Console.WriteLine("[1] Create (Criar)");
            Console.WriteLine("[2] Read (Ler)");
            Console.WriteLine("[3] Update (Atualizar)");
            Console.WriteLine("[4] Delete (Deletar)");
            Console.WriteLine("[9] Exit (Sair)");

            int Resposta = Convert.ToInt32(Console.ReadLine());

            switch (Resposta)
            {
                case 1:
                    criar.AdicionarAtributo(atributos);

                    break;

                case 2:
                    ler.LerAtributo(atributos);

                    break;

                case 3:
                    atualizar.AtualizarAtributo(atributos);

                    break;

                case 4:
                    deletar.DeletarAtributo(atributos);

                    break;

                case 9:
                    Console.Clear();
                    Console.Write("Salvando");
                    Thread.Sleep(500);
                    Console.Write(".");
                    Thread.Sleep(500);
                    Console.Write(".");
                    Thread.Sleep(500);
                    Console.WriteLine(".");
                    Atributos.SalvarDados(atributos);
                    break;

                case 69:
                    //Ester Egg
                    Console.WriteLine("Então que dizer que você gosta de bater em mulher?");
                    Thread.Sleep(3000);
                    Console.Write("Criptografando dados e mandando para o FBI");
                    Thread.Sleep(1000);
                    Console.Write(".");
                    Thread.Sleep(1000);
                    Console.Write(".");
                    Thread.Sleep(1000);
                    Console.WriteLine(".");
                    Console.ReadLine();
                    break;

                default:
                    Console.Clear();
                    Console.WriteLine("Dados inválidos, tente novamente!");
                    Console.WriteLine("Precione enter para continuar...");
                    Console.ReadLine();
                    ExibirMenu(atributos);

                    break;
            }
        }
    }
}