using System;

class MainClass {
  public static void Main (string[] args) {
    string figury = "Papier-Kamień-Nożyce";
    Console.WriteLine ("Witaj w grze "+figury);

   Console.WriteLine ("Graczu #1, jak masz na imię?");
   string firstPlayerName = Console.ReadLine();

   Console.WriteLine ("Graczu #2, jak masz na imię?");
   string secondPlayerName = Console.ReadLine();
   for(;;){
   Console.WriteLine ("Graczu " + firstPlayerName + " wybierz jedną z figur: " +figury);
   Console.WriteLine ("Aby dokonać wyboru wpisz pierwszą literę figury");
   string firstPlayerChoice = Console.ReadLine();
   Console.Clear();

   Console.WriteLine ("Graczu " + secondPlayerName + " wybierz jedną z figur: " +figury);
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
     string playOrNot1 = Console.ReadLine();
    string playOrNot2 = Console.ReadLine();
    if (playOrNot1.ToUpper() == "TAK" && playOrNot2.ToUpper() == "TAK"){
    continue;
    }else{
      break;
   }
    }
    Console.WriteLine ("PAPA!");
  }
}
