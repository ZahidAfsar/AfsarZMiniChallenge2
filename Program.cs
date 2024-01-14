// Zahid Afsar
// 9/7/23
// Mini Challenge 2
// The console asks for two numbers and then adds them together
//Peer reviewed by Raudel Alvarado        Peer review comment : Everything runs good


Console.WriteLine("What do you want to add?");
Console.WriteLine("Enter first number ");


int firstNum = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Your first number is {firstNum}");


Console.WriteLine("What is your second number?");


int secondNum = Convert.ToInt32(Console.ReadLine());


Console.WriteLine($"Your second number is {secondNum}");


int total = firstNum + secondNum;

Console.WriteLine($"{firstNum} + {secondNum} = {total}");
