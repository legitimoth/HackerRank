static long repeatedString()
{
    //* variaveis fixas para teste
    var s = "abcac";
    var n = 10;

    //* Encontrar o comprimento da string
    long count = 0;
    int stringLength = s.Length;

    //* Vamos contar quantas vezes a letra "a" aparece na string inicial
    count += s.Count(c => c == 'a');

    //* Multiplicar pela quantidade de vezes que a string sera repetida
    long repetitions = n / stringLength;
    count *= repetitions;

    //* Vamos adicionar a contagem de "a" na ultima parte da string (que pode nao ser completa)
    int remainingChars = (int)(n % stringLength); // O compilador do hacker rank nao aceita Cast implicito!
    count += s.Take(remainingChars).Count(c => c == 'a');

    return count;
}

//* Vamos testar!
Console.WriteLine(repeatedString());