using System;
using System.Xml;
using System.Xml.Serialization;
using System.IO;

namespace review
{
  public class Player
  {

    public Random rnd;
    public string name;
    public int ab1;
    public int ab2;
    public int ab3;
    public string ab1n;
    public string ab2n;
    public string ab3n;
    public int strength;
    public string weakness;
    public int defence;
    public string image;


    int Life = 100;
    public Player() {
      name = "";
      rnd = new Random();
    }
    public void assignName(string playerName) {
      name = playerName;
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
  }


class Program
{
  static void screen(){
    Console.Clear();
    Console.WriteLine("+---------------------------------------------------------------+");
    Console.WriteLine("|                                                               |");
    Console.WriteLine("|                                                               |");
    Console.WriteLine("|                                                               |");
    Console.WriteLine("|                                                               |");
    Console.WriteLine("|                                                               |");
    Console.WriteLine("|                                                               |");
    Console.WriteLine("|                                                               |");
    Console.WriteLine("|                                                               |");
    Console.WriteLine("+---------------------------------------------------------------+");
  }

  static void playerStatus(Player player1, Player player2) {
    Console.WriteLine($"{player1.Name()}: {player1.health()} | {player2.Name()}: {player2.health()}");
  }
  static void attackPhase2p(Player attacker, Player defender) {
    Console.Write($"{attacker.Name()}: Attack (Press a to {attacker.ab1n}, Press b to {attacker.ab2n}, Press c to {attacker.ab3n}): ");
    string[] choices = {$"{attacker.ab1n.PadRight(100)}", $"{attacker.ab2n.PadRight(100)}", $"{attacker.ab3n.PadRight(100)}"};
    int attackType = ChooseItem(choices, "Attack: ");
    switch (attackType){
      case 0:
        defender.takeDamage(attacker.ab1 + attacker.strength - defender.defence);
        break;
      case 1:
        defender.takeDamage(attacker.ab2 + attacker.strength - defender.defence);
        break;
      case 2:
        defender.takeDamage(attacker.ab3 + attacker.strength - defender.defence);
        break;
    }
  }

static void attackPhase1p(Player cpu, Player person){
  Random rnd = new Random();
    string[] eDamage = new string [3]{"1", "2", "3"};
    int eDamageCount = eDamage.Length;
    int eDamageId = rnd.Next(eDamageCount - 1);

    switch (eDamage[eDamageId]){
      case "2":
        person.takeDamage(cpu.ab3 + cpu.strength - person.defence);
        Console.WriteLine($"{cpu.Name()} used {cpu.ab3n} on you! ");
        break;
      case "0":
        person.takeDamage(cpu.ab1 + cpu.strength - person.defence);
        Console.WriteLine($"{cpu.Name()} used {cpu.ab1n} on you! ");
        break;
      case "1":
        person.takeDamage(cpu.ab2 + cpu.strength - person.defence);
        Console.WriteLine($"{cpu.Name()} used {cpu.ab2n} on you! ");
        break;
}
}

    static void InfoScreen() {

  Console.Clear();
  Console.WriteLine("+---------------------------------------------------------------+");
  Console.WriteLine("|                                                               |");
  Console.WriteLine("| RPG Fight  v0.1                                               |");
  Console.WriteLine("| By TriPhorceJ 2020                                            |");
  Console.WriteLine("| Press any key to start.                                       |");
  Console.WriteLine("|                                                               |");
  Console.WriteLine("+---------------------------------------------------------------+");
  Console.ReadKey(true);

    }

static Player ChooseFighter(Player[] fighters) {

  int fighterCount = fighters.Length;
  //ConsoleKeyInfo cki;
  int fighterChoice = -1;
  char firstChoice = 'a';

  Console.Clear();
  Console.WriteLine("+---------------------------------------------------------------+");
  Console.WriteLine("|                                                               |");
  Console.WriteLine("| RPG Fight  v0.1                                               |");
  Console.WriteLine("| By TriPhorceJ 2020                                            |");
  Console.WriteLine("|                                                               |");
  Console.WriteLine("| Choose your fighter.                                          |");

  for (int a = 0; a < fighterCount; a++) {
      Console.WriteLine($"| {(Char) (firstChoice + a)}: {fighters[a].Name().PadRight(20)}                                       |");
  }
  Console.WriteLine("|                                                               |");
  Console.WriteLine("+---------------------------------------------------------------+");

  string[] playerNames = new string[fighters.Length];
  for (int a = 0; a < fighters.Length; a++) {
    playerNames[a] = fighters[a].Name();
  }
  fighterChoice = ChooseItem(playerNames, "Chosen Fighter:");
   return(fighters[fighterChoice]);
}



static int ChooseItem(string[] items, string statement) {

  int itemChoice = -1;
  bool validChoice = false;
  int lastChoice = -1;
  bool validLastChoice = false;

  ConsoleKeyInfo UserInput;

  while (true) {
     //ConsoleKeyInfo UserInput = Console.ReadKey(true);
     //if ((UserInput.Key == ConsoleKey.Enter) & (validChoice)) {
    //   break;
     //}
     //itemChoice = ((char) UserInput.KeyChar) - 'a';

     do {
       UserInput = Console.ReadKey(true);
       if ((UserInput.Key == ConsoleKey.Enter) & (validLastChoice)) {
         break;
       }
       itemChoice = ((char) UserInput.KeyChar) - 'a';
       if (itemChoice < 0 | itemChoice >= items.Length) {
         validChoice = false;
       } else {
         validChoice = true;
         lastChoice = itemChoice;
         validLastChoice = true;
       }
     } while(!validChoice);
     Console.Write($"\r{statement} {items[lastChoice].PadRight(30)}");
     if ((UserInput.Key == ConsoleKey.Enter) & (validLastChoice)) {
       break;
     }
 }
 return(lastChoice);

}



static int MainMenu() {

  Console.Clear();
  Console.WriteLine("+---------------------------------------------------------------+");
  Console.WriteLine("|+--------------------+                                         |");
  Console.WriteLine("||     #@@@@#         |   RPG Fight  v0.1                       |");
  Console.WriteLine("||    @WWWWWM@        |  By TriPhorceJ 2020                     |");
  Console.WriteLine("||   #WWWWM$WM        |                                         |");
  Console.WriteLine("||   #@@$@@#$$#@#     |[press a to play 1 player]               |");
  Console.WriteLine("||    @@@@@@@@$WM$@#  |[press b to play 2 player]               |");
  Console.WriteLine("||     @@@@@@$WWWWMM$@|                                         |");
  Console.WriteLine("||      @@@@MWWWWWWWWM|                                         |");
  Console.WriteLine("||       ##WMMWWWWWWMW|                                         |");
  Console.WriteLine("||         $$MWWWWWWMM|                                         |");
  Console.WriteLine("|| HEY!    @$MMWWWWMMW| In memory of S.K -We are                |");
  Console.WriteLine("|+--------------------+                   number one!           |");
  Console.WriteLine("+---------------------------------------------------------------+");
  string[] choices = {"1 Player", "2 Player"};
  int PlayerAmount = ChooseItem(choices, "Mode:");
  return(PlayerAmount);
}

  static void Main(string[] args)
  {

    InfoScreen();
    int playerCount = MainMenu();
    Console.WriteLine(playerCount);
    XmlSerializer serializer = new XmlSerializer(typeof(Player));
    FileStream fs;
    string fileName;
    string [] fileEntries = Directory.GetFiles("fighters", "*.xml");
    Player[] fighters = new Player[fileEntries.Length];
    for (int a = 0; a < fileEntries.Length; a++) {
    //foreach(string fileName in fileEntries) {
        //ProcessFile(fileName);
        fileName = fileEntries[a];
        //Console.WriteLine($"Found: {fileName}");
        fs = new FileStream(fileName, FileMode.Open);
        fighters[a] = (Player) serializer.Deserialize(fs);
        fs.Close();
    }
    Player player1 = ChooseFighter(fighters);
    Player player2 = ChooseFighter(fighters);
    //Mode player1Mode = (player1);

    //delegate void attackPhase(Player attacker, Player defender);
    screen();
    playerStatus(player1, player2);
    while ((player2.health() > 0) & (player1.health() > 0)) {
      attackPhase2p(player1, player2);
      playerStatus(player1, player2);
      if (player2.health() <= 0){
        break;
      }
      if (playerCount == 1){
        attackPhase2p(player2, player1);
        playerStatus(player1, player2);
      }
      else {
        attackPhase1p(player2, player1);
        playerStatus(player1, player2);
      }
    }
    if (player1.health() > 0){
    Console.WriteLine($"{player1.Name()} wins");
  }
  else {
    Console.WriteLine($"{player2.Name()} wins");
  }
  }
}
}
