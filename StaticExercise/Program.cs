namespace StaticExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            var Celcius = TempConverter.FahrenheitToCelsius(50);
            Console.WriteLine($"{Celcius}");

            var Farhenheit = TempConverter.CelsiustoFahrenheit(10);
            Console.WriteLine($"{Farhenheit}");
        }
    }
}
