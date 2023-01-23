// See https://aka.ms/new-console-template for more information
//Console.WriteLine("enter your dob in (dd/mm/yyyy");
double[] fare = new double[5];
for (int i = 1;i < 5; i++)
{
    if( i % 2 == 0)
    {
        Console.WriteLine("enter at even pos");
        fare[i] = Convert.ToDouble(Console.ReadLine());
    }
    else
    {
        Console.WriteLine("enter at odd pos");
        fare[i] = Convert.ToDouble(Console.ReadLine());
    }
}
foreach (int item in fare)
    Console.WriteLine(item);
