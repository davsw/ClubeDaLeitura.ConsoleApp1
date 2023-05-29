using ClubeDaLeitura.ConsoleApp.Compartilhado;
using ClubeDaLeitura.ConsoleApp.ModuloRevista;
using System.Collections;

namespace ClubeDaLeitura.ConsoleApp.ModuloCaixa
{
    public class TelaCaixa : TelaBase
    {
        private RepositorioCaixa repositorioCaixa;
        private RepositorioRevista repositorioRevista;

        public TelaCaixa(RepositorioCaixa repositorioCaixa, RepositorioRevista repositorioRevista)
        {
            this.repositorioBase = repositorioCaixa;
            this.repositorioCaixa = repositorioCaixa;
            this.repositorioRevista = repositorioRevista;
        }

        public override void ExcluirRegistro()
        {
            MostrarCabecalho("Cadastro de Caixas", "Excluindo uma caixa já cadastrada...");

            VisualizarRegistros(false);

            Console.WriteLine();

            Console.Write("Digite o id da caixa: ");
            int id = Convert.ToInt32(Console.ReadLine());

            Caixa caixa = repositorioCaixa.SelecionarPorId(id);

            bool caixaTemRevista = repositorioRevista.EstaCaixaTemRevista(caixa);

            if (caixaTemRevista)
            {
                MostrarMensagem("Esta caixa tem revista", ConsoleColor.DarkYellow);
                return;
            }

            repositorioCaixa.Excluir(id);

            MostrarMensagem("Caixa excluída com sucesso!", ConsoleColor.Green);
        }

        protected override EntidadeBase ObterRegistro()
        {
            Console.Write("Digite a cor: ");
            string cor = Console.ReadLine();

            Console.Write("Digite a etiqueta: ");
            string etiqueta = Console.ReadLine();

            Caixa caixa = new Caixa(cor, etiqueta);

            return caixa;
        }

        protected override void MostrarTabela(ArrayList caixas)
        {
            Console.WriteLine("{0, -10} | {1, -20} | {2, -20}", "Id", "Etiqueta", "Cor");

            Console.WriteLine("---------------------------------------------------------");

            foreach (Caixa caixa in caixas)
            {
                Console.WriteLine("{0, -10} | {1, -20} | {2, -20}", caixa.id, caixa.etiqueta, caixa.cor);
            }
        }

    }
}