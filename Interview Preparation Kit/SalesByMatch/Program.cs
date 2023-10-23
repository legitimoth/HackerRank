
static int CountPairsDoTh(List<int> sockList)
{
    var checkList = new HashSet<int>();
    int pairQtd = 0;

    sockList.ForEach(sock => {
        if(!checkList.Add(sock))
        {
            checkList.Remove(sock);
            pairQtd++;
        }
    });

    return pairQtd;
}

static int CountPairs(List<int> sockList)
{
    //* Quantidade de pares
    int pairQtd = 0;

    while(sockList.Count != 1)
    {
        //* Guarda a meia
        int sock = sockList[0];

        //* Exclui a meia atual
        sockList.RemoveAt(0);

        //* Procura o par
        int sockPairIndex = sockList.IndexOf(sock);

        //* Verifica se encontrou
        if(sockPairIndex != -1)
        {
            //* Remove o par
            sockList.RemoveAt(sockPairIndex);
            pairQtd++;
        }
    }

    return pairQtd;
}


List<int> sockList = new () { 10, 20, 20, 10, 10, 30, 50, 10, 20 };

int result = CountPairsDoTh(sockList);

Console.WriteLine(result);