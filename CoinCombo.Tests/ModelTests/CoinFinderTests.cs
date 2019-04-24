using Microsoft.VisualStudio.TestTools.UnitTesting;
using CoinCombo.Models;
using System;
using System.Collections.Generic;

namespace CoinCombo.Tests
{
  [TestClass]
  public class CoinFinderTest
  {
    [TestMethod]
    public void Constructor_Test()
    {
      int UserCents = 100;
      CoinFinder coinTest = new CoinFinder(UserCents);
      Assert.AreEqual(UserCents, coinTest.GetUserCents());
    }
    [TestMethod]
    public void CalcChange_TestLow()
    {
      CoinFinder coinTest = new CoinFinder(7);
      coinTest.CalcChange();
      Dictionary<string,int> testDict = new Dictionary<string, int>{{"Quarter", 0}, {"Dime", 0}, {"Nickel", 1}, {"Penny", 2}};
      CollectionAssert.AreEqual(testDict, coinTest.GetChangeAmt());
    }
    [TestMethod]
    public void CalcChange_TestMid()
    {
      CoinFinder coinTest = new CoinFinder(17);
      coinTest.CalcChange();
      Dictionary<string,int> testDict = new Dictionary<string, int>{{"Quarter", 0}, {"Dime", 1}, {"Nickel", 1}, {"Penny", 2}};
      CollectionAssert.AreEqual(testDict, coinTest.GetChangeAmt());
    }
    [TestMethod]
    public void CalcChange_TestHigh()
    {
      CoinFinder coinTest = new CoinFinder(117);
      coinTest.CalcChange();
      Dictionary<string,int> testDict = new Dictionary<string, int>{{"Quarter", 4}, {"Dime", 1}, {"Nickel", 1}, {"Penny", 2}};
      CollectionAssert.AreEqual(testDict, coinTest.GetChangeAmt());
    }
    [TestMethod]
    public void CalcChange_TestOneForAll()
    {
      CoinFinder coinTest = new CoinFinder(41);
      coinTest.CalcChange();
      Dictionary<string,int> testDict = new Dictionary<string, int>{{"Quarter", 1}, {"Dime", 1}, {"Nickel", 1}, {"Penny", 1}};
      CollectionAssert.AreEqual(testDict, coinTest.GetChangeAmt());
    }
  }
}
