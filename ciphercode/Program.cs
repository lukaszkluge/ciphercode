class Program
{
    static void Main()
    {
        // Prompt the user to enter the text to be encrypted
        Console.WriteLine("Enter the text to encrypt:");
        string text = Console.ReadLine() ?? ""; // Read the user input text

        // Prompt the user to enter the Caesar cipher key (shift value)
        Console.WriteLine("Enter the key (shift value):");
        int key = int.Parse(Console.ReadLine() ?? ""); // Read the user input key

        // Call the encryption function and store the encrypted text
        string encryptedText = EncryptWithCaesarCipher(text, key);

        // Display the encrypted ASCII text
        Console.WriteLine("ASCII Encryption: " + encryptedText);
    }

    static string EncryptWithCaesarCipher(string input, int key)
    {
        // Convert the text to uppercase to simplify the encryption
        input = input.ToUpper();
        string encryptedText = "";

        // Iterate through each character in the input text
        foreach (char letter in input)
        {
            if (Char.IsLetter(letter)) // If the character is a letter
            {
                // Calculate the Unicode code of the encrypted letter
                int letterCode = ((int)letter - 65 + key) % 26 + 65;
                char encryptedLetter = (char)letterCode;

                // Add the encrypted letter to the resulting text
                encryptedText += encryptedLetter;
            }
            else // If the character is not a letter (e.g., space or punctuation)
            {
                // Preserve the character without changes
                encryptedText += letter;
            }
        }

        // Return the encrypted text
        return encryptedText;
    }
}