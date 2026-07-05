namespace NBA2026;

public struct PlayerSkills
{
        private int minStat = 40;
        private int maxStat = 95;
        public float speed{get; private set;}
        public int shooting{get; private set;}
        public int snatching{get; private set;}

        
        public PlayerSkills(int height, int weight)
        {
                speed = Math.Clamp(30 - CalculateBMI(height, weight), 1, 10);
                shooting = new Random().Next(minStat, maxStat);
                snatching = new Random().Next(minStat, maxStat);
        }
        
        float CalculateBMI(int height, int weight)
        {
                return weight / (float)Math.Pow(height, 2);
        }
}