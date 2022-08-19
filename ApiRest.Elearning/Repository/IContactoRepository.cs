using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiRest.Elearning.Models;

namespace ApiRest.Elearning.Repository
{
    public interface IContactoRepository
    {
        ICollection<Contacto> GetAllContact();
      
        Contacto GetContactById(int id);
        bool ExistContactByName(string name);
        IEnumerable<Contacto> searchContact(string name);
        bool ExistContactById(int id);
        bool CreateContact(Contacto contacto);
        bool UpdateContact(Contacto contacto);
        bool DeleteContact(Contacto contacto);
        bool SaveContact();

    }
}
