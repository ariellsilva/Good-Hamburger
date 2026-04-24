# 🍔 Good Hamburger API

Desafio técnico para o sistema de gerenciamento de pedidos de uma lanchonete, desenvolvido em **C#** com **ASP.NET Core**.

## 🚀 Documentação (Swagger)
Após rodar o projeto, a documentação interativa e os testes de endpoint podem ser acessados em:
`http://localhost:5197/swagger/index.html`

## 📋 Funcionalidades e Requisitos Atendidos

* **Gerenciamento de Pedidos (CRUD):** Criar, listar, consultar por ID, atualizar e remover pedidos.
* **Consulta de Cardápio:** Endpoint específico para retornar os itens e preços atuais.
* **Regras de Negócio (Combos):**
    * **Combo Completo** (Lanche + Batata + Bebida): 20% de desconto.
    * **Combo Simples 1** (Lanche + Bebida): 15% de desconto.
    * **Combo Simples 2** (Lanche + Batata): 10% de desconto.
* **Validações de Erro:**
    * Bloqueio de pedidos sem sanduíche (item obrigatório).
    * Mensagens claras para itens não encontrados (Status 404).
    * Validação de itens duplicados no mesmo pedido (ex: múltiplas batatas).

## 🛠️ Tecnologias Utilizadas

* **Linguagem:** C# / .NET 8.0
* **Framework:** ASP.NET Core Web API
* **Documentação:** Swagger (Swashbuckle)
* **Persistência:** Lista em memória (`static List`) para agilidade nos testes.

## 📝 Decisões Técnicas

* **Modelagem:** A lógica de cálculo de preço e desconto foi centralizada na classe `Pedido`, seguindo o princípio de **Responsabilidade Única (SRP)**.
* **Validação:** Implementada validação de entrada nos métodos `Post` e `Put` para garantir a integridade dos dados e prevenir erros de processamento.
* **Arquitetura:** Organização limpa separando **Models** e **Controllers**, facilitando a escalabilidade e manutenção do código.

---
Desenvolvido como parte de um desafio técnico para Desenvolvedor C#.
