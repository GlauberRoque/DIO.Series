using System;
using System.Collections.Generic;
using DIO.Series.Interfaces;
namespace DIO.Series
{
    public class SerieRepositorio : IRepositorio<Series>
    {
        private List<Series> listaSerie = new List<Series>();
        public void Atualizar(int id, Series entidade)
        {
            listaSerie[id] = entidade;
        }

        public void Excluir(int id)
        {
            listaSerie[id].Exclui();
        }

        public void Insere(Series entidade)
        {
            listaSerie.Add(entidade);
        }

        public List<Series> Lista()
        {
            return listaSerie;
        }

        public int ProximoId()
        {
            return listaSerie.Count;
        }

        public Series RetornaPorId(int id)
        {
            return listaSerie[id];
        }
    }
}