🚀 API de Gerenciamento de Produtos (.NET)
Esta Web API foi desenvolvida em ASP.NET Core para realizar o gerenciamento completo de produtos (CRUD). O projeto reflete a aplicação de padrões de arquitetura profissional e boas práticas de desenvolvimento backend em C#.

🛠️ Destaques Técnicos
Diferente de sistemas simples, este projeto foi construído utilizando:

Repository Pattern: Abstração da lógica de acesso a dados através de interfaces (IProdutoRepository).

Injeção de Dependência: O Controller recebe as dependências via construtor, facilitando a manutenção e testes.

Programação Assíncrona: Uso de Task e await para garantir uma API escalável e de alta performance.

Arquitetura em Camadas: Organização clara entre Entidades, Repositórios, Contratos e Infraestrutura.

📂 Estrutura do Projeto
Controllers/: Contém o ProdutoController, responsável por gerenciar as rotas e requisições HTTP.

Contracts/: Define as interfaces (contratos) que o sistema deve seguir.

Entity/: Classes que representam o modelo de dados do produto.

Infrastructure/: Configurações de banco de dados e persistência.

Repository/: Implementação concreta da persistência de dados.

💻 Como rodar o projeto
Certifique-se de ter o SDK do .NET Core instalado.

Clone o repositório.

No terminal, execute:

Bash
dotnet restore
dotnet run
Acesse o Swagger (geralmente em /swagger) para testar os endpoints visualmente.
