using Microsoft.AspNetCore.Mvc;
using Teste.API.Data;
using Teste.API.Models;

namespace Teste.API.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : ControllerBase
    {
        [HttpGet]
        [Route("/")]


        public IActionResult Get(
        [FromServices] AppDbContext context)
        {
            return Ok(context.Products!.ToList());
        }

        [HttpPost("/")]
        public IActionResult Post([FromBody] Product product, [FromServices] AppDbContext context)
        {
            context.Products!.Add(product);
            context.SaveChanges();
            return Created($"/{product.Id}",product) ;
        }

        [HttpGet("/{id:int}")]
        public IActionResult GetById([FromRoute] int id, [FromServices] AppDbContext context)
        {
            var product = context.Products!.FirstOrDefault(x => x.Id == id);
            if(product == null){
                return NotFound();
            }

            return Ok(product);
        }

        [HttpPut("/{id:int}")]
        public IActionResult Put([FromRoute] int id, [FromBody] Product product, [FromServices] AppDbContext context)
        {
            var model = context.Products!.FirstOrDefault(x => x.Id == id);
            if (model == null)
            {
                return NotFound();
            }
            model.Nome = product.Nome;
            model.Preco = product.Preco;
            model.Quantidade = product.Quantidade;
            model.Categoria = product.Categoria;

            context.Products!.Update(model);
            context.SaveChanges();
            return Ok(model);

        }

        [HttpDelete("/{id:int}")]
        public IActionResult Delete([FromRoute] int id, [FromServices] AppDbContext context)
        {
            var model =context.Products.FirstOrDefault(x => x.Id == id);

            if(model == null){
                return NotFound();
            }
                context.Products.Remove(model);
                context.SaveChanges();
            
            return Ok(model);
        }


    }
}