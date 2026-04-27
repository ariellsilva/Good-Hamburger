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
Devido ao prazo sugerido e ao foco inicial nas regras de negócio, os seguintes pontos não foram incluídos nesta versão, mas estão no roadmap:

* **Persistência em Banco de Dados: Atualmente os dados são perdidos ao reiniciar a aplicação. A próxima etapa seria integrar o Entity Framework Core com SQL Server ou PostgreSQL.

* **Autenticação: Implementação de JWT (JSON Web Token) para proteger os endpoints de criação e exclusão de pedidos.

* **Frontend: Uma interface em Blazor ou React para consumir esta API (citado como diferencial).

* **Logs: Implementação de Serilog para monitoramento de erros em ambiente de produção.

* **Testes de Unidade: Criação de testes com xUnit para validar as combinações de descontos automaticamente.
