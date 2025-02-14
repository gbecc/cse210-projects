using System;

class UserInterface
{
public void DisplayMessage(string message)
{
    Console.WriteLine(message);
}
public string GetUserInput()
{
    return Console.ReadLine();
}
public void ClearScreen()
{
   Console.WriteLine("------------------------------"); //Would've used console.clear() but it didn't work.
}
}