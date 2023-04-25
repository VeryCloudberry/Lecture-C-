Console.Write("Write your name: ");
string username = Console.ReadLine();

if(username.ToLower() == "maxim")
{
    Console.WriteLine("Waw, it's Maxim!");
}
else
{
    Console.Write("Hello, ");
    Console.WriteLine(username);
}
