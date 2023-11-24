public static class ToDateTime
{
    public static DateTime Convert(string a)
    {
        DateTime happy = DateTime.ParseExact(a, "dd/MM/yyyy", null);
        return happy;
    }
    public static string ConvertToString(DateTime u )
    {
        return u.ToString("dd/MM/yyyy");
    }
}