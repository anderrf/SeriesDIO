using System.Collections.Generic;
using SeriesDIO.Interfaces;

namespace SeriesDIO.Classes
{
    public class SerieRepository : IRepository<Serie>
    {
        private List<Serie> SerieList = new List<Serie>();

        public void Exclude(int id)
        {
            throw new System.NotImplementedException();
        }

        public Serie GetById(int id)
        {
            throw new System.NotImplementedException();
        }

        public void Insert(Serie entity)
        {
            throw new System.NotImplementedException();
        }

        public List<Serie> List()
        {
            throw new System.NotImplementedException();
        }

        public int NextId()
        {
            throw new System.NotImplementedException();
        }

        public void Update(int id, Serie entity)
        {
            throw new System.NotImplementedException();
        }
    }
}