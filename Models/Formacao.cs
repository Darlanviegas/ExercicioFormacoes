namespace Projeto_Dodev_School.Models
{
    public class Formacao
    {
        protected string Descricao { get; set; }
        protected int Periodo { get; set; }
        protected double Mensalidade { get; set; }
        protected int Duracao { get; set; }
        public Formacao(string descricao, int periodo)
        {
            Descricao = descricao;
            Periodo = periodo;
        }
        public virtual void ExibirDados()
        {

        }

        public virtual void DefinirDuracao()
        {

        }
        public double ExibirMedia(double provaSemestralUm, double provaSemestralDois)
        {
            var mediaProvasSemestrais = (provaSemestralUm + provaSemestralDois) / 2;
            var mediaTrabalhos = 0;
            var mediaProvasMensais = 0;
            var mediaFinal = (mediaProvasSemestrais * 0.5) + (mediaTrabalhos * 0.2) + (mediaProvasMensais * 0.3);
            return mediaFinal;
        }
        public double ExibirMedia(double provaSemestralUm, double provaSemestralDois, double trabalhoUm, double trabalhoDois)
        {
            var mediaProvasSemestrais = (provaSemestralUm + provaSemestralDois) / 2;
            var mediaTrabalhos = (trabalhoUm + trabalhoDois) / 2;
            var mediaProvasMensais = 0;
            var mediaFinal = (mediaProvasSemestrais * 0.5) + (mediaTrabalhos * 0.2) + (mediaProvasMensais * 0.3);
            return mediaFinal;
        }
        public double ExibirMedia(double provaSemestralUm, double provaSemestralDois, double trabalhoUm, double trabalhoDois, double provaMensalUm, double provaMensalDois)
        {
            var mediaProvasSemestrais = (provaSemestralUm + provaSemestralDois) / 2;
            var mediaTrabalhos = (trabalhoUm + trabalhoDois) / 2;
            var mediaProvasMensais = (provaMensalUm + provaMensalDois) / 2;
            var mediaFinal = (mediaProvasSemestrais * 0.5) + (mediaTrabalhos * 0.2) + (mediaProvasMensais * 0.3);
            return mediaFinal;
        }

        public string GetDescricao()
        {
            return Descricao;
        }
        public void SetDescricao(string descricao)
        {
            Descricao = descricao;
        }
        public int GetPeriodo()
        {
            return Periodo;
        }
        public void SetPeriodo(int periodo)
        {
            Periodo = periodo;
        }
        public double GetMensalidade()
        {
            return Mensalidade;
        }
        public void SetMensalidade(double mensalidade)
        {
            Mensalidade = mensalidade;
        }
        public int GetDuracao()
        {
            return Duracao;
        }
        public void SetDuracao(int duracao)
        {
            Duracao = duracao;
        }

    }
}