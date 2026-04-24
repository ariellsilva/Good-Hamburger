using Microsoft.AspNetCore.Mvc;

namespace GoodHamburger.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CardapioController : ControllerBase
{
    [HttpGet]
    public IActionResult Get()
    {
        return Ok(new
        {
            Sanduiches = new[] { 
                new { Nome = "X Burger", Preco = 5.00 }, 
                new { Nome = "X Egg", Preco = 4.50 }, 
                new { Nome = "X Bacon", Preco = 7.00 } 
            },
            Acompanhamentos = new[] { new { Nome = "Batata frita", Preco = 2.00 } },
            Bebidas = new[] { new { Nome = "Refrigerante", Preco = 2.50 } }
        });
    }
}