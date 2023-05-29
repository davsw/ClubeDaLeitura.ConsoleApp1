using ClubeDaLeitura.ConsoleApp.ModuloRevista;
using ClubeDaLeitura.ConsoleApp.ModuloAmigo;
using ClubeDaLeitura.ConsoleApp.Compartilhado;

namespace ClubeDaLeitura.ConsoleApp.ModuloEmprestimo
{
    public class Emprestimo : EntidadeBase
    {
        public DateTime dataEmprestimo;
        public DateTime dataDevolucao;
        public Revista revista;
        public Amigo amiguinho;

        public bool estaAberto;

        public Emprestimo(DateTime dataEmprestimo, Revista revista, Amigo amiguinho)
        {
            this.dataEmprestimo = dataEmprestimo;
            this.revista = revista;
            this.amiguinho = amiguinho;
            estaAberto = true;
        }

        public void Fechar()
        {
            if (estaAberto)
            {
                estaAberto = false;
                dataDevolucao = DateTime.Now;
            }
        }

        public override void AtualizarInformacoes(EntidadeBase registroAtualizado)
        {
            Emprestimo emprestimoAtualizado = (Emprestimo)registroAtualizado;

            amiguinho = emprestimoAtualizado.amiguinho;
            revista = emprestimoAtualizado.revista;
            dataEmprestimo = emprestimoAtualizado.dataEmprestimo;
            dataDevolucao = emprestimoAtualizado.dataDevolucao;
        }
    }
}