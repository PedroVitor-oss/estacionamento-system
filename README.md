# 🚗 Sistema de Estacionamento - Desafio DIO (.NET)

Projeto desenvolvido como parte da trilha **.NET - Fundamentos** da plataforma [DIO](https://www.dio.me).

## 📋 Sobre o projeto

Este projeto consiste na criação de um sistema simples de estacionamento, desenvolvido em **C#**, com o objetivo de praticar conceitos fundamentais da linguagem e da plataforma .NET.

O sistema permite gerenciar veículos estacionados, realizando operações como:

* ✅ Adicionar veículos
* ✅ Remover veículos (com cálculo de valor)
* ✅ Listar veículos estacionados
* ✅ Menu interativo no console

---

## 🧠 Conceitos aplicados

Durante o desenvolvimento, foram utilizados os seguintes conceitos:

* Programação orientada a objetos (POO)
* Classes e métodos
* Listas (`List<T>`)
* Tipos primitivos (`float`, `string`)
* Estruturas de controle (`if`, `switch`, `while`)
* Entrada e saída de dados no console

---

## 🏗️ Estrutura da Classe

A classe principal do sistema é:

### `Estacionamento`

#### 🔸 Atributos:

* `precoInicial` → Valor fixo cobrado ao estacionar
* `precoPorHora` → Valor cobrado por hora
* `veiculos` → Lista de placas dos veículos estacionados

#### 🔸 Métodos:

* `AdicionarVeiculo()`

  * Solicita a placa do veículo e adiciona à lista

* `RemoverVeiculo()`

  * Verifica se o veículo está estacionado
  * Solicita o tempo (em horas)
  * Calcula o valor total com base na fórmula:

  ```
  valorTotal = precoInicial + (precoPorHora * horas)
  ```

* `ListarVeiculos()`

  * Exibe todos os veículos estacionados
  * Caso não haja veículos, mostra uma mensagem informativa

---

## 📱 Funcionalidades

O sistema possui um menu interativo no console com as seguintes opções:

```
1 - Cadastrar veículo
2 - Remover veículo
3 - Listar veículos
4 - Encerrar
```

---

## ▶️ Como executar o projeto

### 🔧 Pré-requisitos

* Ter o [.NET SDK](https://dotnet.microsoft.com/) instalado

### 🚀 Passos

```bash
# Clone o repositório
git clonehttps://github.com/PedroVitor-oss/estacionamento-system.git

# Acesse a pasta do projeto
cd seu-repositorio

# Execute o projeto
dotnet run
```

---

## 💡 Exemplo de uso

```text
Digite a placa do veículo: ABC1234
Veículo adicionado com sucesso!

Digite a placa para remover: ABC1234
Digite a quantidade de horas: 2
Valor total: R$ 10,00
```

---

## 📌 Observações

* O sistema é executado via console
* As placas são armazenadas apenas em memória (não há banco de dados)
* Ideal para fins educacionais e prática de lógica

---

## 📚 Créditos

Projeto proposto pela [DIO](https://www.dio.me) na trilha de **Fundamentos .NET**.

