using ClubeDaLeitura.ConsoleApp1.Compartilhado;
    public abstract class EntidadeBase
    {
        public int id;

        public abstract void AtualizarInformacoes(EntidadeBase registroAtualizado);
    }