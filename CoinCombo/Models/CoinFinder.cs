using System;
using System.Collections.Generic;

namespace CoinCombo.Models
{
  public class CoinFinder
  {
    private readonly int[] ChangeOrder = new int[]{25, 10, 5, 1};
    private Dictionary<string,int> ChangeAmt = new Dictionary<string, int>{{"Quarter", 0}, {"Dime", 0}, {"Nickel", 0}, {"Penny", 0}};
    private int UserCents = 0;
    public CoinFinder(int userCents)
    {
      UserCents = userCents;
    }
    public int GetUserCents()
    {
      return UserCents;
    }
    public Dictionary<string,int> GetChangeAmt()
    {
      return ChangeAmt;
    }
    public void CalcChange()
    {
      int tempCalc = UserCents;
      for(int i = 0; i < ChangeOrder.Length;i++){
        if(tempCalc == 0){
          break;
        }
        while(tempCalc - ChangeOrder[i] >= 0)
        {
          tempCalc -= ChangeOrder[i];
          switch(ChangeOrder[i]){
            case 25:
              ChangeAmt["Quarter"] += 1;
              break;
            case 10:
              ChangeAmt["Dime"] += 1;
              break;
            case 5:
              ChangeAmt["Nickel"] += 1;
              break;
            case 1:
              ChangeAmt["Penny"] += 1;
              break;
          }
        }
      }
    }
  }
}
