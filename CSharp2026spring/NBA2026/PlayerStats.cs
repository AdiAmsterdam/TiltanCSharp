namespace NBA2026;

public struct PlayerStats
{
        Random random = new Random();
        private string _name;
        public float height{get; private set;}
        public int weight {get; private set;}
        public bool isOpponent { get; private set; }

        private static float MinHeight = 1.60f;
        private static float MaxHeight = 2.40f;
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
            this.height =  MinHeight + (random.NextSingle() * (MaxHeight - MinHeight));
            this.weight =  random.Next(MinWeight, MaxWeight);
            this.isOpponent = isOpponent;
        }
}