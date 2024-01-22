string[] id_number = {"B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179"};
foreach (var id in id_number)
{
    if (id.StartsWith("B"))
    {
        Console.WriteLine(id);
    }
}