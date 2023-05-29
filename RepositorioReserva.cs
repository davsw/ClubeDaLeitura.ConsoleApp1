using ClubeDaLeitura.ConsoleApp.Compartilhado;
using System.Collections;

namespace ClubeDaLeitura.ConsoleApp.ModuloReserva
{
    public class RepositorioReserva : RepositorioBase
    {
        public RepositorioReserva(ArrayList lista)
        {
            this.listaRegistros = lista;
        }

        public override Reserva SelecionarPorId(int id)
        {
            return (Reserva)base.SelecionarPorId(id);
        }
    }
}