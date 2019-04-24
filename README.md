# CoinCombo.Solution
## Ian Christner


### Description:
A simple .NET console application where a user is prompted for an amount of cents and then they are returned the appropriate amount of change.


What it does:
* User enters a number of cents
* Program uses that number to generate a CoinFinder Object
* The CalcChange() method is now called on the Generated Object, which populates a Dictionary with the appropriate amount of Quarters, Dimes, Nickels, and Pennies.
* Main the calls the PrintChange() helper function, which prints out the change amounts to the user in the Console.

Included Specifications:
* User enters a value that is the converted into an int
* The program then calculates change by prioritizing larger change first. The priority looks like this:
  1. Quarters - 25 cents
  2. Dimes - 10 cents
  3. Nickels - 5 cents
  4. Pennies - 1 cent
* When the change pool can no longer take out a Coin amount, It starts trying to take out the next smallest coin amount.
  * For example, let us say the user input a total of 35 cents. At first, the program would take out a quarter (or 25 cents), and the remaining pool would become 10. The program cannot take out another quarter, as it would lead to negative change, so it moves down the priority to Dimes (10 cents). The program CAN take out a dime, so the pool becomes zero.
  * When the remaining pool becomes zero, it means the program has calculated exact change.
* Once the change is properly calculated, the different amounts of coins that would be given back to the user are displayed.
#### The MIT License

#### Copyright (c) 2019 Ian Christner

Permission is hereby granted, free of charge,
to any person obtaining a copy of this software and
associated documentation files (the "Software"), to
deal in the Software without restriction, including
without limitation the rights to use, copy, modify,
merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom
the Software is furnished to do so,
subject to the following conditions:

The above copyright notice and this permission notice
shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT.
IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR
ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT,
TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE
SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
