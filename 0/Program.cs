try
{
    Console.Write("Введите h: ");
    double h = double.Parse(Console.ReadLine());
    Console.Write("Введите y: ");
    double y = double.Parse(Console.ReadLine());
    Console.Write("Введите e:");
    double e = double.Parse(Console.ReadLine());
    double P = Math.Pow(Math.Exp(e), y+2.5) + 7.1 * Math.Pow(h,3)/Math.Log(Math.Sqrt(y + 0.04*h));
    Console.WriteLine($"Ответ P = {P:F2}");
}
catch
{
    Console.WriteLine("Error");
}