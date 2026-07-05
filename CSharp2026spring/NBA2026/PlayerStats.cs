namespace NBA2026;

public struct PlayerStats
{
        private string _name;
        private int height{get; set; }
        private int weight {get; set; }
        public bool isOpponent;
        private static int MinHeight = 160;
        private static int MaxHeight = 240;

        public string name
        {
            get
            {
                return _name;
            }
            set
            {
                if (string.IsNullOrEmpty(name))
                {
                    name = "Lebron";
                }
                else
                {
                    name = value;
                }
            }
        }

        
        
        
        
        public PlayerStats(string name, bool isOpponent)
        {
            this.name = name;
            this.height = new Random().Next(MinHeight, MaxHeight);
            this.weight = new Random().Next(80, 120);
            this.isOpponent = isOpponent;
        }
}