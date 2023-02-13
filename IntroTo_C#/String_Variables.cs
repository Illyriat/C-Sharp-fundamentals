string customer1 = "Tim";
string customer2 = "Sophie";
string customer3 = "Fred";

int customer1Amount = 150;
int customer2Amount = 15365;
int customer3Amount = 2654;

Console.WriteLine($"Our first customer {customer1} has £{customer1Amount} in his account!");
Console.WriteLine($"Our first customer {customer2} has £{customer2Amount} in her account!");
Console.WriteLine($"Our first customer {customer3} has £{customer3Amount} in his account!");

Console.WriteLine("");

int jointAccount1 = customer1Amount + customer2Amount;

Console.WriteLine($"{customer1} and {customer2} are getting married and would like to open and joint account and transfer all funds from their current accounts into their new joint account. The new total is {jointAccount1}.");

Console.WriteLine("");

int accountFee = 0.025;

Console.WriteLine($"{customer1} and {customer2} have to pay account fee of 2.5%. Their new amount is {jointAccount1 - (jointAccount1 * accountFee)}");