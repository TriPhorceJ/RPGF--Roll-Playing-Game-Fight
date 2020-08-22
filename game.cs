using System;


namespace review
{
class Player
{
  Mode pMode;

  Random rnd;
  string name;

  int Life = 100;
  public Player(string playerName) {
    name = playerName;
    rnd = new Random();
  }
  public void assignMode(Mode m) {
    pMode = m;
  }
  private int assignDamage(int damage) {
    //Console.WriteLine($"You did {damage} damage!");
    //ELife = Math.Max(0, ELife - damage);
    //Console.WriteLine($"Enemys life: {ELife}");
    return(damage);
  }
  public int health() {
    return(Life);
  }
  public string Name() {
    return(name);
  }
  public void takeDamage(int damage) {
    //Console.WriteLine($"{opponents[opponentId]} {eDamage[eDamageId]}ed you");
    //Console.WriteLine($"{opponents[opponentId]} did {damage} damage to you");
    Life = Math.Max(0, Life - damage);
    //Console.WriteLine($"Your Life: {Life}");
  }
  public int kick() {
    int damage = rnd.Next(pMode.kick[0], pMode.kick[1]);
    return(assignDamage(damage));
  }
  public int punch() {
    int damage = rnd.Next(pMode.punch[0], pMode.punch[1]);
    return(assignDamage(damage));
  }
  public int shoot() {
    int damage = rnd.Next(pMode.shoot[0], pMode.shoot[1]);
    return(assignDamage(damage));
  }
}
class Mode
{
  public int[] shoot;
  public int[] punch;
  public int[] kick;

  public Mode() {

  }

  public void strong() {
    shoot = new int[] { 5, 80 };
    punch = new int[] { 30, 60 };
    kick = new int[] { 15, 70 };
  }
  public void weak() {
    kick = new int[] { 5, 60 };
    punch = new int[] { 15, 50 };
    shoot = new int[] { 0, 70 };
  }
}


class Program
{

  static void playerStatus(Player player1, Player player2) {
    Console.WriteLine($"{player1.Name()}: {player1.health()} | {player2.Name()}: {player2.health()}");
  }

  static void attackPhase(Player attacker, Player defender) {

    Console.Write($"{attacker.Name()}: Type in your attack (punch, kick, shoot): ");
    string attackType = Console.ReadLine().ToLower();

    switch (attackType){
      case "shoot":
        defender.takeDamage(attacker.shoot());
        break;
      case "punch":
        defender.takeDamage(attacker.punch());
        break;
      case "kick":
        defender.takeDamage(attacker.kick());
        break;
      default:
        Console.Write($"Attack unknown. You missed.");
        break;
    }
  }

  static Mode setMode(Player player){

    Mode playerMode = new Mode();

    Console.Write($"{player.Name()}: Select your mode (weak or strong): ");
    string mode = Console.ReadLine().ToLower();
    switch (mode){
      case "strong":
        playerMode.strong();
        break;
        case "weak":
      playerMode.weak();
      break;
    }

    return(playerMode);
  }


  static void Main(string[] args)
  {
    //string[] eDamage = new string[3]{"punch", "kick", "shoot"};
    //int eDamageCount = eDamage.Length;
    //int eDamageId = rnd.Next(eDamageCount - 1);

    Console.Write("Type in yor name: ");
    string name = Console.ReadLine();

    Player player1 = new Player(name);
    Mode player1Mode = setMode(player1);
    player1.assignMode(player1Mode);

    Player player2 = new Player("Bob");
    Mode player2Mode = setMode(player2);
    player2.assignMode(player2Mode);

    while ((player2.health() > 0) & (player1.health() > 0)) {

      attackPhase(player1, player2);
      playerStatus(player1, player2);
      if (player2.health() <= 0){
      attackPhase(player2, player1);
      playerStatus(player1, player2);
    }
    }
  }
  }
  }
