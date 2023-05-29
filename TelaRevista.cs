using ClubeDaLeitura.ConsoleApp.ModuloCaixa;
using ClubeDaLeitura.ConsoleApp.Compartilhado;
using System.Collections;

namespace ClubeDaLeitura.ConsoleApp.ModuloRevista
{
    public class TelaRevista : TelaBase
    {
        private RepositorioRevista repositorioRevista;
        private RepositorioCaixa repositorioCaixa;
        private TelaCaixa telaCaixa;

        public TelaRevista(RepositorioRevista repositorioRevista,
            RepositorioCaixa repositorioCaixa, TelaCaixa telaCaixa)
        {
            this.repositorioBase = repositorioRevista;
            this.repositorioRevista = repositorioRevista;
            this.repositorioCaixa = repositorioCaixa;
            this.telaCaixa = telaCaixa;
        }

        protected override void MostrarTabela(ArrayList revistas)
        {
            Console.WriteLine("{0, -10} | {1, -40} | {2, -20}", "Id", "Título", "Cor da Caixa");

            Console.WriteLine("---------------------------------------------------------");

            foreach (Revista revista in revistas)
            {
                Console.WriteLine("{0, -10} | {1, -40} | {2, -20}", revista.id, revista.titulo, revista.caixa.cor);
            }
        }

        protected override EntidadeBase ObterRegistro()
        {
            telaCaixa.VisualizarRegistros(false);

            Console.Write("Digite o id da caixa: ");
            int idCaixa = Convert.ToInt32(Console.ReadLine());
            Caixa caixa = repositorioCaixa.SelecionarPorId(idCaixa);

            Console.Write("Digite o título: ");
            string titulo = Console.ReadLine();

            Console.Write("Digite o ano: ");
            int ano = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite a edição: ");
            int edicao = Convert.ToInt32(Console.ReadLine());

            Revista revista = new Revista(titulo, edicao, ano, caixa);

            return revista;
        }
    }
}