using System;

Console.WriteLine("Welcome to Sherlenthia's Sandwhich Shop!");
string username = GetUsername();
int numberOfSandwhiches = 0;
int numberOfToppings = 0;
double tip = 0;
// int TotalSandwhichCost;
// double TotalToppingsCost;
// double baseCost;
// double TotalSandwhichCost = COST_OF_SANDWHICH * numberOfSandwhiches;

const double COST_OF_SANDWHICH = 4.75;
const double COST_OF_TOPPING = 0.55;
const double DISCOUNT_AMOUNT = 0.10;


static string GetUsername(){
Console.WriteLine("What is your name?");
// Take in info from console
return Console.ReadLine();

}

Console.WriteLine("Hello " + username);
Console.WriteLine("How many sandwhiches?");
numberOfSandwhiches = int.Parse(Console.ReadLine());

Console.WriteLine("The number of sancwhiches you selected is " + numberOfSandwhiches);

Console.WriteLine("How many toppings would you like?");
numberOfToppings = int.Parse(Console.ReadLine());
Console.WriteLine("So you would like " + numberOfSandwhiches + " with " + numberOfToppings + " toppings.");
Console.WriteLine("How much would you like to add as a tip? Enter in numerical format.");
tip = double.Parse(Console.ReadLine());
Console.WriteLine("So your total tip amount is " + tip);
double TotalSandwhichCost = COST_OF_SANDWHICH * numberOfSandwhiches;
double TotalToppingsCost = COST_OF_TOPPING * numberOfToppings;
double baseCost = TotalSandwhichCost * TotalToppingsCost;

double OrderCost = tip + baseCost * (1-DISCOUNT_AMOUNT);

Console.WriteLine("Your total is " + OrderCost.ToString("F2"));
Console.WriteLine("Thank you! Goodbye " + username);

