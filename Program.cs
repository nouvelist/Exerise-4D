int user1;
Console.WriteLine("Enter your first number: ");
user1 = Convert.ToInt32(Console.ReadLine());

int user2;
Console.WriteLine("Enter your second number: ");
user2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Your first number is: {user1}");
Console.WriteLine($"Your second number is: {user2}");
int addition;
addition = user1 + user2;
Console.WriteLine($"{user1} + {user2} = {addition}");

int subtract;
subtract = user1 - user2;
Console.WriteLine($"{user1} - {user2} = {subtract}");

int product;
product = user1 * user2;
Console.WriteLine($"{user1} * {user2} = {product}");

int module;
module = user1 % user2;
Console.WriteLine($"{user1} % {user2} = {module}");