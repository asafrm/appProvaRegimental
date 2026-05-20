Markdown
# appProvaA1Carro - Prova Regimental

## 📱 Sobre o Projeto
Este é um aplicativo móvel desenvolvido com o framework .NET MAUI utilizando o Visual Studio 2026. O projeto tem como objetivo principal a implementação de um sistema CRUD (Create, Read, Update, Delete) focado no gerenciamento de uma classe chamada Carro. 

O aplicativo foi construído como parte de um projeto prático focado em Programação Para Dispositivos Móveis (PDM).

## 🛠️ Tecnologias e Dependências
* **Framework:** .NET MAUI.
* **Banco de Dados:** O projeto realiza o acesso e gerenciamento de dados localmente utilizando o banco de dados SQLite.
* **Pacote:** A integração com o banco é feita através da instalação da dependência `sqlite-net-pcl` no gerenciador de pacotes.

## ⚙️ Configurações do Aplicativo
As propriedades do projeto foram ajustadas para atender aos seguintes requisitos de configuração:
* **Nome de Exibição do App:** Prova Regimental.
* **ID do Aplicativo:** `br.edu.udf`.
* **Versão de Exibição:** 1.0.0.
* **Versão do Aplicativo:** 100.
* **Ícones:** Os ícones padrão foram substituídos por ícones personalizados, configurados para as plataformas Windows e Android.

## 📂 Arquitetura e Estrutura de Pastas
O projeto está organizado em três pastas principais, separando a lógica de acesso a dados, os modelos e a interface de usuário:

### 1. Model
* Contém a representação da tabela do banco de dados.
* A classe `Carro` foi implementada contendo os atributos `carID` (int), `carNome` (string) e `carPlaca` (string).

### 2. DAL (Data Access Layer)
* Pasta dedicada ao acesso de dados.
* Contém a classe de conexão com o banco de dados chamada `crudSQLite`.

### 3. Views
* Pasta responsável pelas telas de interface com o usuário.
* **`TelaIncluirCarro`**: Tela para inserção de novos registros.
* **`TelaListaCarro`**: Tela para visualização e listagem dos carros cadastrados.
* **`TelaAlterarCarro`**: Tela para modificação ou exclusão de registros existentes.
