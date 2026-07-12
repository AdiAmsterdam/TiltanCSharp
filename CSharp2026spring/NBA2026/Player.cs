namespace NBA2026;

public class Player
{
    //Game Stats
    public static int teamScore = 0;
    public static int opponentScore = 0;
    
    //Player Stats
    public PlayerStats stats{get;}
    PlayerSkills skills;
    private Ball hasball = null;
    public int score;


    public Player(string name, bool isOpponent)
    {
        this.stats = new PlayerStats(name, isOpponent);
        this.skills = new PlayerSkills(stats.height, stats.weight);
        this.score = 0;
    }
    /*public Player(string name, int height, int weight, bool isOpponent)
    {
        if (string.IsNullOrEmpty(name))
        {
            this.stats.name = "Lebron";
        }
        else
        {
            this.stats.name = name;
        }

        this.stats.height = Math.Clamp(height, 160, 240);
        this.stats.weight = Math.Clamp(weight, 80, 120);
        this.stats.isOpponent = isOpponent;
        this.score = 0;
        
        this.skills.speed =Math.Clamp(30 - CalculateBMI(this.stats.height, this.stats.weight), 1, 10);
        this.skills.shooting = new Random().Next(40, 95);
        this.skills.snatching = new Random().Next(40, 95);
    }
*/

    public PlayerSkills GetSkills()
    {
        return this.skills;
    }

    public Ball GetBall()
    {
        return this.hasball;
    }

    public void SetBall(Ball ball)
    {
        this.hasball = ball;
    }

    

    void Jump()
    {
        Console.WriteLine($"{this.stats.name} jumped");
    }

    void Run()
    {
        Console.WriteLine($"{this.stats.name} runs at a speed of: {GetSkills().speed}");
    }

    public void PassBall(Player teamate)
    {
        if (!teamate.stats.isOpponent && !stats.isOpponent && hasball != null)
        {
            teamate.SetBall(hasball);
            SetBall(null);
        }
    }
    
    public void ShootToBasket()
    {
        Jump();
        int accuracy = new Random().Next(1, 100);
        if (accuracy <= GetSkills().shooting)
        {
            SetBall(null);
            this.score = this.score + 2;
            if (!stats.isOpponent)
            {
                Console.WriteLine(stats.name + " (team) has scored!");
                Console.WriteLine();
                teamScore = teamScore + 2;
            }
            else
            {
                Console.WriteLine(stats.name + " (opponent) has scored!");
                Console.WriteLine();
                opponentScore = opponentScore + 2;
            }
            ShowScore();
        }
        else
        {
            Console.WriteLine(stats.name + " has missed");
            Console.WriteLine();
        }
    }
    
    
    public void Snatch(Player opponent)
    {
        if (!stats.isOpponent && opponent.stats.isOpponent && opponent.GetBall() != null)
        {
            Run();
            int accuracy = new Random().Next(1, 100);
            if (accuracy <= GetSkills().snatching)
            {
                SetBall(opponent.GetBall());
                opponent.SetBall(null);
                Console.WriteLine(stats.name + " has snatched the ball");
                Console.WriteLine();
            }
        }
    }

    public static void ShowScore()
    {
        Console.WriteLine($"Score - Team: {teamScore}, Opponent: {opponentScore}");
    }

    public static void ShowPlayerScore(Player player)
    {
        if (player.score == 0)
        {
            Console.WriteLine($"{player.stats.name} hasn't scored yet");
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine($"{player.stats.name} has scored {player.score} points");
            Console.WriteLine();
        }
    }

    public void PrintStats()
    {
        Console.WriteLine($"Name: {this.stats.name}");
        Console.WriteLine($"Height: {this.stats.height:F2}");
        Console.WriteLine($"Weight: {this.stats.weight}");
        Console.WriteLine($"IsOpponent: {this.stats.isOpponent}");
        Console.WriteLine($"Score: {this.score}");
        Console.WriteLine($"hasball: {this.hasball}");
        Console.WriteLine($"Speed: {this.skills.speed:F1}");
        Console.WriteLine($"Shooting Skill: {this.skills.shooting}");
        Console.WriteLine($"Snatching Skill: {this.skills.snatching}");
        Console.WriteLine();
    }
}