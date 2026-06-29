namespace NBA2026;

public class Player
{
    //Game Stats
    public static int teamScore = 0;
    public static int opponentScore = 0;
    
    //Player Stats
    PlayerStats stats = new PlayerStats();
    PlayerSkills skills = new PlayerSkills();
    private Ball hasball = null;
    public int score;

    
    Player(string name, int height, int weight, bool isOpponent)
    {
        if (string.IsNullOrEmpty(name))
        {
            this.stats.name = "Lebron";
        }
        else
        {
            this.stats.name = name;
        }

        this.stats.height = Math.Clamp(height, 160, 220);
        this.stats.weight = Math.Clamp(weight, 70, 100);
        this.stats.isOpponent = isOpponent;
        this.score = 0;
        
        this.skills.speed =Math.Clamp(30 - CalculateBMI(this.stats.height, this.stats.weight), 1, 10);
    }

    public PlayerStats GetStats()
    {
        return this.stats;
    }

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

    float CalculateBMI(int height, int weight)
    {
        return weight / (float)Math.Pow(height, 2);
    }

    void jump()
    {
        Console.WriteLine("Player jumped");
    }

    void Run()
    {
        Console.WriteLine("the player runs at a speed of: " + (GetSkills().speed));
    }

    void PassBall(Player teamate)
    {
        if (!teamate.GetStats().isOpponent && !GetStats().isOpponent && hasball != null)
        {
            teamate.SetBall(hasball);
            SetBall(null);
        }
    }
    
    public void ShootToBasket()
    {
        int accuracy = new Random().Next(1, 100);
        if (accuracy <= GetSkills().shooting)
        {
            Console.WriteLine(GetStats().name + "has scored!");
            SetBall(null);
            this.score = this.score + 2;
            if (!GetStats().isOpponent)
            {
                teamScore = teamScore + 2;
            }
            else
            {
                opponentScore = opponentScore + 2;
            }
        }
        else Console.WriteLine(GetStats().name + "has missed");
    }
    
    
    public void Snach(Player opponent)
    {
        if (!GetStats().isOpponent && opponent.GetStats().isOpponent && opponent.GetBall() != null)
        {
            int accuracy = new Random().Next(1, 100);
            if (accuracy <= GetSkills().snatching)
            {
                Console.WriteLine(GetStats().name + "has snatched the ball");
                SetBall(opponent.GetBall());
                opponent.SetBall(null);
                
            }
        }
    }
}