//Escreva um programa que encripta um texto utilizando uma tabela de mapeamento de caracteres, por exemplo:

//a = K, n = J, d = A, r = T, e = L

class Program
{
    static Dictionary<char, char> table = new Dictionary<char, char>()
        {
            {'a', 'K'}, {'b', 'M'}, {'c', 'P'}, {'d', 'A'}, {'e', 'L'}, {'f', 'Q'}, {'g', 'U'}, {'h', 'N'}, {'i', 'V'},
            {'j', 'F'}, {'k', 'U'}, {'l', 'X'}, {'m', 'G'}, {'n', 'J'}, {'o', 'Y'}, {'p', 'R'}, {'q', 'Z'}, {'r', 'T'},
            {'s', 'B'}, {'t', 'C'}, {'u', 'H'}, {'v', 'S'}, {'w', 'D'}, {'x', 'I'}, {'y', 'O'}, {'z', 'E'}
        };

    static void Main(string[] args)
    {
        Console.Write("Digite um texto para criptografar: ");
        string criptografar = Console.ReadLine();

        string encryptedText = Encrypt(criptografar);
        Console.WriteLine(encryptedText);
        Console.ReadKey();
    }

    static string Encrypt(string text)
    {
        string encryptedText = "";
        foreach (char c in text)
        {
            if (table.ContainsKey(c))
            {
                encryptedText += table[c];
            }
            else
            {
                encryptedText += c;
            }
        }
        return encryptedText;
    }
}