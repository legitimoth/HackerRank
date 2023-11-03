# 🥋 Desafio HackerRank: Sales by Match

Este repositório contém a solução de um popular desafio de programação do HackerRank, o "Sales by Match," implementado em linguagem `C#`. **O desafio consiste em encontrar o número de pares de meias com cores correspondentes em uma lista.**

## 🔗 Links

**Desafio:** https://www.hackerrank.com/challenges/sock-merchant

## 🎬 Vídeo

[![Solução do Desafio no YouTube](imgs/sales-by-match.png)](https://youtu.be/bRwdQIDX8W4)

---

## 📝 Problema

<details>
<summary>Português (Brasil)</summary>

### Problematica

Há uma grande pilha de meias que devem ser combinadas por cor. Dada uma matriz de inteiros representando a cor de cada meia, determine quantos pares de meias com cores correspondentes existem.

**Exemplo:**

```csharp
n = 7;
ar = [1, 2, 1, 2, 1, 3, 2]
```
Existe um par de cores `1` e um de cores `2`. Restam três meias ímpares, uma de cada cor. O número de pares é `2`.

### Descrição

Complete a função `sockMerchant` no editor abaixo.

sockMerchant tem os seguintes parâmetros:

`int n`: número de meias na pilha;
`int ar[n]`: as cores de cada meia

### Retorno

`int`: o número de pares

### Formato de Entrada

A primeira linha contém um número inteiro `n`, o número de meias representadas em `ar`.
A segunda linha contém `n` inteiros separados por espaços, `ar[i]` as cores das meias na pilha.

### Regras:

- `1 <= n <= 100`
- `1 <= ar[i] <= 100 onde 0 <= i < n`

### Demonstração

```csharp
n = 9;
ar = [10, 20, 20, 10, 10, 30, 50, 10, 20];
```
**Resultado:**
`3`

### Explicação:

![Sales By Match Explanation](imgs/example.png)

Existem três pares de meias.
</details>

<details>
<summary>English</summary>

There is a large pile of socks that must be paired by color. Given an array of integers representing the color of each sock, determine how many pairs of socks with matching colors there are.

**Example:**

There is one pair of color `1` and one of color `2`. There are three odd socks left, one of each color. The number of pairs is `2`.

### Function Description

Complete the sockMerchant function in the editor below.

sockMerchant has the following parameter(s):

- `int n`: the number of socks in the pile
- `int ar[n]`: the colors of each sock

### Returns

`int`: the number of pairs

### Input Format

The first line contains an integer `n`, the number of socks represented in `ar`.
The second line contains  space-separated integers, `ar[i]`, the colors of the socks in the pile.

### Constraints

- `1 <= n <= 100`
- `1 <= ar[i] <= 100 where 0 <= i < n`

### Sample Input

```csharp
n = 9;
ar = [10, 20, 20, 10, 10, 30, 50, 10, 20];
```
### Sample Output
```
3
```

### Explanation

![Sales By Match Explanation](imgs/example.png)

There are three pairs of socks.
</details>