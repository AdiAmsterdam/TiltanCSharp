namespace NBA2026;

public struct PlayerStats
{
        private string _name;
        public int height{get; private set;}
        public int weight {get; private set;}
        public bool isOpponent { get; private set; }

        private static int MinHeight = 160;
        private static int MaxHeight = 240;
        private static int MinWeight = 80;
        private static int MaxWeight = 120;


        public string name
        {
            get
            {
                return _name;
            }
            set
            {
                if (string.IsNullOrEmpty(_name))
                {
                    _name = "Lebron";
                }
                else
                {
                    _name = value;
                }
            }
        }
        
        public PlayerStats(string name, bool isOpponent)
        {
            this.name = name;
            this.height = new Random().Next(MinHeight, MaxHeight);
            this.weight = new Random().Next(MinWeight, MaxWeight);
            this.isOpponent = isOpponent;
        }
}