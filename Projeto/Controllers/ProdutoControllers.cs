using System.Collections.Generic;
using System.Linq;
using Api.Models;
using Microsoft.EntityFrameworkCore;




namespace API.Controllers
{
    [ApiController]
    [Route("api/produto")]
    public class ProdutoController : ControllerBase
    {
        private readonly DataContext _context;
        public ProdutoController(DataContext context) =>
            _context = context;

        
        [HttpGet]
        [Route("listar")]
        public IActionResult Listar() => Ok(_context.Produtos.ToList());

        [HttpPost]
        [Route("cadastrar")]
        public IActionResult Cadastrar([FromBody] Produto produto)
        {
            _context.Produtos.Add(produto);
            _context.SaveChanges();
            return Created("", produto);
        }

        
        [HttpGet]
        [Route("buscar/{id}")]
        public IActionResult Buscar([FromRoute] string Id)
        {
            Produto produto = _context.Produtos.
                FirstOrDefault(f => f.id.Equals(Id));
            return produto != null ? Ok(produto) : NotFound();
        }

        
        [HttpDelete]
        [Route("deletar/{id}")]
        public IActionResult Deletar([FromRoute] int id)
        {
            Produto produto = _context.Produtos.Find(Id);
            if (produto != null)
            {
                _context.Produtos.Remove(produto);
                _context.SaveChanges();
                return Ok(produto);
            }
            return NotFound();
        }

        
        [HttpPatch]
        [Route("alterar")]
        public IActionResult Alterar([FromBody] Produto produto)
        {
            try
            {
                _context.Produtos.Update(produto);
                _context.SaveChanges();
                return Ok(produto);
            }
            catch
            {
                return NotFound();
            }
        }
    }
}