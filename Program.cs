using System.Text;

Console.Write("Enter the Base64 encoded string: ");
var base64String = Console.ReadLine();

try
{
    if (!string.IsNullOrWhiteSpace(base64String))
    {
        var data = Convert.FromBase64String(base64String);
        var decodedString = Encoding.UTF8.GetString(data);
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