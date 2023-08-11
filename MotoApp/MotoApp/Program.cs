using MotoApp;

var stack = new BasicStack<double>();

stack.Push(4.5);
stack.Push(12.5);
stack.Push(156.12);

var stackString = new BasicStack<string>();
stackString.Push("Company1");
stackString.Push("Company2");
stackString.Push("Company3");

double sum = 0.0;


while (stack.Count >0)
{
    double item = stack.Pop();
    Console.WriteLine($"Item: {item}");
    sum += item;    
}

Console.WriteLine($"");

while (stackString.Count >0)
{
    string itemString = stackString.Pop();
    Console.WriteLine($"String: {itemString}"); 
}

Console.WriteLine($"Sum: {sum}");
Console.ReadLine();