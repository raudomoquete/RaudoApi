using Model;
using Persistence;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services
{
    class PersonasService
    {
        public interface IPersonasService
        {
            IEnumerable<Personas> GetAll();

            bool Add(Personas model);
            bool Edit(Personas model);
            bool Update(Personas model);
            bool Delete(Personas model);

            bool get(int id);
            bool getCedula(string id);
        }
        public class personasService : IPersonasService
        {
            public IEnumerable<Personas> GetAll()
            {
                throw new NotImplementedException();
            }

            public bool Add(Personas model)
            {
                throw new NotImplementedException();
            }

            public bool Edit(Personas model)
            {
                throw new NotImplementedException();
            }

            public bool Update(Personas model)
            {
                throw new NotImplementedException();
            }

            public bool Delete(Personas model)
            {
                throw new NotImplementedException();
            }

            public bool get(int id)
            {
                throw new NotImplementedException();
            }

            public bool getCedula(string id)
            {
                throw new NotImplementedException();
            }



        }
    }
}
