
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Create Players
        Player George = new StandardPlayer("George");
        Player Paul = new StandardPlayer("Paul");
        Player Ringo = new StandardPlayer("Ringo");
        Player John = new StandardPlayer("John");
        Player Yoko = new PremiumPlayer("Yoko");

        List<Player> all = new()
        {
            George, Paul, Ringo, John, Yoko
        };

        foreach (var p in all)
        {
            p.SetPlayers(all);
        }

        // 1. Premium player starts the chat
        Yoko.Send("John", "Hey John, check out my new Premium skin!");

        // 2. Standard player talks to another Standard player
        Paul.Send("Ringo", "I wish I had that skin. Want to play a round?");

        // 3. Response
        Ringo.Send("Paul", "Let's go! I'm ready.");

        // 4. Standard player asks the Premium player
        John.Send("Yoko", "Can you invite us to the VIP Lobby?");

        // 5. Premium player uses their 'privilege'
        Yoko.Send("John", "Sure! Sending the VIP invite to the whole squad now.");

    }
}

#region Players

class Player
{
    public string Name { get; set; }

    private List<Player> Players;

    public Player(string name)
    {
        Name = name;
    }

    public void SetPlayers(List<Player> list)
    {
        Players = list;
    }

    public void Send(string to, string message)
    {
        var p = Players.FirstOrDefault(p => p.Name == to);
        if (p != null)
        {
            p.Receive(Name, message);
            return;
        }
    }
    

    public virtual void Receive(string from, string message)
    {
        Console.WriteLine($"{from} to {Name}: '{message}'");
    }
}

class StandardPlayer : Player
{
    public StandardPlayer(string name) : base(name) { }

    public override void Receive(string from, string message)
    {
        Console.Write("To a Standard-Player: ");
        base.Receive(from, message);
    }
}

class PremiumPlayer : Player
{
    public PremiumPlayer(string name) : base(name) { }

    public override void Receive(string from, string message)
    {
        Console.Write("To a Premium-Player: ");
        base.Receive(from, message);
    }
}

#endregion



