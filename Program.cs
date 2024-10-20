﻿Random random = new Random();
int rerolls = 2;
int finalScore = 0;
int bonus = 0;
int sameRolls;

//make dice a switch statement? easier to use input to update rolls? start i at 1 end at 6 to simplify possible switch later?
Dice[] dice = new Dice[5];
int [] rolled = new int[5];
for (int i = 0; i < 5; i++) {
    dice[i] = new Dice();
    rolled[i] = random.Next(1, 7);
}


do {

    Console.Clear();

    if (rerolls == 2) {
        Console.WriteLine("Initial Roll:");
        }
    else {
        Console.WriteLine("Updated Rolls:");
        }
    for (int i = 0; i < 5; i++) {
        rolled[i] = dice[i].RollNumber();    
        Console.WriteLine($"Die {dice[i]}: {rolled[i]}");
    // Console.WriteLine($"Die 2: {rolled[1]}");
    // Console.WriteLine($"Die 3: {rolled[2]}");
    // Console.WriteLine($"Die 4: {rolled[3]}");
    // Console.WriteLine($"Die 5: {rolled[4]}");
    }
    Console.WriteLine();
    


    Console.WriteLine("Enter the dice numbers to reroll (comma-separated, ex: 2,3,5) or leave blank to keep current dice.");
    Console.Write($"You have {rerolls} rerolls remaining): ");
    Console.ReadLine();

    //read input, if its not null or whitespace continue, no validation messages/actions 
    string input = Console.ReadLine();
    if (!string.IsNullOrWhiteSpace(input)) {
        //method chaining, from language integrated query operations
        //new array for dice to reroll, take input and split at (,) , then trim whitespace, parse into int's, and put into array 
        int [] rerollDice = input.Split(',')
                                 .Select(s => int.Parse(s.Trim()))
                                 .ToArray();   
        foreach (int die in rerollDice) {
            switch (die) {
                case 1:
                dice[0] = random.Next(1, 7);
                break;
                case 2:
                dice[1] = random.Next(1, 7);
                break;
                case 3:
                dice[2] = random.Next(1, 7);
                break;
                case 4:
                dice[3] = random.Next(1, 7);
                break;
                case 5:
                dice[4] = random.Next(1, 7);
                break;
            }
        } 
    }
} while (rerolls != 0); { 

    //group arrays values, find max amount of grouped values (what if theres more than one group??)
    sameRolls = rolled.GroupBy(x => x)
                      .Max(g => g.Count());  

    if (sameRolls == 2) {
        bonus = 10;
    }
    else if (sameRolls == 3) {
        bonus = 15;
    }
    else if (sameRolls == 4) {
        bonus = 25;
    }
    else if (sameRolls == 5) {
        bonus = 30;
    }
    else bonus = 0;

    //sum all rolls and count equal values and add bonus points
    finalScore = rolled.Sum() + bonus;

    Console.Clear();

    Console.WriteLine("Updated Rolls:");
    Console.WriteLine($"Die 1: {rolled[0]}");
    Console.WriteLine($"Die 2: {rolled[1]}");
    Console.WriteLine($"Die 3: {rolled[2]}");
    Console.WriteLine($"Die 4: {rolled[3]}");
    Console.WriteLine($"Die 5: {rolled[4]}");
    Console.WriteLine(); 
    Console.WriteLine($"Final Score: {finalScore}");
}