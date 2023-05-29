using ClubeDaLeitura.ConsoleApp.Compartilhado;
using System.Collections;

namespace ClubeDaLeitura.ConsoleApp.ModuloLivro
{
    public class RepositorioLivro : RepositorioBase
    {
        public RepositorioLivro(ArrayList lista)
        {
            this.listaRegistros = lista;
        }

        public override Livro SelecionarPorId(int id)
        {
            return (Livro)base.SelecionarPorId(id);
        }
    }
}