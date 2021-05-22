using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroSeries_Filmes
{
    class Serie : EntidadeBase
    {

        //Atributos 
        private string Genero { get; set; }
        private string Titulo { get; set; }
        private string Descricao { get; set; }
        private int Ano { get; set; }
        private bool Excluido { get; set; }
        public object Enviroment { get; private set; }

        //Metodos
        public Serie(int id, string genero, string titulo, string descricao, int ano)
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
            string retorno = string.Empty;
            retorno += "Genero: " + this.Genero + Enviroment.ToString();
            retorno += "Titulo: " + this.Titulo + Enviroment.ToString();
            retorno += "Descricão: " + this.Descricao + Enviroment.ToString();
            retorno += "Ano de Inicio: " + this.Ano + Enviroment.ToString();
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
        public void Excluir()
        {
            this.Excluido = true;
        }

    }
}
