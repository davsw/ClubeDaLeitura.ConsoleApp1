using ClubeDaLeitura.ConsoleApp.Compartilhado;
using System.Collections;

namespace ClubeDaLeitura.ConsoleApp.ModuloEmprestimo
{
    public class RepositorioEmprestimo : RepositorioBase
    {
        public RepositorioEmprestimo(ArrayList listaEmprestimos)
        {
            this.listaRegistros = listaEmprestimos;
        }

        public override Emprestimo SelecionarPorId(int id)
        {
            return (Emprestimo)base.SelecionarPorId(id);
        }

        public ArrayList SelecionarEmprestimosEmAberto()
        {
            ArrayList emprestimoEmAberto = new ArrayList();

            foreach (Emprestimo e in listaRegistros)
            {
                if (e.estaAberto)
                    emprestimoEmAberto.Add(e);
            }

            return emprestimoEmAberto;
        }

        public ArrayList SelecionarEmprestimosEmAbertoNoDia(DateTime data)
        {
            ArrayList emprestimoEmAberto = new ArrayList();

            foreach (Emprestimo e in listaRegistros)
            {
                if (e.estaAberto && e.dataEmprestimo.Date == data.Date)
                    emprestimoEmAberto.Add(e);
            }

            return emprestimoEmAberto;
        }

        public ArrayList SelecionarEmprestimosDoMes(int mes, int ano)
        {
            ArrayList emprestimosDoMes = new ArrayList();

            foreach (Emprestimo e in listaRegistros)
            {
                if (e.dataEmprestimo.Month == mes && e.dataEmprestimo.Year == ano)
                    emprestimosDoMes.Add(e);
            }

            return emprestimosDoMes;
        }
    }
}