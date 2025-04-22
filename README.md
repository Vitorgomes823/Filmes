# Projeto Filmes

Este é um projeto desenvolvido com base no padrão de arquitetura **MVC (Model-View-Controller)** que tem como objetivo gerenciar informações sobre filmes. Ele permite que os usuários visualizem, insiram, editem e excluam informações relacionadas a filmes, oferecendo uma interface amigável e organizada.

## 📋 Estrutura do Projeto

O projeto segue o padrão MVC, que organiza o código em três camadas principais:

### 1. **Model**
A camada Model é responsável pela lógica de negócios e pelo gerenciamento dos dados da aplicação. Nesta camada, você encontrará:
- Classes que representam os filmes (ex.: título, gênero, ano de lançamento, descrição, etc.).
- Métodos para acessar, salvar e manipular dados relacionados aos filmes.

### 2. **View**
A View é responsável por exibir as informações para o usuário e receber as entradas. Nesta camada, você encontrará:
- Páginas HTML que exibem a lista de filmes, detalhes de cada filme e formulários para adicionar ou editar filmes.
- Estilização com **CSS** para melhorar a experiência do usuário.
- Eventualmente, funcionalidades dinâmicas com **JavaScript**.

### 3. **Controller**
A camada Controller atua como intermediária, conectando o Model e o View. Ela processa as requisições do usuário, manipula os dados no Model e retorna as respostas apropriadas para o View. Nesta camada, você encontrará:
- Métodos para gerenciar as rotas principais, como listar filmes, exibir detalhes, criar novos registros, editar e excluir.

## 🚀 Como Executar o Projeto

### Pré-requisitos
Certifique-se de ter os seguintes itens configurados no seu ambiente:
- **.NET Framework ou .NET Core** para executar projetos em C#.
- Um navegador web para acessar a aplicação.
- Um editor de código como **Visual Studio** ou **Visual Studio Code**.

### Passos
1. Clone este repositório:
   ```bash
   git clone https://github.com/Vitorgomes823/Filmes.git
   ```
2. Abra o projeto no **Visual Studio** ou no seu editor favorito.
3. Restaure os pacotes NuGet necessários (se aplicável).
4. Compile e execute o projeto.
5. Acesse o sistema no navegador, geralmente disponível em `http://localhost:5000`.

## 🛠️ Tecnologias Utilizadas

- **C#**: Para a lógica de negócios e controladores.
- **HTML/CSS**: Para a interface do usuário.
- **JavaScript**: Para funcionalidades dinâmicas (se necessário).

## 📦 Funcionalidades

- Listagem de filmes.
- Exibição de informações detalhadas sobre cada filme.
- Adição de novos filmes.
- Edição de filmes existentes.
- Exclusão de filmes.

## 🤝 Contribuição

Contribuições são bem-vindas! Para contribuir:
1. Faça um fork do repositório.
2. Crie uma branch para suas alterações:
   ```bash
   git checkout -b minha-feature
   ```
3. Realize suas alterações e faça o commit:
   ```bash
   git commit -m "Minha nova feature"
   ```
4. Envie suas alterações:
   ```bash
   git push origin minha-feature
   ```
5. Abra um Pull Request.
