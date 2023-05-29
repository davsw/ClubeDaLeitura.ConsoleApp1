using ClubeDaLeitura.ConsoleApp.Compartilhado;
using ClubeDaLeitura.ConsoleApp.ModuloCaixa;
using System.Collections;

namespace ClubeDaLeitura.ConsoleApp.ModuloRevista
{
    public class RepositorioRevista : RepositorioBase
    {
        public RepositorioRevista(ArrayList lista)
        {
            this.listaRegistros = lista;
        }

        public override Revista SelecionarPorId(int id)
        {
            return (Revista)base.SelecionarPorId(id);
        }

        public bool EstaCaixaTemRevista(Caixa caixa)
        {
            bool caixaTemRevista = false;

            foreach (Revista revista in listaRegistros)
            {
                if (revista.caixa.id == caixa.id)
                {
                    caixaTemRevista = true;
                    break;
                }
            }

            return caixaTemRevista;
        }
    }
}