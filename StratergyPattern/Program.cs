using StratergyPattern;

class Program
{
    static void Main(string[] args)
    {
        // Initialize the bot with a default behaviour
        Bot bot = new Bot("AlphaBot", 100, new PatrolBehaviour());

        // Simulate game loop
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine($"\n--- Game Loop Iteration {i + 1} ---");

            // Dynamic behaviour switching based on conditions
            if (bot.Health < 30)
            {
                bot.SetBehaviour(new DefensiveBehaviour());
            }
            else if (bot.EnemyHealth > 0 && bot.Health >= 30)
            {
                bot.SetBehaviour(new AggressiveBehaviour());
            }
            else
            {
                bot.SetBehaviour(new PatrolBehaviour());
            }

            // Perform the current action
            bot.PerformAction();

            // End the loop if the bot or enemy is "dead"
            if (bot.Health <= 0)
            {
                Console.WriteLine($"{bot.Name} has been defeated!");
                break;
            }

            // Simulate enemy attacking the bot
            else if (bot.EnemyHealth > 0)
            {
                bot.Health -= 15;
                Console.WriteLine($"Enemy attacks! {bot.Name}'s health is now {bot.Health}.");
            }

            if (bot.EnemyHealth <= 0)
            {
                Console.WriteLine("Enemy defeated! Mission accomplished.");
                break;
            }
        }
    }
}
