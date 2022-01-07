int curr, next, a; //YOU CAN CHANGE TO ANY OTHER VARIABLES 
Console.WriteLine("What curenncy would like to change from?"); //YOU CAN ADD MORE CURRENCIES
Console.WriteLine("-------------------------");
Console.WriteLine("1.Dollar");
Console.WriteLine("2.Shekel");
Console.WriteLine("3.Euro");
Console.WriteLine("4.Yen");
Console.WriteLine("5.Sterling");
a = int.Parse(Console.ReadLine());
Console.WriteLine("how much of that would you like to chnage?");
curr = int.Parse(Console.ReadLine());

if (a == 1)
{
    Console.WriteLine("great! what currency would you like to change to?");
    Console.WriteLine("2.Shekel");
    Console.WriteLine("3.Euro");
    Console.WriteLine("4.Yen");
    Console.WriteLine("5.Sterling");
    next = int.Parse(Console.ReadLine());

    if (next == 2)
        Console.WriteLine((curr * 3.02) + "₪");
    else if (next == 3)
        Console.WriteLine((curr * 0.89) + "€");
    else if (next == 4)
        Console.WriteLine((curr * 115.81) + "¥");
    else if (next == 5)
        Console.WriteLine((curr * 0.74) + "£");
    else
        Console.WriteLine("Invalid");
}
else if (a == 2)
{
    Console.WriteLine("great! what currency would you like to change to?");
    Console.WriteLine("1.Dollar");
    Console.WriteLine("3.Euro");
    Console.WriteLine("4.Yen");
    Console.WriteLine("5.Sterling");
    next = int.Parse(Console.ReadLine());

    if (next == 1)
        Console.WriteLine((curr * 3.02) + "$");
    else if (next == 3)
        Console.WriteLine((curr * 0.28) + "€");
    else if (next == 4)
        Console.WriteLine((curr * 37.23) + "¥");
    else if (next == 5)
        Console.WriteLine((curr * 0.24) + "£");
    else
        Console.WriteLine("Invalid");
}
else if (a == 3)
{
    Console.WriteLine("great! what currency would you like to change to?");
    Console.WriteLine("1.Dollar");
    Console.WriteLine("2.Shekel");
    Console.WriteLine("4.Yen");
    Console.WriteLine("5.Sterling");
    next = int.Parse(Console.ReadLine());

    if (next == 1)
        Console.WriteLine((curr * 1.13) + "$");
    else if (next == 2)
        Console.WriteLine((curr * 3.51) + "₪");
    else if (next == 4)
        Console.WriteLine((curr * 130.92) + "¥");
    else if (next == 5)
        Console.WriteLine((curr * 0.83) + "£");
    else
        Console.WriteLine("Invalid");
}
else if (a == 4)
{
    Console.WriteLine("great! what currency would you like to change to?");
    Console.WriteLine("1.Dollar");
    Console.WriteLine("2.Shekel");
    Console.WriteLine("3.Euro");
    Console.WriteLine("5.Sterling");
    next = int.Parse(Console.ReadLine());

    if (next == 1)
        Console.WriteLine((curr * 0.0086) + "$");
    else if (next == 2)
        Console.WriteLine((curr * 0.027) + "₪");
    else if (next == 3)
        Console.WriteLine((curr * 0.0076) + "€");
    else if (next == 5)
        Console.WriteLine((curr * 0.0064) + "£");
    else
        Console.WriteLine("Invalid");
}
else if (a == 5)
{
    Console.WriteLine("great! what currency would you like to change to?");
    Console.WriteLine("1.Dollar");
    Console.WriteLine("2.Shekel");
    Console.WriteLine("3.Euro");
    Console.WriteLine("4.Yen");
    next = int.Parse(Console.ReadLine());

    if (next == 1)
        Console.WriteLine((curr * 1.35) + "$");
    else if (next == 2)
        Console.WriteLine((curr * 4.21) + "₪");
    else if (next == 3)
        Console.WriteLine((curr * 1.20) + "€");
    else if (next == 4)
        Console.WriteLine((curr * 156.95) + "¥");
    else
        Console.WriteLine("Invalid");
}
else
    Console.WriteLine("Invalid");