namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
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
            
            Console.WriteLine(story);
        }
    }
}
