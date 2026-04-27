## 🍔 GoodHamburger API

API REST desenvolvida em **.NET 8** para o gerenciamento de pedidos de uma lanchonete, incluindo cálculo automático de combos e descontos progressivos.

---

## 🚀 Como Executar o Projeto

### Pré-requisitos
* **.NET 8 SDK** instalado.
* **IDE** de sua preferência (VS Code, Visual Studio 2022 ou Rider).

### Passo a Passo

1. **Clone o repositório:**
   ```bash
   git clone [https://github.com/seu-usuario/good-hamburger-api.git](https://github.com/seu-usuario/good-hamburger-api.git)
   cd good-hamburger-api
Restaure as dependências:

Bash
dotnet restore
Execute a aplicação:

Bash
dotnet run
Acesse a documentação (Swagger):
Acesse http://localhost:5000/swagger (ou a porta indicada no terminal) para testar os endpoints interativamente.

## 🏗️ Decisões de Arquitetura
A aplicação foi estruturada seguindo o padrão MVC (Model-View-Controller) para garantir a separação de responsabilidades:

Models: Representam a estrutura de dados e concentram a Lógica de Negócio. O cálculo de descontos foi implementado diretamente no método CalcularTotalComDesconto() dentro da classe Pedido, garantindo que o valor total seja sempre consistente com os itens selecionados.

Controllers: * CardapioController: Fornece os itens e preços oficiais.

PedidosController: Gerencia o ciclo de vida do pedido (CRUD).

Armazenamento em Memória: Para este desafio, foi utilizada uma lista estática (static List<Pedido>) para persistência temporária durante a execução, evitando a complexidade de configuração de um banco de dados externo neste momento.

Regras de Desconto: Implementadas conforme solicitado:

Lanche + Batata + Bebida = 20% de desconto.

Lanche + Bebida = 15% de desconto.

Lanche + Batata = 10% de desconto.

## 🛠️ Tecnologias Utilizadas
* C# / .NET 8

* ASP.NET Core Web API

* Swagger/OpenAPI (Documentação e testes)

## 📝 O que ficou de fora (Melhorias Futuras)

* 1. Endpoint para Consultar o Cardápio
O desafio solicita explicitamente a exposição de um endpoint para consultar o cardápio. Embora seu código de backend possua o CardapioController, sua interface (frontend) não mostra uma área onde o usuário possa visualizar os itens disponíveis e seus respectivos preços oficiais (X-Burger por R$ 5,00, Batata por R$ 2,00, etc.) antes de fazer o pedido.

* 2. Tratamento e Exibição de Mensagens de Erro Clara
Os requisitos pedem que o sistema retorne mensagens de erro claras para itens duplicados ou pedidos inválidos.

No Sistema: Sua interface atual de "Add Game" (que você adaptou para o desafio) não possui áreas de feedback visual para erros vindos da API. Se o usuário tentar adicionar um item duplicado, ele não receberá um alerta amigável na tela explicando o problema.

* 3. Implementação de Testes Automatizados
O documento lista como um diferencial a criação de testes automatizados das regras de negócio. Nas capturas de tela e no código fornecido, não há evidências de uma suíte de testes (como xUnit ou NUnit) para garantir que os cálculos de desconto de 10%, 15% e 20% estão funcionando corretamente sem erros humanos.
