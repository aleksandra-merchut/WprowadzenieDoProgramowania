using System;

class MainClass {
  public static void Main (string[] args) {
    string figurine = "Papier-Kamień-Nożyce";
    bool game = true;
    Console.WriteLine ("Witaj w grze "+figurine);

   Console.WriteLine ("Graczu #1, jak masz na imię?");
   string firstPlayerName = Console.ReadLine();

   Console.WriteLine ("Graczu #2, jak masz na imię?");
   string secondPlayerName = Console.ReadLine();
   while(game==true){   
    Console.WriteLine ("Graczu " + firstPlayerName + " wybierz jedną z figur: " +figurine);
    Console.WriteLine ("Aby dokonać wyboru wpisz pierwszą literę figury");
    string firstPlayerChoice = Console.ReadLine();
    Console.Clear();
    Console.WriteLine ("Graczu " + secondPlayerName + " wybierz jedną z figur: " +figurine);
    Console.WriteLine ("Aby dokonać wyboru wpisz pierwszą literę figury");
    string secondPlayerChoice = Console.ReadLine();
    Console.Clear();
    if (firstPlayerChoice.ToUpper() == secondPlayerChoice.ToUpper()) {
      Console.WriteLine ("REMIS");
      }else{
        if((firstPlayerChoice.ToUpper() == "P" && secondPlayerChoice.ToUpper() == "K" ) ||(firstPlayerChoice.ToUpper() == "K" && secondPlayerChoice.ToUpper() == "N" )||(firstPlayerChoice.ToUpper() == "N" && secondPlayerChoice.ToUpper() == "P" ) ){
          Console.WriteLine ("Gracz " + firstPlayerName + " wygrywa, gratulacje!");
          } else {
            Console.WriteLine ("Gracz " + secondPlayerName + " wygrywa, gratulacje!");
            }
          }
        Console.WriteLine ("Czy chcecie zagrać jeszcze raz?\nNapiszcie TAK lub NIE");
        string decision = Console.ReadLine();
        if (decision.ToUpper() == "TAK"){
          Console.WriteLine ("Zagrajmy jeszcze raz!");
          continue;
          }else{
            game=false;
            }
          }
    Console.WriteLine ("PAPA!");
  }
}