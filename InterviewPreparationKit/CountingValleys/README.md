# 🥋 Desafio HackerRank: Counting Valleys

Este repositório contém a solução de um popular desafio de programação do HackerRank, o "Counting Valleys" implementado em linguagem `C#`. **O desafio consiste em contar o número de vales que foram percorridos, ou seja, quantas vezes fomos abaixo do nível do mar e voltamos.**

## 🔗 Links

**Desafio:** https://www.hackerrank.com/challenges/counting-valleys/

## 🎬 Vídeo

[![Solução do Desafio no YouTube](imgs/CountingValley.jpg)](https://youtu.be/j5HtYf-qjZU)

---

## 📝 Problema

<details>
<summary>Português (Brasil)</summary>

### Problematica

Um caminhante ávido mantém registros meticulosos de suas caminhadas. Durante a última caminhada que deu `X` passos exatos, para cada passo foi anotado se era um degrau de subida `U` <sub><sup>(UP)</sub></sub>, ou descida `D` <sub><sup>(DOWN)</sub></sub>. As caminhadas sempre começam e terminam ao nível do mar, e cada degrau acima ou abaixo representa uma mudança unitária na altitude. Definimos os seguintes termos:

- Uma montanha é uma sequência de degraus consecutivos acima do nível do mar, começando com uma subida do nível do mar e terminando com uma descida até o nível do mar.
- Um vale é uma sequência de degraus consecutivos abaixo do nível do mar, começando com um degrau abaixo do nível do mar e terminando com um degrau até o nível do mar.

**Dada a sequência de subidas e descidas de degraus durante uma caminhada, encontre e imprima o número de vales percorridos.**

**Exemplo:**

```csharp
steps = 8 path = [DDUUUUDD]
```
O caminhante primeiro entra em um vale com profundidade de `2` unidades. Então ele escala `2` unidades chegando até o nível do mar e então sobe novamente uma montanha com `2` unidades de altura. Por fim, o caminhante retorna ao nível do mar e encerra a caminhada.

### Descrição

Complete a função `countValleys`.

`countValleys` tem os seguintes parâmetros:
- `int steps`: o número de passos na caminhada .
- `string path`: uma string que descreve o caminho.

### Retorna

`int`: o número de vales percorridos.

### Formato de Entrada

- A primeira linha contém um número inteiro `steps`, o número de passos da caminhada.
- A segunda linha contém uma única string `path` de caracteres `steps` que descrevem o caminho.

### Regras:

- `2 <= steps <= 10ˆ6`
- `path[i] ∋ {UD}` <sup><sub>( ∋ = contém )</sup></sub>

### Demonstração

```csharp
8
UDDDUDUU
```
**Resultado:**
`1`

### Explicação:

Se representarmos `_` como o nível do mar, um degrau para cima como `/` e um degrau para baixo como `\`, a caminhada pode ser desenhada como:

```chsarp
_/\      _
   \    /
    \/\/
```
O caminhante entra e sai de um vale.

</details>

<details>
<summary>English</summary>

An avid hiker keeps meticulous records of their hikes. During the last hike that took exactly `steps` steps, for every step it was noted if it was an uphill, `U` , or a downhill, `D` step. Hikes always start and end at sea level, and each step up or down represents a `1` unit change in altitude. We define the following terms:

A mountain is a sequence of consecutive steps above sea level, starting with a step up from sea level and ending with a step down to sea level.
A valley is a sequence of consecutive steps below sea level, starting with a step down from sea level and ending with a step up to sea level.
Given the sequence of up and down steps during a hike, find and print the number of valleys walked through.

**Example:**

```csharp
steps = 8 path = [DDUUUUDD]
```
The hiker first enters a valley `2` units deep. Then they climb out and up onto a mountain `2` units high. Finally, the hiker returns to sea level and ends the hike.

### Function Description

Complete the countingValleys function in the editor below.

countingValleys has the following parameter(s):

`int steps`: the number of steps on the hike
`string path`: a string describing the path

### Returns

`int`: the number of valleys traversed

### Input Format

The first line contains an integer `steps`, the number of steps in the hike.
The second line contains a single string `path`, of `steps` characters that describe the path.

### Constraints

- `2 <= steps <= 10ˆ6`
- `path[i] ∋ {UD}` <sup><sub>( ∋ = constains )</sup></sub>

### Sample Input

```csharp
8
UDDDUDUU
```
### Sample Output
`1`

### Explanation

If we represent `_` as sea level, a step up as `/`, and a step down as `\`, the hike can be drawn as:

```chsarp
_/\      _
   \    /
    \/\/
```

The hiker enters and leaves one valley.
</details>