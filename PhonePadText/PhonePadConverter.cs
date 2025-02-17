// See https://aka.ms/new-console-template for more information

// Console.WriteLine("Hello, World!");

using System.Collections;
using System.Text;
using static System.Console;

class PhonePadConvertorSolution {
    private static Dictionary<char, List<char>> phoneNoToCharacterMap = new()
    {
        { '1', ['&', '\'', '('] },
        { '2', ['A', 'B', 'C'] },
        { '3', ['D', 'E', 'F'] },
        { '4', ['G', 'H', 'I'] },
        { '5', ['J', 'K', 'L'] },
        { '6', ['M', 'N', 'O'] },
        { '7', ['P', 'Q', 'R', 'S'] },
        { '8', ['T', 'U', 'V'] },
        { '9', ['W', 'X' , 'Y' , 'Z'] },
        { '0' , ['_']}
    };
    static void Main(String[] args)
    { 
        WriteLine(OldPhonePad("222"));

    }

    public static string  OldPhonePad(string input)
    {
        if (input == null || input.Length == 0) return ""; // Base condition
        input += " "; // To extract last char of the sequence ex "2 222" 
        List<char> resultList = [];
        char prevChar = '~'; // This will keep a track of prev chars being used and if a new char is changed in the stream
        int prevConsecutiveChars = 0; // Length of consecutive chars
        foreach(char c in  input)
        {
            if (c == prevChar)
            {
                prevConsecutiveChars += 1;
            }
            else
            {
                // Extract the prev char
                try
                {
                    if (prevChar != '~')
                    {
                        // I am doing % (mod) here , although not mentioned in problem statement
                        // I think it's nice to have eg 2222 will yield A , 22222 will yield B and so on ..
                        int prevConsecutiveCharMod = (prevConsecutiveChars - 1) % phoneNoToCharacterMap[prevChar].Count + 1;
                        resultList.Add(phoneNoToCharacterMap[prevChar][prevConsecutiveCharMod - 1]);
                    }

                    switch (c)
                    {
                        case '*':
                        {
                            if (resultList.Count > 0)
                            {
                                resultList.RemoveAt(resultList.Count - 1);
                            }

                            prevChar = '~'; // we dont need to append * in the output 
                            prevConsecutiveChars = 0;
                            break;
                        }
                        case ' ' or '#' :
                            prevChar = '~';  // If this is space or hash we dont need to accumulate in the output 
                            prevConsecutiveChars = 0;
                            break;
                        default:
                            prevChar = c;
                            prevConsecutiveChars = 1;
                            break;
                    }
                }
                catch (Exception e)
                {
                    WriteLine("Error In retrieving char from phone to char map " +e);
                    throw;
                }
                
            }   
            
        }
        StringBuilder sb = new StringBuilder();
        foreach (char c in resultList)
        {
            sb.Append(c);
        }

        return sb.ToString();
    }
    
    
}