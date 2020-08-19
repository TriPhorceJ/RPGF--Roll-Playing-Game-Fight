using System;

namespace Review
{
  class Program
    {

	static void Main(string[] args)
	{
      Console.WriteLine("Type in your name");
	    string name = Console.ReadLine();
	    string[] eDamage = new string[3]{"punch", "kick", "shoot"};
	    int eDamageCount = eDamage.Length;
    	string[] opponents = new string[16]{"Glitch", "Thanos", "Pac-Man", "Shredder", "Bowser", "HeroBrine", "Finn Balor", "Ganondorf", "Big Chungus", "Pac-Man", "Shredder", "Bowser", "HeroBrine", "Finn Balor", "Ganondorf", $"Dark {name}"};
	    int opponentCount = opponents.Length;
	    int ELife = 100;
	    int Life = 100;
	    int Life2 = 100;
	    Random rnd = new Random();
	    int opponentId = rnd.Next(opponentCount - 1);
	    int eDamageId = rnd.Next(eDamageCount - 1);
	    Console.WriteLine("Choose your diffuculty (Type in Easy Normal Hard or 2player)");
	    string mode = Console.ReadLine().ToLower();
	    if (mode == "easy"){
		Console.WriteLine($"{name} vs {opponents[opponentId]}");
		Console.WriteLine("Attacks are Punch, Kick and Shoot");
		while ((ELife > 0) & (Life > 0)) {
		    string attack = Console.ReadLine().ToLower();
		    if (attack == "cheateasy"){
			int damage = rnd.Next(99, 100);
			Console.WriteLine($"You did {damage} damage!");
			ELife = Math.Max(0, ELife - damage);
			Console.WriteLine($"Enemys life: {ELife}");
		    }
		    if (attack == "punch"){
			int damage = rnd.Next(30, 60);
			Console.WriteLine($"You did {damage} damage!");
			ELife = Math.Max(0, ELife - damage);
			Console.WriteLine($"Enemys life: {ELife}");
		    }
		    if (attack == "kick"){
			int damage = rnd.Next(15, 70);
			Console.WriteLine($"You did {damage} damage!");
			ELife = Math.Max(0, ELife - damage);
			Console.WriteLine($"Enemys life: {ELife}");
		    }
		    if (attack == "shoot"){
			int damage = rnd.Next(0, 70);
			Console.WriteLine($"You did {damage} damage!");
			ELife = Math.Max(0, ELife - damage);
			Console.WriteLine($"Enemys life: {ELife}");
		    }
        if ( ELife  >= 1){
		    if (eDamage[eDamageId] == "punch"){
			int damage = rnd.Next(15, 50);
			Console.WriteLine($"{opponents[opponentId]} {eDamage[eDamageId]}ed you");
			Console.WriteLine($"{opponents[opponentId]} did {damage} damage to you");
			Life = Math.Max(0, Life - damage);
			Console.WriteLine($"Your Life: {Life}");
		    }
		    if (eDamage[eDamageId] == "kick"){
			int damage = rnd.Next(5, 60);
			Console.WriteLine($"{opponents[opponentId]} {eDamage[eDamageId]}ed you");
			Console.WriteLine($"{opponents[opponentId]} did {damage} damage to you");
			Life = Math.Max(0, Life - damage);
			Console.WriteLine($"Your Life: {Life}");
		    }
		    if (eDamage[eDamageId] == "shoot"){
			int damage = rnd.Next(5, 80);
			Console.WriteLine($"{opponents[opponentId]} {eDamage[eDamageId]}ed you");
			Console.WriteLine($"{opponents[opponentId]} did {damage} damage to you");
			Life = Math.Max(0, Life - damage);
			Console.WriteLine($"Your Life: {Life}");
		    }
      }
        if ( Life <= 0){
           Console.WriteLine($"{name} loses");
           Console.WriteLine($"{opponents[opponentId]} beat you");
            }
            if ( ELife  <= 0){
        		    Console.WriteLine($"{name} Wins!");
        		    Console.WriteLine($"You beat {opponents[opponentId]}!");
        		}
    }
	    }
		 if (mode == "normal"){
		Console.WriteLine($"{name} vs {opponents[opponentId]}");
		Console.WriteLine("Attacks are Punch, Kick and Shoot");
		while ((ELife > 0) & (Life > 0)) {
		    string attack = Console.ReadLine().ToLower();
		    if (attack == "cheatnormal"){
			int damage = rnd.Next(99, 100);
			Console.WriteLine($"You did {damage} damage!");
			ELife = Math.Max(0, ELife - damage);
			Console.WriteLine($"Enemys life: {ELife}");
		    }
		    if (attack == "punch"){
			int damage = rnd.Next(25, 50);
			Console.WriteLine($"You did {damage} damage!");
			ELife = Math.Max(0, ELife - damage);
			Console.WriteLine($"Enemys life: {ELife}");
		    }
		    if (attack == "kick"){
			int damage = rnd.Next(10, 60);
			Console.WriteLine($"You did {damage} damage!");
			ELife = Math.Max(0, ELife - damage);
			Console.WriteLine($"Enemys life: {ELife}");
		    }
		    if (attack == "shoot"){
			int damage = rnd.Next(0, 70);
			Console.WriteLine($"You did {damage} damage!");
			ELife = Math.Max(0, ELife - damage);
			Console.WriteLine($"Enemys life: {ELife}");
		    }
        if ( ELife  >= 1){
		    if (eDamage[eDamageId] == "punch"){
			int damage = rnd.Next(25, 50);
			Console.WriteLine($"{opponents[opponentId]} {eDamage[eDamageId]}ed you");
			Console.WriteLine($"{opponents[opponentId]} did {damage} damage to you");
			Life = Math.Max(0, Life - damage);
			Console.WriteLine($"Your Life: {Life}");
		    }
		    if (eDamage[eDamageId] == "kick"){
			int damage = rnd.Next(10, 60);
			Console.WriteLine($"{opponents[opponentId]} {eDamage[eDamageId]}ed you");
			Console.WriteLine($"{opponents[opponentId]} did {damage} damage to you");
			Life = Math.Max(0, Life - damage);
			Console.WriteLine($"Your Life: {Life}");
		    }
		    if (eDamage[eDamageId] == "shoot"){
			int damage = rnd.Next(0, 70);
			Console.WriteLine($"{opponents[opponentId]} {eDamage[eDamageId]}ed you");
			Console.WriteLine($"{opponents[opponentId]} did {damage} damage to you");
			Life = Math.Max(0, Life - damage);
			Console.WriteLine($"Your Life: {Life}");
		    }
      }
        if ( Life <= 0){
           Console.WriteLine($"{name} loses");
           Console.WriteLine($"{opponents[opponentId]} beat you");
            }
            if ( ELife  <= 0){
        		    Console.WriteLine($"{name} Wins!");
        		    Console.WriteLine($"You beat {opponents[opponentId]}!");
        		}
    }
		 }
		 if (mode == "hard"){
		Console.WriteLine($"{name} vs {opponents[opponentId]}");
		Console.WriteLine("Attacks are Punch, Kick and Shoot");
		while ((ELife > 0) & (Life > 0)) {
		    string attack = Console.ReadLine().ToLower();
		    if (attack == "cheathard"){
			int damage = rnd.Next(99, 100);
			Console.WriteLine($"You did {damage} damage!");
			ELife = Math.Max(0, ELife - damage);
			Console.WriteLine($"Enemys life: {ELife}");
		    }
		    if (attack == "punch"){
			int damage = rnd.Next(25, 50);
			Console.WriteLine($"You did {damage} damage!");
			ELife = Math.Max(0, ELife - damage);
			Console.WriteLine($"Enemys life: {ELife}");
		    }
		    if (attack == "kick"){
			int damage = rnd.Next(10, 60);
			Console.WriteLine($"You did {damage} damage!");
			ELife = Math.Max(0, ELife - damage);
			Console.WriteLine($"Enemys life: {ELife}");
		    }
		    if (attack == "shoot"){
			int damage = rnd.Next(0, 70);
			Console.WriteLine($"You did {damage} damage!");
			ELife = Math.Max(0, ELife - damage);
			Console.WriteLine($"Enemys life: {ELife}");
		    }
        if ( ELife  >= 1){
		    if (eDamage[eDamageId] == "punch"){
			int damage = rnd.Next(30, 60);
			Console.WriteLine($"{opponents[opponentId]} {eDamage[eDamageId]}ed you");
			Console.WriteLine($"{opponents[opponentId]} did {damage} damage to you");
			Life = Math.Max(0, Life - damage);
			Console.WriteLine($"Your Life: {Life}");
		    }
		    if (eDamage[eDamageId] == "kick"){
			int damage = rnd.Next(15, 70);
			Console.WriteLine($"{opponents[opponentId]} {eDamage[eDamageId]}ed you");
			Console.WriteLine($"{opponents[opponentId]} did {damage} damage to you");
			Life = Math.Max(0, Life - damage);
			Console.WriteLine($"Your Life: {Life}");
		    }
		    if (eDamage[eDamageId] == "shoot"){
			int damage = rnd.Next(50, 100);
			Console.WriteLine($"{opponents[opponentId]} {eDamage[eDamageId]}ed you");
			Console.WriteLine($"{opponents[opponentId]} did {damage} damage to you");
			Life = Math.Max(0, Life - damage);
			Console.WriteLine($"Your Life: {Life}");
		    }
      }
        if ( Life <= 0){
           Console.WriteLine($"{name} loses");
           Console.WriteLine($"{opponents[opponentId]} beat you");
            }
            if ( ELife  <= 0){
                Console.WriteLine($"{name} Wins!");
                Console.WriteLine($"You beat {opponents[opponentId]}!");
            }
    }
		 }
		 if (mode == "2player"){
        Console.WriteLine("Player 2 type in your name");
		     string name2 = Console.ReadLine();
		     Console.WriteLine($"{name} vs {name2}");
		     while ((Life2 > 0) & (Life > 0)) {
		     Console.WriteLine($"{name}'s turn");
		     string attack = Console.ReadLine().ToLower();
		     if (attack == "punch"){
			 int damage = rnd.Next(15, 50);
			 Console.WriteLine($"{name} did {damage} damage");
			 Life2 = Math.Max(0, Life2 - damage);
			 Console.WriteLine($"{name2}'s life: {Life2}");
		     }
		     if (attack == "kick"){
			 int damage = rnd.Next(10, 60);
			 Console.WriteLine($"{name} did {damage} damage");
			 Life2 = Math.Max(0, Life2 - damage);
			 Console.WriteLine($"{name2}'s life: {Life2}");
		     }
		     if (attack == "shoot"){
			 int damage = rnd.Next(5, 80);
			 Console.WriteLine($"{name} did {damage} damage");
			 Life2 = Math.Max(0, Life2 - damage);
			 Console.WriteLine($"{name2}'s life: {Life2}");
		     }
         if ( Life2  >= 1){
		     Console.WriteLine($"{name2}'s turn");
         string attack2 = Console.ReadLine().ToLower();
		     if (attack2 == "punch"){
			 int damage = rnd.Next(15, 50);
			 Console.WriteLine($"{name2} did {damage} damage");
			 Life = Math.Max(0, Life - damage);
			 Console.WriteLine($"{name}'s Life: {Life}");
		     }
		     if (attack2 == "kick"){
			 int damage = rnd.Next(10, 60);
			 Console.WriteLine($"{name2} did {damage} damage");
			 Life = Math.Max(0, Life - damage);
			 Console.WriteLine($"{name}'s Life: {Life}");
		     }
		     if (attack2 == "shoot"){
			 int damage = rnd.Next(5, 80);
			 Console.WriteLine($"{name2} did {damage} damage");
			 Life = Math.Max(0, Life - damage);
			 Console.WriteLine($"{name}'s Life: {Life}");
		     }
         if ( Life <= 0){
            Console.WriteLine($"{name} loses");
            Console.WriteLine($"{name2} beat you");
             }
           }
           if ( Life2  <= 0){
               Console.WriteLine($"{name} Wins!");
               Console.WriteLine($"You beat {name2}!");
           }
		     }
		 }
		Console.WriteLine("Made by Philip Park");

	}
  }
}
