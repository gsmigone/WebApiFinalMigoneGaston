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

namespace WebApiFinalFantaconeFederico.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HospitalController : ControllerBase
    {
        public ApplicationDbContext Context { get; set; }    
        public HospitalController(ApplicationDbContext context)   
        {
            this.Context = context;
        }


        [HttpGet]
        //LISTAR TODOS LOS HOSPITALES
        public List<Hospital> Get()
        {
            List<Hospital> hospitales = Context.Hospitales.ToList();
            return hospitales; 
        }


        [HttpGet("{NumCama}")]
        //LISTO HOSPITALES POR NUMCAMA MAYOR
        public IEnumerable<Hospital> Get(int numCama)
        {
            var hospital = (from p in Context.Hospitales where p.NumCama > numCama
                            select p).ToList();

            return (IEnumerable<Hospital>)hospital;



        }



    }
}