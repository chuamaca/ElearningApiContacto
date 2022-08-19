using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiRest.Elearning.Models;
using ApiRest.Elearning.Data;
using ApiRest.Elearning.Repository;



namespace ApiRest.Elearning.Repository
{
    public class ContactoRepository : IContactoRepository
    {
        private readonly DbContextApp _bd;
        public ContactoRepository(DbContextApp db)
        {
            _bd = db;
        }

        
        public bool CreateContact(Contacto contacto)
        {
            _bd.contacto.Add(contacto);
            return SaveContact();
        }

        public bool DeleteContact(Contacto contacto)
        {
            _bd.Remove(contacto);
            return SaveContact();
        }

        public bool ExistContactById(int id)
        {
            bool exist = _bd.contacto.Any(m => m.IdContacto == id);
            return exist;
        }

        public bool ExistContactByName(string nombre)
        {
            bool exist = _bd.contacto.Any(m => m.Nombre.ToLower().Trim() == nombre);
            return exist;
        }

        public ICollection<Contacto> GetAllContact()
        {
            return _bd.contacto.OrderBy(m => m.Nombre).ToList();
        }

        public Contacto GetContactById(int id)
        {
            return _bd.contacto.FirstOrDefault(m => m.IdContacto == id);
        }

        public bool SaveContact()
        {
            return _bd.SaveChanges() >= 0 ? true : false;
        }

        public IEnumerable<Contacto> searchContact(string name)
        {

            IQueryable<Contacto> query = _bd.contacto;
            if (!string.IsNullOrEmpty(name))
            {
                query = query.Where(m => m.Nombre.Contains(name) || m.Celular.Contains(name));

            }

            return query.ToList();
        }

        public bool UpdateContact(Contacto contacto)
        {
            _bd.contacto.Update(contacto);
            return SaveContact();
        }
    }
}
