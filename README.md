# ToPseudoLocale
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
	
binary: 0101001101110100011100100110100101101110011001110010000001110100011011110010000001110100011100100110000101101110011100110110110001100001011101000110010100101110