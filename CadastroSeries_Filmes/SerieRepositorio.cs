using CadastroSeries_Filmes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroSeries_Filmes
{
    public class SerieRepositorio: IRepositorio
    {
      private List<Serie> listaSerie = new List<Serie>();
        Serie objeto;
       
        public void  Atualiza(int id)
        {
            
            listaSerie[id] = objeto;
            
        }
        public void Exclui(int id)
        {
            listaSerie[id].Excluir();
        }
        public void Insere()
        {
            listaSerie.Add(objeto);
        }
        public int ProximoId()
        {
            return listaSerie.Count;
        }
        public void RetornaPorId(int id)
        {
            listaSerie[id] = objeto;
        }

        public int Lista()
        {
            throw new NotImplementedException();
        }
    }
}
