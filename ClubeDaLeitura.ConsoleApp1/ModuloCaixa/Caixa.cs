
using ClubeDaLeitura.ConsoleApp.Compartilhado;

namespace ClubeDaLeitura.ConsoleApp.ModuloCaixa
{
    public class Caixa : EntidadeBase
    {
        //atributos        
        public string cor;
        public string etiqueta;

        public Caixa(string c, string e)
        {
            cor = c;
            etiqueta = e;
        }

        public override void AtualizarInformacoes(EntidadeBase registroAtualizado)
        {
            Caixa caixaAtualizada = (Caixa)registroAtualizado;

            cor = caixaAtualizada.cor;
            etiqueta = caixaAtualizada.etiqueta;
        }

    }
}