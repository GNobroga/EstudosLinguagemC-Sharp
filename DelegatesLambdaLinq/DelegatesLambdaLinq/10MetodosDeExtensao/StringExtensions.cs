namespace _10MetodosDeExtensao;

public static class StringExtensions
{
    public static string InverteString(this string str)
    {
        char[] charArray = str.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }
}
