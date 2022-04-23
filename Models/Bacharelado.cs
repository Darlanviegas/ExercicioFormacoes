namespace Projeto_Dodev_School.Models
{
    public class Bacharelado : Formacao
    {
        private string ProjetoConclusao { get; set; }
        private int CargaHorarioEstagio { get; set; }
        public Bacharelado(string descricao, int periodo, string projetoConclusao, int cargaHorariaEstagio) : base(descricao, periodo)
        {
            ProjetoConclusao = projetoConclusao;
            CargaHorarioEstagio = cargaHorariaEstagio;
        }
        public override void ExibirDados()
        {
            Console.WriteLine($"Descrição: {Descricao}. No periodo: {Periodo} e com carga horaria de estágio:{CargaHorarioEstagio}");
        }
        public override void DefinirDuracao()
        {
            var descricaoParaVerificacao = GetDescricao();
            var resultadoVerificacao = descricaoParaVerificacao.Contains("Engenharia");
            if (resultadoVerificacao == true)
            {
                SetDuracao(60);
            }
            else
            {
                SetDuracao(48);
            }
        }
        public string GetProjetoConclusao()
        {
            return ProjetoConclusao;
        }
        public void SetProjetoConclusao(string projetoConclusao)
        {
            ProjetoConclusao = projetoConclusao;
        }
        public int GetCargaHorariaEstagio()
        {
            return CargaHorarioEstagio;
        }
        public void SetCargaHorariaEstagio(int cargaHorariaEstagio)
        {
            CargaHorarioEstagio = cargaHorariaEstagio;
        }
        public void CalcularMensalidade(double fator)
        {
            Mensalidade = (Duracao * fator * 8) + (CargaHorarioEstagio * 12);
        }
    }
}