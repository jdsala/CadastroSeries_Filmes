using System;

namespace CadastroSeries_Filmes
{
    class Program
    {
        IRepositorio iRepos;
        SerieRepositorio repositorio = new SerieRepositorio();
        Genero genero = new Genero();
        static void Main(string[] args)
        {
            string opcaoUsuario = ObterOpcaoUsuario();

            while (opcaoUsuario.ToUpper() != "X")
            {
                switch (opcaoUsuario)
                {
                    case "1":
                        ListarSeries();
                        break;

                    case "2":
                        InserirSerie();
                        break;

                    case "3":
                        AtualizarSerie();
                        break;

                    case "4":
                        ExcluirSerie();
                        break;

                    case "5":
                        VisualizarSerie();
                        break;

                    case "C":
                        Console.Clear();
                        break;

                    default:
                        throw new ArgumentOutOfRangeException();

                }
                opcaoUsuario = ObterOpcaoUsuario();
            }
            Console.WriteLine("Obrigado por utilizar nossos serviços. ");
            Console.ReadLine();
        }
        
        private static void ListarSeries()
        {
            SerieRepositorio repositorio = new SerieRepositorio();
            Console.WriteLine("Listar Séries");
            var lista = repositorio.Lista();

            if (lista == 0)
            {
                Console.WriteLine("Nenhuma série cadastrada.");
                return;
            }
           /* foreach (var serie in lista)
            {
                Console.WriteLine("#ID {0}: . {1}", serie.retornaId(), serie.retornaTitulo());
            }*/
        }

        private static void InserirSerie()
        {
            SerieRepositorio repositorio = new SerieRepositorio();
            Console.WriteLine("Inserir nova Série.");

            foreach (int i in Enum.GetValues(typeof(Genero)))
            {
                Console.WriteLine("{0}.{1}", i, Enum.GetName(typeof(Genero), i));

            }
            Console.WriteLine("Digite o genéro entre as opções acima: ");
            var entradaGenero = Console.ReadLine();

            Console.WriteLine("digite o Título da Série: ");
            string entradaTitulo = Console.ReadLine();

            Console.WriteLine("Digite o Ano de inicio da Série: ");
            var entradaAno = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a descriçaão da Série: ");
            string entradaDescricao = Console.ReadLine();

            Serie novaSerie = new Serie(id: repositorio.ProximoId(),
                                        genero: entradaGenero,
                                        titulo: entradaTitulo,
                                        ano: entradaAno,
                                        descricao: entradaDescricao);

            repositorio.Insere();
        }
        private static void AtualizarSerie()
        {
            SerieRepositorio repositorio = new SerieRepositorio();
            Console.WriteLine("Digite o ID da Série.");
            int indiceSerie = int.Parse(Console.ReadLine());

            foreach (int i in Enum.GetValues(typeof(Genero)))
            {
                Console.WriteLine("{0}.{1}", i, Enum.GetName(typeof(Genero), i));

            }
            Console.WriteLine("Digite o genéro entre as opções acima: ");
            var entradaGenero = Console.ReadLine();

            Console.WriteLine("digite o Título da Série: ");
            string entradaTitulo = Console.ReadLine();

            Console.WriteLine("Digite o Ano de inicio da Série: ");
            var entradaAno= int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a descriçaão da Série: ");
            string entradaDescricao = Console.ReadLine();

            Serie atualizaSerie = new Serie(id: indiceSerie,
                                        genero: entradaGenero,
                                        titulo: entradaTitulo,
                                        ano: entradaAno,
                                        descricao: entradaDescricao);

            repositorio.Atualiza(indiceSerie);

        }

        private static void ExcluirSerie()
        {
            SerieRepositorio repositorio = new SerieRepositorio();
            Console.WriteLine("Digite o ID da Série.");
            int indiceSerie = int.Parse(Console.ReadLine());

            foreach (int i in Enum.GetValues(typeof(Genero)))
            {
                Console.WriteLine("{0}.{1}", i, Enum.GetName(typeof(Genero), i));

            }
            Console.WriteLine("Digite o genéro entre as opções acima: ");
            var entradaGenero = Console.ReadLine();

            Console.WriteLine("digite o Título da Série: ");
            string entradaTitulo = Console.ReadLine();

            Console.WriteLine("Digite o Ano de inicio da Série: ");
            int entradaAno = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a descriçaão da Série: ");
            string entradaDescricao = Console.ReadLine();

            Serie atualizaSerie = new Serie(id: indiceSerie,
                                        genero: entradaGenero,
                                        titulo: entradaTitulo,
                                        ano: entradaAno,
                                        descricao: entradaDescricao);

            repositorio.Exclui(indiceSerie);

        }

        private static void VisualizarSerie()
        {
            SerieRepositorio repositorio = new SerieRepositorio();
            Console.WriteLine("Digite o ID da Série.");
            int indiceSerie = int.Parse(Console.ReadLine());

            foreach (int i in Enum.GetValues(typeof(Genero)))
            {
                Console.WriteLine("{0}.{1}", i, Enum.GetName(typeof(Genero), i));

            }
            Console.WriteLine("Digite o genéro entre as opções acima: ");
            var entradaGenero = Console.ReadLine();

            Console.WriteLine("digite o Título da Série: ");
            string entradaTitulo = Console.ReadLine();

            Console.WriteLine("Digite o Ano de inicio da Série: ");
            int entradaAno = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a descriçaão da Série: ");
            string entradaDescricao= Console.ReadLine();

            Serie atualizaSerie = new Serie(id: indiceSerie,
                                        genero: entradaGenero,
                                        titulo: entradaTitulo,
                                        ano: entradaAno,
                                        descricao: entradaDescricao);

            repositorio.RetornaPorId(indiceSerie);

        }

        private static string ObterOpcaoUsuario()
        {
            Console.WriteLine();
            Console.WriteLine("DIO Séries a seu dispor !!");
            Console.WriteLine("Informe a opção desejada: ");

            Console.WriteLine("1- Listar séries");
            Console.WriteLine("2- Inserir nova série");
            Console.WriteLine("3- Atualizar série");
            Console.WriteLine("4- Excluir série");
            Console.WriteLine("5- Visualizar série");
            Console.WriteLine("C- Limpar Tela");
            Console.WriteLine("x- Sair");
            Console.WriteLine();

            string opcaoUsuario = Console.ReadLine().ToUpper();
            Console.WriteLine();
            return opcaoUsuario;
        }
    }

    internal interface IRepositorio
    {

    }
}

