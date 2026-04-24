using Microsoft.AspNetCore.Mvc;
using GoodHamburger.Models;

namespace GoodHamburger.Controllers;

[ApiController]
[Route("api/[controller]")]
public class PedidosController : ControllerBase
{
    private static List<Pedido> _pedidos = new List<Pedido>();
    private static int _proximoId = 1;

    [HttpGet]
    public IActionResult Get() => Ok(_pedidos);

    [HttpGet("{id}")]
    public IActionResult GetById(int id)
    {
        var pedido = _pedidos.FirstOrDefault(p => p.Id == id);
        return pedido == null ? NotFound(new { mensagem = "Pedido não encontrado." }) : Ok(pedido);
    }

    [HttpPost]
    public IActionResult Post([FromBody] Pedido novoPedido)
    {
        // VALIDAÇÃO 1: Precisa ter lanche
        if (string.IsNullOrEmpty(novoPedido.Lanche))
            return BadRequest(new { erro = "Pelo menos um sanduíche deve ser selecionado." });

        // VALIDAÇÃO 2: Verificar duplicatas (um pedido só pode ter UM de cada item)
        // Se o usuário tentar mandar "Batata, Batata", o código abaixo detecta
        if (ContemDuplicados(novoPedido.Lanche) || ContemDuplicados(novoPedido.Batata) || ContemDuplicados(novoPedido.Bebida))
            return BadRequest(new { erro = "Itens duplicados não são permitidos no mesmo pedido." });

        novoPedido.Id = _proximoId++;
        novoPedido.ValorTotal = novoPedido.CalcularTotalComDesconto();
        _pedidos.Add(novoPedido);
        
        return CreatedAtAction(nameof(GetById), new { id = novoPedido.Id }, novoPedido);
    }

    [HttpPut("{id}")]
    public IActionResult Put(int id, [FromBody] Pedido atualizado)
    {
        var existente = _pedidos.FirstOrDefault(p => p.Id == id);
        if (existente == null) return NotFound(new { mensagem = "Pedido não encontrado para atualização." });

        existente.Lanche = atualizado.Lanche;
        existente.Batata = atualizado.Batata;
        existente.Bebida = atualizado.Bebida;
        existente.ValorTotal = existente.CalcularTotalComDesconto();

        return Ok(existente);
    }

    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        var pedido = _pedidos.FirstOrDefault(p => p.Id == id);
        if (pedido == null) return NotFound();
        _pedidos.Remove(pedido);
        return NoContent();
    }

    // Função auxiliar para validar duplicados
    private bool ContemDuplicados(string campo) => !string.IsNullOrEmpty(campo) && campo.Contains(",");
}