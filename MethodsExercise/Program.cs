namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("What is your name?");
            var name = Console.ReadLine();
            
            Console.WriteLine("What is your favorite color?");
            var color = Console.ReadLine();
            
            Console.WriteLine("What is your favorite animal?");
            var animal = Console.ReadLine();
            
            Console.WriteLine("Who is your favorite artist?");
            var artist = Console.ReadLine();
            
            var story = $"Once there was a person who's name was {name}. " +
                        $"{name} really likes the color {color}. Also {name}'s favorite animal is a {animal}. " +
                        $"{name}'s favorite artist is {artist}. That's cool...... Welp, that's the end of the most pointless story, but hey we're practicing C#. I hope you enjoyed it.";
            
            Console.WriteLine(story);*/
            
            
            // Exercise 2
            
            Console.WriteLine(Add(2,3));
            Console.WriteLine(Subtract(8,3));
            Console.WriteLine(Multiply(2,3));
            Console.WriteLine(Divide(15,3));
            
            sumNumbers(1,2,3,4,5,6,7,8,9,10);
            Console.WriteLine(sumNumbers(1,2,3,4,5,6,7,8,9,10));
        

        }

        static int Add(int a, int b)
        {
            return a + b;
        }
        
        static int Subtract(int a, int b)
        {
            return a - b;
        }
        
        static int Multiply(int a, int b)
        {
            return a * b;
        }
        
        static int Divide(int a, int b)
        {
            return a / b;
            
        }
        
       public static int sumNumbers(params int[] numbers)
       {
           int sum = 0;
           foreach (int number in numbers)
           {
               sum = sum + number;
           }

           return sum;
       }
    }
}
