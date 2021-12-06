using System.Collections.Generic;
using SeriesDIO.Interfaces;

namespace SeriesDIO.Classes
{
    public class SerieRepository : IRepository<Serie>
    {
        private List<Serie> SerieList = new List<Serie>();

        public void Exclude(int id)
        {
            SerieList[SerieList.FindIndex(serie => serie.getId() == id)].Exclude();
        }

        public Serie GetById(int id)
        {
            return SerieList[SerieList.FindIndex(serie => serie.getId() == id)];
        }

        public void Insert(Serie serie)
        {
            SerieList.Add(serie);
        }

        public List<Serie> List()
        {
            List<Serie> getList = new List<Serie>();
            foreach(Serie serie in SerieList)
            {
                if(!serie.getExcluded())
                {
                    getList.Add(serie);
                }
            }
            return getList;
        }

        public int NextId()
        {
            return SerieList.Count;
        }

        public void Update(int id, Serie serie)
        {
            SerieList[SerieList.FindIndex(serie => serie.getId() == id)] = serie;
        }
    }
}