namespace GoodHamburger.Models;

public class Pedido
{
    public int Id { get; set; }
    public string Lanche { get; set; } = "";
    public string Batata { get; set; } = "";
    public string Bebida { get; set; } = "";
    public decimal ValorTotal { get; set; }

    public decimal CalcularTotalComDesconto()
    {
        decimal total = 0;

        // Lógica de preços conforme o cardápio oficial
        if (!string.IsNullOrEmpty(Lanche))
        {
            string lancheLower = Lanche.ToLower();
            if (lancheLower.Contains("bacon")) total += 7.00m;
            else if (lancheLower.Contains("egg")) total += 4.50m;
            else total += 5.00m; // X-Burger e outros
        }

        if (!string.IsNullOrEmpty(Batata)) total += 2.00m;
        if (!string.IsNullOrEmpty(Bebida)) total += 2.50m;

        // Aplicação das Regras de Desconto
        // 1. Sanduíche + Batata + Bebida = 20%
        if (!string.IsNullOrEmpty(Lanche) && !string.IsNullOrEmpty(Batata) && !string.IsNullOrEmpty(Bebida))
            return total * 0.80m;
        
        // 2. Sanduíche + Bebida = 15%
        if (!string.IsNullOrEmpty(Lanche) && !string.IsNullOrEmpty(Bebida))
            return total * 0.85m;
        
        // 3. Sanduíche + Batata = 10%
        if (!string.IsNullOrEmpty(Lanche) && !string.IsNullOrEmpty(Batata))
            return total * 0.90m;

        return total;
    }
}