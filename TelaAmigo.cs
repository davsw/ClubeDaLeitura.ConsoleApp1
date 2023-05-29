using ClubeDaLeitura.ConsoleApp.Compartilhado;
using ClubeDaLeitura.ConsoleApp.ModuloCaixa;
using ClubeDaLeitura.ConsoleApp.ModuloRevista;
using System.Collections;

namespace ClubeDaLeitura.ConsoleApp.ModuloAmigo
{
    public class TelaAmigo : TelaBase
    {
        public TelaAmigo(RepositorioAmigo repositorioAmigo)
        {
            this.repositorioBase = repositorioAmigo;
        }

        protected override void MostrarTabela(ArrayList amigos)
        {
            Console.WriteLine("{0, -10} | {1, -40} | {2, -20}", "Id", "Nome", "Telefone");

            Console.WriteLine("-------------------------------------------------------------------------");

            foreach (Amigo amigo in amigos)
            {
                Console.WriteLine("{0, -10} | {1, -40} | {2, -20}", amigo.id, amigo.nome, amigo.telefone);
            }
        }

        protected override EntidadeBase ObterRegistro()
        {
            Console.Write("Digite o nome: ");
            string nome = Console.ReadLine();

            Console.Write("Digite o nome do responsável: ");
            string nomeResponsavel = Console.ReadLine();

            Console.Write("Digite o telefone: ");
            string telefone = Console.ReadLine();

            Console.Write("Digite o endereço: ");
            string endereco = Console.ReadLine();

            Amigo amigo = new Amigo(nome, nomeResponsavel, telefone, endereco);

            return amigo;
        }
    }
}