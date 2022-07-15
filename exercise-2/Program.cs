//exercise 2
int MinSplit(int amount)
{
	var coins = new List<int> { 1, 5, 10, 20, 50 };
	var count = 0;
	var sum = 0;
    int coin;
    var i = coins.Count - 1;
	if (amount <= 0)
		return 0;
	if (coins.Contains(amount))
		return amount;
    try
    {
		while (i >= 0 && sum < amount)
		{
			coin = coins[i];
			while (coin + sum <= amount)
			{
				sum += coin;
				count++;
			}
			i--;
		}
        if (sum == amount)
		{
			return count;
		}
	}
    catch
    {

    }

	return count;
}
var a = MinSplit(35);
Console.WriteLine(a);