using System;

namespace ClubeDaLeitura.ConsoleApp1.Compartilhado

    public abstract class RepositorioBase
    {
        protected ArrayList listaRegistros;
        protected int contadorRegistros = 0;

        public virtual void Inserir(EntidadeBase registro)
        {
            contadorRegistros++;

            registro.id = contadorRegistros;

            listaRegistros.Add(registro);
        }

        public virtual void Editar(int id, EntidadeBase registroAtualizado)
        {
            EntidadeBase registroSelecionado = SelecionarPorId(id);

            registroSelecionado.AtualizarInformacoes(registroAtualizado);
        }

        public virtual void Excluir(int id)
        {
            EntidadeBase registroSelecionado = SelecionarPorId(id);

            listaRegistros.Remove(registroSelecionado);
        }

        public virtual EntidadeBase SelecionarPorId(int id)
        {
            EntidadeBase registroSelecionado = null;

            foreach (EntidadeBase registro in listaRegistros)
            {
                if (registro.id == id)
                {
                    registroSelecionado = registro;
                    break;
                }
            }

            return registroSelecionado;
        }

        public virtual ArrayList SelecionarTodos()
        {
            return listaRegistros;
        }

    }
