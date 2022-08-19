using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using ApiRest.Elearning.Models;
using ApiRest.Elearning.Data;
using AutoMapper;
using ApiRest.Elearning.Repository;
using Microsoft.AspNetCore.Hosting;

namespace ApiRest.Elearning.Controllers
{
    [Route("api/contacto")]
    [ApiController]
    public class ContactoController : Controller
    {


        private readonly IContactoRepository _contactoRepository;
        private readonly IMapper _mapper;
        private readonly IWebHostEnvironment _webHostEnviroment;
        public ContactoController(IContactoRepository contactoRepository, IMapper mapper, IWebHostEnvironment webHostEnvironment)
        {
            _contactoRepository = contactoRepository;
            _mapper = mapper;
            _webHostEnviroment = webHostEnvironment;
        }

        [HttpGet]
        public IActionResult GetContactos()
        {
            var listContatos = _contactoRepository.GetAllContact();
            var listContatosDto = new List<ContactoDto>();
            foreach (var item in listContatos)
            {
                listContatosDto.Add(_mapper.Map<ContactoDto>(item));
            }
            return Ok(listContatosDto);
        }

    }

   


}
