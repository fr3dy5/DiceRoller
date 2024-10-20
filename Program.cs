Random random = new Random();
int rerolls = 2;
int finalScore;
int bonus;

//make dice a switch statement? easier to use input to update rolls? start i at 1 end at 6 to simplify possible switch later?
Dice[] dice = new Dice[6];
int [] rolled = new int[6];
for (int i = 1; i < 6; i++) {
    dice[i] = new Dice();
    rolled[i] = random.Next(1, 7);
}


do {
    if (rerolls == 2) {
        Console.WriteLine("Initial Roll:");
        }
    else {
        Console.WriteLine("Updated Rolls:");
        }
    for (int i = 1; i < 6; i++) {
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

} while (rerolls != 0) {
    if ( == 2) {
        bonus = 10;
    }
    else if ( == 3) {
        bonus = 15;
    }
    else if ( == 4) {
        bonus = 25;
    }
    else if ( == 5) {
        bonus = 30;
    }
    else bonus = 0;
    //sum all rolls and count equal values and add bonus points
    finalScore = rolled.Sum() + bonus;

    Console.WriteLine("Updated Rolls:");
    Console.WriteLine($"Die 1: {rolled[0]}");
    Console.WriteLine($"Die 2: {rolled[1]}");
    Console.WriteLine($"Die 3: {rolled[2]}");
    Console.WriteLine($"Die 4: {rolled[3]}");
    Console.WriteLine($"Die 5: {rolled[4]}");
    Console.WriteLine(); 
    Console.WriteLine($"Final Score: {finalScore}");
}