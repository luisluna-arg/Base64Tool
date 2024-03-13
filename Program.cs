using System.Text;

Func<string, string> decipher = (base64String) => Encoding.UTF8.GetString(Convert.FromBase64String(base64String));

if (args.Length >= 1 && args.Contains("-d") && !string.IsNullOrWhiteSpace(args[1]))
{
    Console.WriteLine();
    Console.WriteLine("Decoded string\n===============");
    Console.WriteLine(decipher(args[1]));
}
else
{
    try
    {
        Console.Write("Enter the Base64 encoded string: ");
        var base64String = Console.ReadLine();

        if (!string.IsNullOrWhiteSpace(base64String))
        {
            var decodedString = decipher(base64String);
            Console.WriteLine();
            Console.WriteLine("Decoded string\n===============");
            Console.WriteLine(decodedString);
            Console.WriteLine();
            Console.Write("Press any key to close");
            Console.ReadKey();
        }
        else
        {
            Console.WriteLine("Cannot decipher null string");
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine("Error: " + ex.Message);
    }
}
