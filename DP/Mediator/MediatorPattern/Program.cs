
using System;
using System.Collections.Generic;

namespace DoFactory.GangOfFour.Mediator.NETOptimized
{
    /// <summary>
    /// MainApp startup class for .NET optimized 
    /// Mediator Design Pattern.
    /// </summary>
    class MainApp
    {
        /// <summary>
        /// Entry point into console application.
        /// </summary>
        static void Main()
        {
            // Create chatroom participants
            Player George = new StandardPlayer { Name = "George" };
            Player Paul = new StandardPlayer { Name = "Paul" };
            Player Ringo = new StandardPlayer { Name = "Ringo" };
            Player John = new StandardPlayer { Name = "John" };
            Player Yoko = new PremiumPlayer { Name = "Yoko" };

            // Create chatroom and register participants
            var chatroom = new Chatroom();
            chatroom.Register(George);
            chatroom.Register(Paul);
            chatroom.Register(Ringo);
            chatroom.Register(John);
            chatroom.Register(Yoko);

            // Chatting participants
            // 1. Premium player starts the chat
            Yoko.Send("John", "Hey John, check out my new Premium skin!");

            // 2. Standard player talks to another Standard player
            Paul.Send("Ringo", "I wish I had that skin. Want to play a round?");
            p
            // 3. Response
            Ringo.Send("Paul", "Let's go! I'm ready.");

            // 4. Standard player asks the Premium player
            John.Send("Yoko", "Can you invite us to the VIP Lobby?");

            // 5. Premium player uses their 'privilege'
            Yoko.Send("John", "Sure! Sending the VIP invite to the whole squad now.");
        }
    }

    /// <summary>
    /// The 'Mediator' interface
    /// </summary>
    interface IChatroom
    {
        void Register(Player Player);
        void Send(string from, string to, string message);
    }

    /// <summary>
    /// The 'ConcreteMediator' class
    /// </summary>
    class Chatroom : IChatroom
    {
        private Dictionary<string, Player> _participants =
            new Dictionary<string, Player>();

        public void Register(Player Player)
        {
            if (!_participants.ContainsKey(Player.Name))
            {
                _participants.Add(Player.Name, Player);
            }

            Player.Chatroom = this;
        }

        public void Send(string from, string to, string message)
        {
            var Player = _participants[to];
            if (Player != null)
            {
                Player.Receive(from, message);
            }
        }
    }

    /// <summary>
    /// The 'AbstractColleague' class
    /// </summary>
    class Player
    {
        // Gets or sets Player name
        public string Name { get; set; }

        // Gets or sets chatroom
        public Chatroom Chatroom { get; set; }

        // Send a message to given Player
        public void Send(string to, string message)
        {
            Chatroom.Send(Name, to, message);
        }

        // Receive message from Player
        public virtual void Receive(
            string from, string message)
        {
            Console.WriteLine("{0} to {1}: '{2}'",
                from, Name, message);
        }
    }

    /// <summary>
    /// A 'ConcreteColleague' class
    /// </summary>
    class StandardPlayer : Player
    {
        public override void Receive(string from, string message)
        {
            Console.Write("To a Standard Player: ");
            base.Receive(from, message);
        }
    }

    /// <summary>
    /// A 'ConcreteColleague' class
    /// </summary>
    class PremiumPlayer : Player
    {
        public override void Receive(string from, string message)
        {
            Console.Write("To a Premium Player: ");
            base.Receive(from, message);
        }
    }
}


