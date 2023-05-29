using ClubeDaLeitura.ConsoleApp.Compartilhado;
using ClubeDaLeitura.ConsoleApp.ModuloAmigo;
using ClubeDaLeitura.ConsoleApp.ModuloCaixa;
using ClubeDaLeitura.ConsoleApp.ModuloEmprestimo;
using ClubeDaLeitura.ConsoleApp.ModuloReserva;
using ClubeDaLeitura.ConsoleApp.ModuloRevista;
using ClubeDaLeitura.ConsoleApp1;
using System;
using System.Collections;

namespace ClubeDaLeitura.ConsoleApp
{


    internal class Program
    {
        static void Main(string[] args)
        {

            RepositorioAmigo repositorioAmigo = new RepositorioAmigo(new ArrayList());
            RepositorioCaixa repoCaixa = new RepositorioCaixa(new ArrayList());
            RepositorioRevista repositorioRevista = new RepositorioRevista(new ArrayList());
            RepositorioEmprestimo repositorioEmprestimo = new RepositorioEmprestimo(new ArrayList());

            RepositorioReserva repositorioReserva = new RepositorioReserva(new ArrayList());

            PopularRepositorios(repositorioAmigo, repoCaixa, repositorioRevista, repositorioEmprestimo);

            TelaCaixa telaCaixa = new TelaCaixa(repoCaixa, repositorioRevista);
            telaCaixa.nomeEntidade = "Caixa";

            TelaAmigo telaAmigo = new TelaAmigo(repositorioAmigo);
            telaAmigo.nomeEntidade = "Amigo";

            TelaRevista telaRevista = new TelaRevista(repositorioRevista, repoCaixa, telaCaixa);
            telaRevista.nomeEntidade = "Revista";

            TelaEmprestimo telaEmprestimo = new TelaEmprestimo
                (repositorioEmprestimo, telaRevista, repositorioRevista, telaAmigo, repositorioAmigo);

            telaEmprestimo.nomeEntidade = "Empréstimo";

            TelaReserva telaReserva = new TelaReserva(repositorioReserva, telaRevista, repositorioRevista, repositorioAmigo, telaAmigo);
            telaReserva.nomeEntidade = "Reserva";

            TelaPrincipal telaPrincipal = new TelaPrincipal();

            while (true)
            {
                string opcao = telaPrincipal.ApresentarMenu();

                if (opcao == "s")
                    break;

                if (opcao == "1")
                {
                    string opcaoCaixa = telaCaixa.ApresentarMenu();

                    if (opcaoCaixa == "1")
                    {
                        telaCaixa.InserirNovoRegistro();
                    }
                    else if (opcaoCaixa == "2")
                    {
                        telaCaixa.VisualizarRegistros(true);
                        Console.ReadLine();
                    }
                    else if (opcaoCaixa == "3")
                    {
                        telaCaixa.EditarRegistro();
                    }
                    else if (opcaoCaixa == "4")
                    {
                        telaCaixa.ExcluirRegistro();
                    }

                    continue;
                }
                else if (opcao == "2")
                {
                    string opcaoAmigo = telaAmigo.ApresentarMenu();

                    if (opcaoAmigo == "1")
                    {
                        telaAmigo.InserirNovoRegistro();
                    }
                    else if (opcaoAmigo == "2")
                    {
                        telaAmigo.VisualizarRegistros(true);
                        Console.ReadLine();
                    }
                    else if (opcaoAmigo == "3")
                    {
                        telaAmigo.EditarRegistro();
                    }
                    else if (opcaoAmigo == "4")
                    {
                        telaAmigo.ExcluirRegistro();
                    }

                    continue;
                }
                else if (opcao == "3")
                {

                    string opcaoRevista = telaRevista.ApresentarMenu();

                    if (opcaoRevista == "1")
                    {
                        telaRevista.InserirNovoRegistro();
                    }
                    else if (opcaoRevista == "2")
                    {
                        telaRevista.VisualizarRegistros(true);
                        Console.ReadLine();
                    }
                    else if (opcaoRevista == "3")
                    {
                        telaRevista.EditarRegistro();
                    }
                    else if (opcaoRevista == "4")
                    {
                        telaRevista.ExcluirRegistro();
                    }

                    continue;
                }
                else if (opcao == "4")
                {

                    string opcaoEmprestimo = telaEmprestimo.ApresentarMenu();

                    if (opcaoEmprestimo == "1")
                    {
                        telaEmprestimo.AbrirNovoEmprestimo();
                    }
                    else if (opcaoEmprestimo == "2")
                    {
                        telaEmprestimo.VisualizarRegistros(true);
                        Console.ReadLine();
                    }
                    else if (opcaoEmprestimo == "3")
                    {
                        telaEmprestimo.VisualizarEmprestimosNoMes();
                        Console.ReadLine();
                    }
                    else if (opcaoEmprestimo == "4")
                    {
                        telaEmprestimo.VisualizarEmprestimosEmAbertoNoDia();
                        Console.ReadLine();
                    }
                    else if (opcaoEmprestimo == "5")
                    {
                        telaEmprestimo.FecharEmprestimo();
                    }
                    else if (opcaoEmprestimo == "6")
                    {
                        telaEmprestimo.EditarRegistro();
                    }
                    else if (opcaoEmprestimo == "7")
                    {
                        telaEmprestimo.ExcluirRegistro();
                    }


                    continue;
                }

                else if (opcao == "5")
                {
                    string opcaoReserva = telaReserva.ApresentarMenu();

                    if (opcaoReserva == "1")
                    {
                        telaReserva.InserirNovoRegistro();
                    }
                    else if (opcaoReserva == "2")
                    {
                        telaReserva.VisualizarRegistros(true);
                        Console.ReadLine();
                    }
                    else if (opcaoReserva == "3")
                    {
                        telaReserva.EditarRegistro();
                    }
                    else if (opcaoReserva == "4")
                    {
                        telaReserva.ExcluirRegistro();
                    }

                    continue;
                }
            }
        }

        private static void PopularRepositorios(
            RepositorioAmigo repositorioAmigo, RepositorioCaixa repositorioCaixa,
            RepositorioRevista repositorioRevista, RepositorioEmprestimo repositorioEmprestimo)
        {
            Amigo amigo1 = new Amigo("Gabriel Barbosa", "Jorge Sampaoli", "99999999", "Gávea");

            Amigo amigo2 = new Amigo("Bruno Henrique", "Jorge Sampaoli", "99999999", "Gávea");

            Amigo amigo3 = new Amigo("Pedro Quexada", "Jorge Sampaoli", "99999999", "Gávea");

            repositorioAmigo.Inserir(amigo1);
            repositorioAmigo.Inserir(amigo2);
            repositorioAmigo.Inserir(amigo3);

            Caixa caixa = new Caixa("Verde", "abc-123");

            repositorioCaixa.Inserir(caixa);

            Revista revista1 = new Revista("Batman Begins", 10, 2010, caixa);

            repositorioRevista.Inserir(revista1);

            Revista revista2 = new Revista("As aventuras de superman", 10, 2010, caixa);

            repositorioRevista.Inserir(revista2);

            Revista revista3 = new Revista("Turma da Monica", 10, 2010, caixa);

            repositorioRevista.Inserir(revista3);

            DateTime hoje = new DateTime(2023, 4, 19);

            Emprestimo emprestimo1 = new Emprestimo(hoje, revista1, amigo1);

            repositorioEmprestimo.Inserir(emprestimo1);

            DateTime ontem = new DateTime(2023, 3, 18);
            Emprestimo emprestimo2 = new Emprestimo(ontem, revista2, amigo2);

            repositorioEmprestimo.Inserir(emprestimo2);

            DateTime anteOntem = new DateTime(2022, 1, 17);
            Emprestimo emprestimo3 = new Emprestimo(anteOntem, revista3, amigo3);

            repositorioEmprestimo.Inserir(emprestimo3);
        }
    }
}