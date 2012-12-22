# ToBinary
A extension methods for string to change it from English to binary. Ascii binary implemented but open for extensions of other types.

## What can it be used for?
It can be used to turn a readable page into something incomprehensible.

## Example

    using ToBinary;
	
    namespace Translate
    {
        public class Program
        {
            public static void Main(string[] args)
            {
                string binary = "String to translate.".ToBinary();
            }
        }
    }
	
binary: 
010100110111010001110010011010010110111001100111001000
000111010001101111001000000111010001110010011000010110
1110011100110110110001100001011101000110010100101110