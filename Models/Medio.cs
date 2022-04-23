namespace Projeto_Dodev_School.Models
{
    public class Medio : Formacao
    {
        private string Tipo { get; set; }
        public Medio(string descricao, int periodo, string tipo) : base(descricao, periodo)
        {
            Tipo = tipo;
        }
        public override void ExibirDados()
        {
            Console.WriteLine($"Descrição: {Descricao}. No periodo: {Periodo} e do tipo:{Tipo}");
        }
        public override void DefinirDuracao()
        {
            SetDuracao(36);
        }

        public string GetTipo()
        {
            return Tipo;
        }
        public void SetTipo(string tipo)
        {
            Tipo = tipo;
        }
        public void CalcularMensalidade(double fator)
        {
            Mensalidade = (Duracao * fator * 7);
        }
    }
}

