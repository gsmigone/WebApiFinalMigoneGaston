using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApiFinalMigoneGaston.Context;
using WebApiFinalMigoneGaston.Entidades;

namespace WebApiFinalMigoneGaston.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MedicoController : ControllerBase
    {
        private readonly ApplicationDbContext Context;
        public MedicoController(ApplicationDbContext context)
        {
            Context = context;
        }

        [HttpGet]
        //MOSTRAR TODOS LOS MEDICOS Y SUS DATOS
        public ActionResult<IEnumerable<Medico>> Get()
        {
            return Context.Medicos.ToList();
        }

        [HttpGet("{id}")]
        //MOSTRAR MEDICO POR ID
        public ActionResult<Medico> Get(int id)
        {
            var resultado = Context.Medicos.FirstOrDefault(x => x.MedicoID ==
            id);
            if (resultado == null)
            { return NotFound(); }
            return resultado;
        }

        [HttpPost]
        //INSERTAR MEDICO 
        public ActionResult Post(Medico medico)
        {
            Context.Medicos.Add(medico);
            Context.SaveChanges();
            return Ok();
        }


        [HttpDelete("{id}")]
        //BORRAR MEDICO
        public ActionResult<Medico> Delete(int id)
        {
            
            var medico = Context.Medicos.Find(id);

            if (medico == null)
            {
                return NotFound();
            }

            Context.Medicos.Remove(medico);
            Context.SaveChanges();

            return medico;
        }

        [HttpPut("{id}")]
        //MODIFICAR MEDICO POR ID
        public ActionResult Put(int id, Medico medico)
        {
            if (id != medico.MedicoID)
            {
                return BadRequest();
            }
            Context.Entry(medico).State = EntityState.Modified;
            Context.SaveChanges();
            return NoContent(); 
        }


        [HttpGet("especialidad/{Especialidad}")]
        //MOSTRAR POR ESPECIALIDAD
        public IEnumerable<Medico> GetEspecialidad(string especialidad)
        {
            var medico = (from p in Context.Medicos where p.Especialidad == especialidad
                          select p).ToList();
            return (IEnumerable<Medico>)medico;
        }


    }


}
