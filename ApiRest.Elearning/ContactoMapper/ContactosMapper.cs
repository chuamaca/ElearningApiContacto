using ApiRest.Elearning.Models;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiRest.Elearning.ContactoMapper
{
    public class ContactosMapper : Profile
    {
        public ContactosMapper()
        {
            CreateMap<Contacto, ContactoDto>().ReverseMap();
        }
       

    }
      
}
