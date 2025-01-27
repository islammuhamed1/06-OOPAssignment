namespace _06_OOPAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Duration duration1 = new Duration(1, 8, 28);
            Console.WriteLine(duration1.ToString());

            Duration duration2 = new Duration(5000);
            Console.WriteLine(duration2.ToString());

            Duration duration3 = new Duration(12500);
            Console.WriteLine(duration3.ToString());

            Duration duration4 = duration1 + duration2;
            Console.WriteLine($"duration1 + duration2 : {duration4}");

            Duration duration5 = duration3 - duration2;
            Console.WriteLine($"duration3 - duration2 : {duration5}");

            duration4++;
            Console.WriteLine($"duration4++ : {duration4}");

            duration4--;
            Console.WriteLine($"duration4-- : {duration4}");

            Console.WriteLine($"duration1 > duration2 ? {duration1 > duration2}");
            Console.WriteLine($"duration1 <= duration2 ? {duration1 <= duration2}");

            DateTime dateTime = (DateTime)duration1;
            Console.WriteLine($"DateTime After Convert : {dateTime}");
        }
    }
}
