using System;

namespace ClubeDaLeitura.ConsoleApp.ModuloAmigo
{
    public class Amigo : EntidadeBase
    {

        public string nome;
        public string nomeResponsavel;
        public string telefone;
        public string endereco;

        public Amigo(string nome, string nomeResponsavel, string telefone, string endereco)
        {
            this.nome = nome;
            this.nomeResponsavel = nomeResponsavel;
            this.telefone = telefone;
            this.endereco = endereco;
        }

        public override void AtualizarInformacoes(EntidadeBase registroAtualizado)
        {
            Amigo amigoAtualizado = (Amigo)registroAtualizado;

            nome = amigoAtualizado.nome;
            nomeResponsavel = amigoAtualizado.nomeResponsavel;
            telefone = amigoAtualizado.telefone;
            endereco = amigoAtualizado.endereco;
        }
    }
}