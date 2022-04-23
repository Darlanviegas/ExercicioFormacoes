namespace Projeto_Dodev_School.Models
{
    public class Tecnologo : Formacao
    {
        private bool PlanoEstendido { get; set; }
        public Tecnologo(string descricao, int periodo, bool planoEstendido) : base(descricao, periodo)
        {
            PlanoEstendido = planoEstendido;
        }
        public override void ExibirDados()
        {
            Console.WriteLine($"Descrição: {Descricao}. No periodo: {Periodo}. O plano é extendido:{PlanoEstendido}");
        }
        public override void DefinirDuracao()
        {
            SetDuracao(24);
        }

        public bool GetPlanoEstendido()
        {
            return PlanoEstendido;
        }
        public void SetPlanoEstendido(bool planoEstendido)
        {
            PlanoEstendido = planoEstendido;
        }
        public void CalcularMensalidade(double fator)
        {
            Mensalidade = (Duracao * fator * 8);
        }
    }
}