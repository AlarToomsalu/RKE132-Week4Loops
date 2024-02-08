

Random rnd = new Random();
int cpuRandom;
bool loopActive = true; //bool- ture/flase

while(loopActive)
{
    cpuRandom = rnd.Next(1, 4);
   // Console.WriteLine($"Cpu has generated {cpuRandom}");
    Console.WriteLine("Make a guess. Enter number 1-3");
    int userNumber= Int32.Parse(Console.ReadLine());

    if(userNumber == cpuRandom )
    {
        
        Console.WriteLine("Congratulations, you won!");
        //loopActive = false;
        break;
    }
    else
    {
        Console.WriteLine("ooops. Try again.");
    }
    Console.WriteLine("Have a nice day");
}











