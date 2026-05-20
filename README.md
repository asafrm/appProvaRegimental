Markdown
# appProvaA1Carro - Prova Regimental

## 📱 Sobre o Projeto
[cite_start]Este é um aplicativo móvel desenvolvido com o framework .NET MAUI utilizando o Visual Studio 2026[cite: 8]. [cite_start]O projeto tem como objetivo principal a implementação de um sistema CRUD (Create, Read, Update, Delete) focado no gerenciamento de uma classe chamada Carro[cite: 8, 9, 13]. 

[cite_start]O aplicativo foi construído como parte das diretivas de projeto da disciplina de Programação Para Dispositivos Móveis (PDM) do curso de Ciência da Computação do Centro Universitário do DF (UDF)[cite: 3, 4, 5, 6].

## 🛠️ Tecnologias e Dependências
* [cite_start]**Framework:** .NET MAUI[cite: 8].
* [cite_start]**Banco de Dados:** O projeto realiza o acesso e gerenciamento de dados localmente utilizando o banco de dados SQLite[cite: 16].
* [cite_start]**Pacote:** A integração com o banco é feita através da instalação da dependência `sqlite-net-pcl` no gerenciador de pacotes[cite: 44, 70].

## ⚙️ Configurações do Aplicativo
As propriedades do projeto foram ajustadas para atender aos seguintes requisitos de configuração:
* [cite_start]**Nome de Exibição do App:** O nome foi alterado para Prova Regimental[cite: 14].
* [cite_start]**ID do Aplicativo:** Configurado como `br.edu.udf`[cite: 14].
* [cite_start]**Versão de Exibição:** Configurada para a versão 1.0.0[cite: 14].
* [cite_start]**Versão do Aplicativo:** Definida com o valor 100[cite: 14].
* [cite_start]**Ícones:** Os ícones padrão foram substituídos por ícones personalizados gratuitos, configurados para as plataformas Windows e Android[cite: 15, 89].

## 📂 Arquitetura e Estrutura de Pastas
[cite_start]O projeto está organizado em três pastas principais, separando a lógica de acesso a dados, os modelos e a interface de usuário[cite: 17]:

### 1. Model
* [cite_start]Esta pasta contém a representação da tabela do banco de dados[cite: 83].
* [cite_start]A classe `Carro` foi implementada contendo os atributos `carID` (int), `carNome` (string) e `carPlaca` (string)[cite: 9, 10, 11, 12].

### 2. DAL (Data Access Layer)
* [cite_start]Pasta dedicada ao acesso de dados[cite: 17].
* [cite_start]Contém a classe de conexão com o banco de dados chamada `crudSQLite`[cite: 86].

### 3. Views
* [cite_start]Pasta responsável pelas telas de interface com o usuário[cite: 17].
* [cite_start]**`TelaIncluirCarro`**: Tela para inserção de novos registros[cite: 71].
* [cite_start]**`TelaListaCarro`**: Tela para visualização e listagem dos carros cadastrados[cite: 71].
* [cite_start]**`TelaAlterarCarro`**: Tela para modificação ou exclusão de registros existentes[cite: 71].
