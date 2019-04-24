using System;
using System.Collections.Generic;
using CoinCombo.Models;

public class Program
{
  public static void PrintChange(int totalCents, CoinFinder myObj)
  {
    Console.WriteLine("Your change for " +totalCents+ ":");
    foreach(KeyValuePair<string,int> kvp in myObj.GetChangeAmt())
    {
      if(kvp.Value == 0){
        continue;
      }
      Console.WriteLine("{0} : {1}.", kvp.Key, kvp.Value);
    }
  }
  public static void Main()
  {
    Console.WriteLine("Please enter then amount of cents you would like change for.");
    int MyTotalCents = int.Parse(Console.ReadLine());
    CoinFinder CoinFinderObj = new CoinFinder(MyTotalCents);
    CoinFinderObj.CalcChange();
    PrintChange(MyTotalCents, CoinFinderObj);
  }
}
