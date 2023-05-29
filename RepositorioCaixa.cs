using ClubeDaLeitura.ConsoleApp.Compartilhado;
using System.Collections;

namespace ClubeDaLeitura.ConsoleApp.ModuloCaixa
{
    public class RepositorioCaixa : RepositorioBase
    {
        public RepositorioCaixa(ArrayList lista)
        {
            listaRegistros = lista;
        }

        public override Caixa SelecionarPorId(int id)
        {
            return (Caixa)base.SelecionarPorId(id);
        }
    }
}