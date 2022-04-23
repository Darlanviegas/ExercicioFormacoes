using Projeto_Dodev_School.Models;
class Program
{

    static void Main(string[] args)
    {
        IniciarSistema();
    }
    public static Formacao CadastrarFormacao()
    {
        Console.WriteLine("Qual tipo de formação deseja cadastrar? 1 - Medio | 2 - Tecnologo | 3 - Bacharelado");
        string escolha = Console.ReadLine();
        Formacao formacaoEscolhida;
        var criou = false;
        do
        {
            switch (escolha)
            {
                case "1":
                    formacaoEscolhida = new Medio("Ensino Médio", 1, "normal");
                    criou = true;
                    break;
                case "2":
                    formacaoEscolhida = new Tecnologo("Tecnologo", 1, true);
                    criou = true;
                    break;
                case "3":
                    formacaoEscolhida = new Bacharelado("Bacharelado", 1, "Projeto top", 4);
                    criou = true;
                    break;
                default:
                    Console.WriteLine("Opção inválida!");
                    criou = false;
                    formacaoEscolhida = new Formacao("teste", 1);
                    break;
            }
        } while (criou == false);
        return formacaoEscolhida;
    }
    public static void ExibirDadosDasFormacoes(List<Formacao> listaInformada)
    {
        for (int contador = 0; contador < listaInformada.Count(); contador++)
        {
            listaInformada[contador].ExibirDados();
        }
    }
    public static void IniciarSistema()
    {
        List<Formacao> formacoesCadastradas = new List<Formacao>();
        Console.WriteLine("Olá, Seja bem vindo ao nosso sistema! O que deseja Fazer?");
        Console.WriteLine("1 - Cadastrar Formação | 2 - Encerrar");
        string escolha = Console.ReadLine();
        do
        {
            switch (escolha)
            {
                case "1":
                    formacoesCadastradas.Add(CadastrarFormacao());
                    break;
                case "2":
                    Console.WriteLine("Obrigado por utilizar nosso sistema, tenha um bom dia!");
                    break;
                default:
                    Console.WriteLine("Opção Inválida!");
                    break;
            }
        } while (escolha != "2");
    }

}
