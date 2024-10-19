//make dice a switch statement? easier to use input to update rolls?
int Array dice[4];
int Array rolled[];
int rerolls = 2;
int finalScore = 0;

do {
    for (int i = 1; i < 6; i++) {
        for (dice[i];  )
    }
    if (rerolls == 2) {
        Console.WriteLine("Initial Roll:");
        }
    else {
        Console.WriteLine("Updated Rolls:");
    }
    Console.WriteLine($"Die 1: {rolled[0]}");
    Console.WriteLine($"Die 2: {rolled[1]}");
    Console.WriteLine($"Die 3: {rolled[2]}");
    Console.WriteLine($"Die 4: {rolled[3]}");
    Console.WriteLine($"Die 5: {rolled{4}}");
    Console.WriteLine();



    Console.WriteLine("Enter the dice numbers to reroll (comma-separated, ex: 2,3,5) or leave blank to keep current dice.");
    Console.Write($"You have {rerolls} rerolls remaining): ");
    Console.ReadLine();

} while (rerolls != 0) {
    //sum all rolls and count equal values and add bonus points
    finalScore = ;

    Console.WriteLine("Updated Rolls:");
    Console.WriteLine($"Die 1: {rolled[0]}");
    Console.WriteLine($"Die 2: {rolled[1]}");
    Console.WriteLine($"Die 3: {rolled[2]}");
    Console.WriteLine($"Die 4: {rolled[3]}");
    Console.WriteLine($"Die 5: {rolled{4}}");
    Console.WriteLine();
    Console.WriteLine($"Final Score: {finalScore}");
}