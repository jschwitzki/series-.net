using DIO.series.Enum;

namespace dio.series.Classes
{
    public class Serie : EntidadeBase
    {
        private Genero genero { get; set; }
        private string titulo { get; set; }
        private string descricao { get; set; }
        private int ano { get; set; }
        private bool Excluido { get; set; }

        public Serie(int id, Genero genero, string titulo, string descricao, int ano)
        {
            this.Id = id;
            this.genero = genero;
            this.titulo = titulo;
            this.descricao = descricao;
            this.ano = ano;
            this.Excluido = false;

        }

        public override string ToString()
        {
            string Return = "";
            Return += "Gênero: " + this.genero + Environment.NewLine;
            Return += "Título: " + this.titulo + Environment.NewLine;
            Return += "Descrição: " + this.descricao + Environment.NewLine;
            Return += "Ano: " + this.ano + Environment.NewLine;
            Return += "Excluído: " + this.Excluido;
            return Return;
        }

        public string returnTitulo()
        {
            return this.titulo;
        }

        public int returnId()
        {
            return this.Id;
        }

        public bool returnExcluido()
        {
            return this.Excluido;
        }

        public void Excluir()
        {
            this.Excluido = true;
        }
    }
}