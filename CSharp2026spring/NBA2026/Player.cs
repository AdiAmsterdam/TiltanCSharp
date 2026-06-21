namespace NBA2026;

public class Player
{
    PlayerStats stats = new PlayerStats();
    PlayerSkills skills = new PlayerSkills();


    
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
        
        this.skills.speed = this.stats.weight / Math.Pow(this.stats.height);
    }
}