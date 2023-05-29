using ClubeDaLeitura.ConsoleApp.Compartilhado;
using ClubeDaLeitura.ConsoleApp.ModuloAmigo;
using ClubeDaLeitura.ConsoleApp.ModuloRevista;

namespace ClubeDaLeitura.ConsoleApp.ModuloReserva
{
    public class Reserva : EntidadeBase
    {
        public Amigo amigo;

        public Revista revista;

        public DateTime dataReserva;

        public Reserva(Revista revista, Amigo amigo, DateTime dataReserva)
        {
            this.revista = revista;
            this.amigo = amigo;
            this.dataReserva = dataReserva;
        }
    }
}