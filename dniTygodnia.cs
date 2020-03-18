using System;

class MainClass {
  public static void Main (string[] args) {
    }
  
  String[] weekDays = {"Monday", "Tuesday", "Wednesday", "Thuesday", "Friday", "Saturday","Sunday"}; 
  int whileLoopIterator = 0;
  Console.WriteLine("While loop");
  while(whileLoopIterator < weekDays.Length){
    Console.WriteLine(whileLoopIterator + " dniem tygodnia jest " + weekDays[whileLoopIterator]);
    whileLoopIterator++;
  }

  Console.WriteLine("====================");
  Console.WriteLine("using for loop\n");
  int forLoopIterator;
  for (forLoopIterator=0; forLoopIterator<weekDays.Length; forLoopIterator++){
    Console.WriteLine(forLoopIterator+1 + " dniem tygodnia jest " + weekDays[forLoopIterator]);
  }
}