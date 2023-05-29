using System;
using System.Collections;

namespace ClubeDaLeitura.ConsoleApp1.Compartilhado

{
    public abstract class TelaBase
    {
        public string nomeEntidade;
        protected RepositorioBase repositorioBase = null;

        public void MostrarCabecalho(string titulo, string subtitulo)
        {
            Console.Clear();

            Console.WriteLine(titulo + "\n");

            Console.WriteLine(subtitulo + "\n");
        }

        public void MostrarMensagem(string mensagem, ConsoleColor cor)
        {
            Console.WriteLine();

            Console.ForegroundColor = cor;

            Console.WriteLine(mensagem);

            Console.ResetColor();

            Console.ReadLine();
        }

        public virtual string ApresentarMenu() // TelaCaixa, TelaAmigo e na TelaRevista
        {
            Console.Clear();

            Console.WriteLine($"Cadastro de {nomeEntidade}s \n");

            Console.WriteLine($"Digite 1 para Inserir {nomeEntidade}");
            Console.WriteLine($"Digite 2 para Visualizar {nomeEntidade}s");
            Console.WriteLine($"Digite 3 para Editar {nomeEntidade}s");
            Console.WriteLine($"Digite 4 para Excluir {nomeEntidade}s");

            Console.WriteLine("Digite s para Sair");

            string opcao = Console.ReadLine();

            return opcao;
        }

        public void InserirNovoRegistro()
        {
            MostrarCabecalho($"Cadastro de {nomeEntidade}s", "Inserindo um novo registro...");

            EntidadeBase registro = ObterRegistro();

            repositorioBase.Inserir(registro);

            MostrarMensagem("Registro inserido com sucesso!", ConsoleColor.Green);
        }

        public void VisualizarRegistros(bool mostrarCabecalho)
        {
            if (mostrarCabecalho)
                MostrarCabecalho($"Cadastro de {nomeEntidade}s", "Visualizando registros já cadastrados...");

            ArrayList registros = repositorioBase.SelecionarTodos();
            
            if (registros.Count == 0)
            {
                MostrarMensagem("Nenhum registro cadastrado", ConsoleColor.DarkYellow);
                return;
            }

            MostrarTabela(registros);
        }

        public void EditarRegistro()
        {
            MostrarCabecalho($"Cadastro de {nomeEntidade}s", "Editando um registro já cadastrado...");

            VisualizarRegistros(false);

            Console.WriteLine();

            Console.Write("Digite o id do registro: ");
            int id = Convert.ToInt32(Console.ReadLine());

            EntidadeBase registroAtualizado = ObterRegistro();

            repositorioBase.Editar(id, registroAtualizado);

            MostrarMensagem("Registro editado com sucesso!", ConsoleColor.Green);
        }

        public virtual void ExcluirRegistro()
        {
            MostrarCabecalho($"Cadastro de {nomeEntidade}s", "Excluindo um registro já cadastrado...");

            VisualizarRegistros(false);

            Console.WriteLine();

            Console.Write("Digite o id do amigo: ");
            int id = Convert.ToInt32(Console.ReadLine());

            repositorioBase.Excluir(id);

            MostrarMensagem("Registro excluído com sucesso!", ConsoleColor.Green);
        }

        protected abstract EntidadeBase ObterRegistro();

        protected abstract void MostrarTabela(ArrayList registros);

    }
}
