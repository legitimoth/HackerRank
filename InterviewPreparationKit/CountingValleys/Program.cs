static int CountValleys(string steps)
{
    var seaLevel = 0;
    var valleys = 0;

    foreach (var step in steps)
    {
        // TODO: nós poderiamos ter utilizado aqui ++seaLevel e --seaLevel
        //* Vale salientar que seaLevel++(--) não funcionaria
        //* pois ele iria retornar o valor antes de incrementar

        seaLevel = step == 'U' ? seaLevel + 1 : seaLevel - 1;

        if(seaLevel == 0 && step == 'U')
        {
            valleys++;
        }
    }

    return valleys;
}

var steps = "DUDUUUUDDD"; //* Nosso caminho
var valleys = CountValleys(steps);

Console.WriteLine(valleys);