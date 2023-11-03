//* Esse metodo foi criado de forma que
//* não validamos caso seja passada uma
//* array errada: [0, 1, 1, 1, 0]
static int CountJumpsNoValidation(List<int> clouds)
{
    var jumps = 0;

    while(clouds.Count != 1)
    {
        var skip = clouds.Count > 2 && clouds[2] == 0 ? 2 : 1;
        clouds = clouds.Skip(skip).ToList();
        jumps++;
    }

    return jumps;
}

//* Aqui, caso seja passada uma array inválida
//* retornaremos a quantidade de pulos dados ate então
static int CountJumps(List<int> clouds)
{
    var jumps = 0;

    while(clouds.Count != 1)
    {
        if(clouds.Count > 2 && clouds[2] == 0)
        {
            clouds = clouds.Skip(2).ToList();
        }
        else if(clouds[1] == 0)
        {
            clouds = clouds.Skip(1).ToList();
        }
        else
        {
            return jumps;
        }

        jumps++;
    }

    return jumps;
}

var clouds = new List<int>{0, 0, 1, 0, 0, 1, 0};//{0, 0, 0, 0, 1, 0};
var jumps = CountJumpsNoValidation(clouds);
Console.WriteLine(jumps);