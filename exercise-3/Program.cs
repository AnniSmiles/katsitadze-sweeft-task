//exercise 3

int NotContains(int[] array)
{
    var pos = (from num in array where num > 0 orderby num ascending select num).ToArray();
    var number = 0;
    for(var i = 0; i < pos.Count(); i++)
    {
        if(pos[i] != number + 1)
        {
            return number + 1;
        }
        number = pos[i];
    }
    return pos.Last()+1;
}
Console.WriteLine(NotContains(new int[] {-1,1,2,3}));

