using System;
using System.Collections.Generic;
using dio.series.Interfaces;

namespace dio.series.Classes
{
    public class SerieRepository : IRepository<Serie>
    {
        private List<Serie> listaSerie = new List<Serie>();
        public void Create(Serie entidade)
        {
            listaSerie.Add(entidade);
        }

        public void Delete(int id)
        {
            listaSerie[id].Excluir();
        }

        public List<Serie> Lista()
        {
            return listaSerie;
        }

        public int NextId()
        {
            return listaSerie.Count;
        }

        public Serie ReturnById(int id)
        {
            return listaSerie[id];
        }

        public void Update(int id, Serie entidade)
        {
            listaSerie[id] = entidade;
        }
    }
}