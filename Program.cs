Console.Title = "Defense of Consolas";
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("Target row? ");
int row  = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Target column? ");
int column = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Deploy to: ");
Console.WriteLine($"({row}, {column - 1})");
Console.WriteLine($"({row - 1}, {column})");
Console.WriteLine($"({row}, {column + 1})");
Console.WriteLine($"({row + 1}, {column})");
// 200xp earned yay!!