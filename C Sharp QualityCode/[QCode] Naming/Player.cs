namespace minesweepers
{
    public class Player
    {
        string playerName;
        int playerPoints;

        public string PlayerName
        {
            get { return playerName; }
            set { this.playerName = value; }
        }

        public int PlayerPoints
        {
            get { return playerPoints; }
            set { playerPoints = value; }
        }

        public Player() { }

        public Player(string name, int points)
        {
            this.PlayerName = name;
            this.PlayerPoints = points;
        }
    }
}