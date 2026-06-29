using System.Globalization;
using NBA2026;
Player[] team =  new Player[3];
Player[] opponent = new Player[3];
Ball b = new Ball();

// ===============================
// Game Demonstration
// ===============================

// Team Creations
Console.WriteLine("Create your team");
CreateTeam(team, false);
Console.WriteLine("Create your opponent");
CreateTeam(opponent, true);


// Give the ball to the first player on your team
team[0].SetBall(b);

Console.WriteLine("===== TEAM PLAYERS =====");
ShowTeam(team);

Console.WriteLine("===== OPPONENT PLAYERS =====");
ShowTeam(opponent);


// Team player shoots
Console.WriteLine($"{team[0].GetStats().name} attempts a shot...");
team[0].ShootToBasket();


// Give the ball to an opponent
opponent[0].SetBall(b);

if (opponent[0].GetBall() != null) Console.WriteLine($"{opponent[0].GetStats().name} now has the ball.");


// Team player attempts to steal
Console.WriteLine($"{team[1].GetStats().name} attempts to snatch the ball...");
team[1].Snatch(opponent[0]);


// If the steal was successful, shoot
if (team[1].GetBall() != null)
{
    Console.WriteLine($"{team[1].GetStats().name} goes for the basket...");
    team[1].ShootToBasket();
}
else
{
    Console.WriteLine("The snatch failed.");
}


// Opponent tries to score
if (opponent[0].GetBall() != null)
{
    Console.WriteLine($"{opponent[0].GetStats().name} shoots...");
    opponent[0].ShootToBasket();
}


// Display final score
Console.WriteLine("===== FINAL GAME SCORE =====");
Player.ShowScore();


// Display individual scores
Console.WriteLine("===== PLAYER SCORES =====");

foreach (Player player in team)
{
    Player.ShowPlayerScore(player);
}

foreach (Player player in opponent)
{
    Player.ShowPlayerScore(player);
}





void CreateTeam(Player[] players, bool side)
{
    string name;
    bool isOpponent = side;
    if(players.Length > 0){
        for (int i = 0; i < players.Length; i++)
        {
            Console.WriteLine($"Enter the player's {i+1} name");
            name = Console.ReadLine();
            players[i] = new Player(name, isOpponent);
        }
    }
}

void ShowTeam(Player[] players)
{
    foreach (var player in players)
    {
        player.PrintStats();
    }
}