//Exercise 1
bool sPalindrome(string text)
{
    for (var i = 0; i < text.Length / 2; i++)
    {
        if (text[i] != text[text.Length - i - 1])
        {
            return false;
        }

    }
    return true;

}
var a = sPalindrome("anabana");
Console.WriteLine(a);
