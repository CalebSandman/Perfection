class IsInputNumber{
    public static int? GetNumber(string input)
    {
        if (int.TryParse(input, out int number))
        {
            return number;
        }
        return null;
    }
}