namespace DIO.Series
{
    public class Series : EntidadeBase
    {
     // Atributos

        private Genero Genero {get; set;}

        private string Titulo {get; set;}

        private string Descricao {get; set;}

        private int Ano {get; set;}

        private bool Excluido {get; set;}
    
    // metodos

        public Series(int id, Genero genero, string titulo, string descricao, int ano)
        {
            this.Id = id;
            this.Genero = genero;
            this.Titulo = titulo;
            this.Descricao = descricao;
            this.Ano = ano;
            this.Excluido = false;
        }

        public override string ToString()
        {
            string retorno = "";
            retorno += "Gênero: " + this.Genero;
            retorno += "Título: " + this.Titulo;
            retorno += "Descrição: " + this.Descricao;
            retorno += "Ano de Lançamento: " + this.Ano;
            retorno += "Excluido: " + this.Excluido;
            return retorno;
        }

        public string retornaTitulo()
        {
            return this.Titulo;
        }

        public int retornaId()
        {
            return this.Id;
        }
        public void Exclui()
        {
            this.Excluido = true;
        }

    }
    
}