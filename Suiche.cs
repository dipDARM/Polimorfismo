class Suiche
{
    public static string Describir(object o)
    {
        switch (o)
        {
            case int n:
                return $"entero {n}";

            case string s:
                return $"texto {s}";

            case null:
                return "nada";

            default:
                return "otro";
        }
    }
}