## Shop Manoel - API: Documentação Detalhada

Este projeto implementa uma API RESTful para a "Loja do Seu Manoel", utilizando ASP.NET Core. A API fornece funcionalidades para autenticação de usuários e cálculo do empacotamento ideal de produtos em caixas para pedidos.

### Arquitetura do Projeto

O projeto segue uma arquitetura em camadas, com separação clara de responsabilidades:

- **shop.manoel.api:** Contém os controladores da API, responsáveis por receber as requisições HTTP e retornar as respostas.
- **shop.manoel.service:** Contém a lógica de negócio da aplicação, incluindo serviços para autenticação e cálculo de empacotamento.
- **shop.manoel.shared:** Contém modelos de dados compartilhados entre as camadas, interfaces de serviço e classes utilitárias.
- **shop.manoel.test:** Contém os testes unitários da aplicação.

### Funcionalidades da API

#### Autenticação

- **POST /Auth/Login:** Permite que um usuário faça login na API, fornecendo seu nome de usuário e senha. Em caso de sucesso, a API retorna um token JWT que deve ser utilizado para autenticar as requisições subsequentes.

#### Pedidos

- **POST /Order:** Permite calcular a caixa ideal para um conjunto de produtos em um pedido. A API recebe uma lista de pedidos, cada um contendo uma lista de produtos com suas dimensões. A API retorna uma lista de caixas ideais para cada pedido, considerando as dimensões dos produtos e as caixas disponíveis.

### Implementação Detalhada

#### Autenticação (shop.manoel.service.Services.ServiceAuth)

- A autenticação é feita utilizando JWT (JSON Web Token).
- O serviço `ServiceAuth` é responsável por gerar e validar os tokens JWT.
- A configuração da autenticação, incluindo a chave secreta e as informações do emissor e da audiência, é feita no arquivo `appsettings.json`.
- O middleware de autenticação JWT é configurado em `shop.manoel.service.DI.DI.AddAuth`.

#### Cálculo de Empacotamento (shop.manoel.service.Services.ServiceOrder)

- O serviço `ServiceOrder` é responsável por calcular a caixa ideal para um conjunto de produtos.
- O algoritmo de cálculo considera as dimensões dos produtos e as caixas disponíveis, testando diferentes orientações de empilhamento para encontrar a caixa que melhor se adapta aos produtos.
- As dimensões das caixas disponíveis são configuradas no construtor do `ServiceOrder`.
- O método `ProductBoxCalc` realiza o cálculo da caixa ideal para um conjunto de produtos.

### Testes Unitários (shop.manoel.test)

- O projeto inclui testes unitários para as funcionalidades de autenticação e cálculo de empacotamento.
- Os testes utilizam a biblioteca xUnit.
- A classe `Base_Service_Test` fornece uma base para os testes, configurando a aplicação e os serviços.
- A classe `Fake_Data_Test` fornece dados de teste para os testes unitários.

### Dependências

- ASP.NET Core
- JWT
- Serilog
- Swagger
- xUnit

### Como Executar o Projeto

1. Clone o repositório do GitHub.
2. Abra o projeto no Visual Studio ou na sua IDE preferida.
3. Execute o projeto.
4. Acesse a API através do Swagger em `http://localhost:5001/swagger`.

### Executando o DockFile

1. Execute o comando `docker build -t shopmanoelapi .` para criar a imagem do container.
2. Execute o comando `docker run -d -p 5001:5001 shopmanoelapi` para rodar o container.

### Dados de acesso

1 - Para acessar o end point, primeiro você deve logar com os seguintes dados : 
usuario : user / senha : 123456

2 - Pegue o token de retorno e coloque no cabecalho do SWAGGER
3 - OBS : Na esqueca de colocar Bearer antes do token

### Observações

- Este projeto é um exemplo de implementação de uma API RESTful para a "Loja do Seu Manoel".
- O algoritmo de cálculo de empacotamento pode ser otimizado para cenários mais complexos.
- A segurança da API pode ser aprimorada com a implementação de medidas adicionais, como HTTPS e autorização baseada em roles.

### Contribuições

Contribuições são bem-vindas! Sinta-se à vontade para abrir issues ou pull requests no repositório do GitHub.


**Espero que esta documentação detalhada seja útil para entender o projeto "Shop Manoel - API".**