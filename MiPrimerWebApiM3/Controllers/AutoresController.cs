using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MiPrimerWebApiM3.Contexts;
using MiPrimerWebApiM3.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MiPrimerWebApiM3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AutoresController : ControllerBase
    {
        private readonly ApplicationDbContext context;

        public AutoresController(ApplicationDbContext context)
        {
            this.context = context;
        }


        [HttpGet]
        public ActionResult<IEnumerable<Autor>> Get()
        {
            return context.Autores.Include(x => x.Libros).ToList();
        }


        [HttpGet("{id}", Name = "ObtenerAutor")]
        public ActionResult<Autor> Get(int id)
        {
            var autor = context.Autores.Include(x => x.Libros).FirstOrDefault(_autor => _autor.Id == id);

            if (autor == null)
            {
                return NotFound();
            }

            return autor;
        }


        [HttpPost]
        public ActionResult Post([FromBody] Autor autor)
        {


            // Esto no es necesario en asp.net core 2.1 en adelante
            //if (!ModelState.IsValid)
            //{
            //    return BadRequest(ModelState);
            //}
            context.Add(autor);
            context.SaveChanges();

            return new CreatedAtRouteResult("ObtenerAutor", new { id = autor.Id }, autor);

        }

        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Autor autor)
        {
            // Esto no es necesario en asp.net core 2.1 en adelante
            //if (!ModelState.IsValid)
            //{
            //    return BadRequest(ModelState);
            //}

            if (id != autor.Id)
            {

                return BadRequest();
            }

            context.Entry(autor).State = EntityState.Modified;
            context.SaveChanges();
            return Ok();

        }

        [HttpDelete("{id}")]
        public ActionResult<Autor> Delete(int id)
        {

            var autor = context.Autores.FirstOrDefault(_autor => _autor.Id.Equals(id));

            if (autor == null)
            {
                return BadRequest();
            }

            context.Autores.Remove(autor);
            context.SaveChanges();

            return autor;

        }

    }
}