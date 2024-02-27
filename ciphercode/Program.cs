class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the text to encrypt:");
        string text = Console.ReadLine() ?? ""; 

        Console.WriteLine("Enter the key (shift value):");
        int key = int.Parse(Console.ReadLine() ?? "");

        // Call the encryption function and store the encrypted text
        string encryptedText = EncryptWithCaesarCipher(text, key);

        Console.WriteLine("ASCII Encryption: " + encryptedText);
    }

    static string EncryptWithCaesarCipher(string input, int key)
    {
        // Convert the text to uppercase
        input = input.ToUpper();
        string encryptedText = "";

        foreach (char letter in input)
        {
            if (Char.IsLetter(letter)) 
            {
                // Calculate the Unicode code of the encrypted letter
                int letterCode = ((int)letter - 65 + key) % 26 + 65;
                char encryptedLetter = (char)letterCode;

                // Add the encrypted letter to the resulting text
                encryptedText += encryptedLetter;
            }
            else 
            {
                // Preserve the character without changes
                encryptedText += letter;
            }
        }

        return encryptedText;
    }
}