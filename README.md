

# Integração com Cielo Ecommerce Sandbox

## Descrição
Este é um projeto de integração com a **Cielo**, feito com **ASP.NET Core**, **Blazor**, e **Entity Framework** utilizando o **InMemory Database** para simulação de transações de cartão de crédito.

## Pré-requisitos

Antes de rodar o projeto localmente, certifique-se de ter o seguinte instalado:

- [.NET 8 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/8.0)
- [Git](https://git-scm.com/)
- [Visual Studio 2022](https://visualstudio.microsoft.com/) ou acesso a um terminal

## Instalação e Configuração Local

### 1. Clonar o repositório

Abra um terminal ou Git Bash e clone o repositório:

```bash
git clone https://github.com/Mateus-Galvao-de-Camargo/TesteDaUmbler.git
```

### 2. Navegar para o diretório do projeto

Entre na pasta do projeto clonado:

```bash
cd TesteDaUmbler/TesteDaUmbler
```

### 3. Configurar a API da Cielo
#### **OPCIONAL** Caso queira manter os meus é só ignorar essas configurações

O projeto utiliza a API da Cielo para realizar simulações de transações de pagamento. A Cielo oferece gratuitamente as chaves para fazer uso desse ambiente de testes, só e necessário se [cadastrar]([asd](https://cadastrosandbox.cieloecommerce.cielo.com.br/)) e guardar as chaves. Você precisará configurar essas chaves no arquivo `appsettings.json`:

```json
{
  "Cielo": {
    "MerchantId": "SEU_MERCHANT_ID",
    "MerchantKey": "SUA_MERCHANT_KEY",
    "Environment": "sandbox"
  }
}
```

### 4. Rodar o projeto

Como o **EntityFramework InMemory** é usado, não é necessário configurar um banco de dados. O banco de dados em memória será usado para armazenar os dados temporariamente apenas durante a execução do projeto, pois o único objetivo deste projeto é testar a integração com a API da Cielo.

- Para rodar o projeto localmente, execute no terminal:

```bash
dotnet run
```

Ou, se estiver usando o **Visual Studio**:

- Abra o projeto.
- Pressione `F5` para iniciar o projeto em modo de depuração.

### 5. Acessar o projeto

Depois de iniciar o servidor, o projeto estará rodando em `http://localhost:5035`.

### 6. Testar as funcionalidades

Com este projeto você pode: 
- Cadastrar, Editar, Excluir e Visualizar Cartões (CRUD)
- Cadastrar, Capturar, Cancelar e Visualizar Transações de Cartão de Crédito

## Tecnologias Utilizadas

- **ASP.NET Core 8.0**
- **Blazor** (Server-side)
- **Entity Framework Core** (InMemory Database)
- **API da Cielo** para transações de cartão de crédito

## Documentação da API E-Commerce Cielo
https://docs.cielo.com.br/ecommerce-cielo/docs/sobre-api-ecommerce
