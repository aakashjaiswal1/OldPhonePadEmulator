// See https://aka.ms/new-console-template for more information

// Console.WriteLine("Hello, World!");

using System.Collections;
using System.Text;

class Solution {
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
        Console.WriteLine(OldPhonePad("222 2 22"));

    }

    public static string  OldPhonePad(string input)
    {
        if (input == null || input.Length == 0) return ""; // Base condition
        input = input + " "; // To extract last char of the sequence ex "2 222" 
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
                        resultList.Add(phoneNoToCharacterMap[prevChar][prevConsecutiveChars - 1]);
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
                        case ' ':
                            prevChar = '~';  // If this is space we dont need to accumulate in the output 
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
                    Console.WriteLine("Error In retriving char from phone to char map " +e);
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