using C__Learning;

var type = typeof(ILearnInterface);
var types = AppDomain.CurrentDomain.GetAssemblies()
    .SelectMany(s => s.GetTypes())
    .Where(p => type.IsAssignableFrom(p) && !p.IsInterface);

for (int i = 0; i < types.Count(); i++)
{
    Console.WriteLine($"{i} => {types.ElementAt(i).Name}");
}

Console.WriteLine("Enter topic # to start");

//var result = Console.ReadKey().KeyChar;
var result = Console.ReadLine();
Console.WriteLine("\nProcessing Input....");

//if (!char.IsDigit(result))

    if (!int.TryParse(result,out int num))
{
    Console.WriteLine("That is not a number key! Exiting...");
    return;
}

//var topic = Convert.ToInt32(result - '0');

var topic = Convert.ToInt32(result);

if (topic > types.Count() - 1)
{
    Console.WriteLine("Invalid Number ! Exiting...");
    return;
}

Console.WriteLine($"\n\nTopic {types.ElementAt(topic).Name} has been selected..\nExecuting now...\n\n");

ILearnInterface instance = Activator.CreateInstance(types.ElementAt(topic)) as ILearnInterface;
instance.Run();
