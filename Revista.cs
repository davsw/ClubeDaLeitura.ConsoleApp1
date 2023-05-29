using ClubeDaLeitura.ConsoleApp.Compartilhado;
using ClubeDaLeitura.ConsoleApp.ModuloCaixa;

namespace ClubeDaLeitura.ConsoleApp.ModuloRevista
{
    public class Revista : EntidadeBase
    {

        public string titulo;
        public int edicao;
        public int ano;
        public Caixa caixa;

        public Revista(string titulo, int edicao, int ano, Caixa caixa)
        {
            this.titulo = titulo;
            this.edicao = edicao;
            this.ano = ano;
            this.caixa = caixa;
        }

        public override void AtualizarInformacoes(EntidadeBase registroAtualizado)
        {
            Revista revistaAtualizada = (Revista)registroAtualizado;

            titulo = revistaAtualizada.titulo;
            ano = revistaAtualizada.ano;
            edicao = revistaAtualizada.edicao;
            caixa = revistaAtualizada.caixa;
        }

    }
}