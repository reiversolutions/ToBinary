using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ToBinary
{
    public static class Ascii
    {
        public static string ToAscii(this string text, bool fullTranslate)
        {
            string translation = "";
            foreach (char letter in text)
            {
                translation += letter.ToAscii(fullTranslate);
            }
            return translation;
        }

        public static string ToAscii(this char letter, bool fullTranslate)
        {
            string character = letter.ToString();

            switch (letter)
            {
                case ' ':
                    if (fullTranslate)
                    {
                        character = "00100000";
                    }
                    break;
                case '!':
                    if (fullTranslate)
                    {
                        character = "00100001";
                    }
                    break;
                case '"':
                    if (fullTranslate)
                    {
                        character = "00100010";
                    }
                    break;
                case '#':
                    if (fullTranslate)
                    {
                        character = "00100011";
                    }
                    break;
                case '$':
                    if (fullTranslate)
                    {
                        character = "00100100";
                    }
                    break;
                case '%':
                    if (fullTranslate)
                    {
                        character = "00100101";
                    }
                    break;
                case '&':
                    if (fullTranslate)
                    {
                        character = "00100110";
                    }
                    break;
                case '\'':
                    if (fullTranslate)
                    {
                        character = "00100111";
                    }
                    break;
                case '(':
                    if (fullTranslate)
                    {
                        character = "00101000";
                    }
                    break;
                case ')':
                    if (fullTranslate)
                    {
                        character = "00101001";
                    }
                    break;
                case '*':
                    if (fullTranslate)
                    {
                        character = "00101010";
                    }
                    break;
                case '+':
                    if (fullTranslate)
                    {
                        character = "00101011";
                    }
                    break;
                case ',':
                    if (fullTranslate)
                    {
                        character = "00101100";
                    }
                    break;
                case '-':
                    if (fullTranslate)
                    {
                        character = "00101101";
                    }
                    break;
                case '.':
                    if (fullTranslate)
                    {
                        character = "00101110";
                    }
                    break;
                case '/':
                    if (fullTranslate)
                    {
                        character = "00101111";
                    }
                    break;
                case '0':
                    character = "00110000";
                    break;
                case '1':
                    character = "00110001";
                    break;
                case '2':
                    character = "00110010";
                    break;
                case '3':
                    character = "00110011";
                    break;
                case '4':
                    character = "00110100";
                    break;
                case '5':
                    character = "00110101";
                    break;
                case '6':
                    character = "00110110";
                    break;
                case '7':
                    character = "00110111";
                    break;
                case '8':
                    character = "00111000";
                    break;
                case '9':
                    character = "00111001";
                    break;
                case ':':
                    if (fullTranslate)
                    {
                        character = "00111010";
                    }
                    break;
                case ';':
                    if (fullTranslate)
                    {
                        character = "00111011";
                    }
                    break;
                case '<':
                    if (fullTranslate)
                    {
                        character = "00111100";
                    }
                    break;
                case '=':
                    if (fullTranslate)
                    {
                        character = "00111101";
                    }
                    break;
                case '>':
                    if (fullTranslate)
                    {
                        character = "00111110";
                    }
                    break;
                case '?':
                    if (fullTranslate)
                    {
                        character = "00111111";
                    }
                    break;
                case '@':
                    if (fullTranslate)
                    {
                        character = "01000000";
                    }
                    break;
                case '[':
                    if (fullTranslate)
                    {
                        character = "01011011";
                    }
                    break;
                case '\\':
                    if (fullTranslate)
                    {
                        character = "01011100";
                    }
                    break;
                case ']':
                    if (fullTranslate)
                    {
                        character = "01011101";
                    }
                    break;
                case '^':
                    if (fullTranslate)
                    {
                        character = "01011110";
                    }
                    break;
                case '_':
                    if (fullTranslate)
                    {
                        character = "01011111";
                    }
                    break;
                case '`':
                    if (fullTranslate)
                    {
                        character = "01100000";
                    }
                    break;
                case '{':
                    if (fullTranslate)
                    {
                        character = "01111011";
                    }
                    break;
                case '|':
                    if (fullTranslate)
                    {
                        character = "01111100";
                    }
                    break;
                case '}':
                    if (fullTranslate)
                    {
                        character = "01111101";
                    }
                    break;
                case '~':
                    if (fullTranslate)
                    {
                        character = "01111110";
                    }
                    break;
                case 'a':
                    character = "01100001";
                    break;               
                case 'A':                
                    character = "01000001";
                    break;      
                case 'b':       
                    character = "01100010";
                    break;      
                case 'B':       
                    character = "01000010";
                    break;      
                case 'c':       
                    character = "01100011";
                    break;      
                case 'C':       
                    character = "01000011";
                    break;      
                case 'd':       
                    character = "01100100";
                    break;      
                case 'D':       
                    character = "01000100";
                    break;      
                case 'e':       
                    character = "01100101";
                    break;      
                case 'E':       
                    character = "01000101";
                    break;      
                case 'f':       
                    character = "01100110";
                    break;     
                case 'F':      
                    character = "01000110";
                    break;     
                case 'g':      
                    character = "01100111";
                    break;     
                case 'G':      
                    character = "01000111";
                    break;     
                case 'h':      
                    character = "01101000";
                    break;     
                case 'H':      
                    character = "01001000";
                    break;     
                case 'i':      
                    character = "01101001";
                    break;     
                case 'I':      
                    character = "01001001";
                    break;    
                case 'j':     
                    character = "01101010";
                    break;     
                case 'J':      
                    character = "01001010";
                    break;    
                case 'k':     
                    character = "01101011";
                    break;    
                case 'K':     
                    character = "01001011";
                    break;    
                case 'l':     
                    character = "01101100";
                    break;    
                case 'L':     
                    character = "01001100";
                    break;   
                case 'm':    
                    character = "01101101";
                    break;    
                case 'M':     
                    character = "01001101";
                    break;    
                case 'n':     
                    character = "01101110";
                    break;   
                case 'N':    
                    character = "01001110";
                    break;    
                case 'o':     
                    character = "01101111";
                    break;    
                case 'O':     
                    character = "01001111";
                    break;    
                case 'p':     
                    character = "01110000";
                    break;    
                case 'P':     
                    character = "01010000";
                    break;   
                case 'q':    
                    character = "01110001";
                    break;   
                case 'Q':    
                    character = "01010001";
                    break;   
                case 'r':    
                    character = "01110010";
                    break;   
                case 'R':    
                    character = "01010010";
                    break;    
                case 's':     
                    character = "01110011";
                    break;   
                case 'S':    
                    character = "01010011";
                    break;    
                case 't':     
                    character = "01110100";
                    break;   
                case 'T':    
                    character = "01010100";
                    break;   
                case 'u':    
                    character = "01110101";
                    break;    
                case 'U':     
                    character = "01010101";
                    break;   
                case 'v':    
                    character = "01110110";
                    break;    
                case 'V':     
                    character = "01010110";
                    break;    
                case 'w':     
                    character = "01110111";
                    break;   
                case 'W':    
                    character = "01010111";
                    break;    
                case 'x':     
                    character = "01111000";
                    break;    
                case 'X':     
                    character = "01011000";
                    break;   
                case 'y':    
                    character = "01111001";
                    break;   
                case 'Y':    
                    character = "01011001";
                    break;   
                case 'z':    
                    character = "01111010";
                    break;   
                case 'Z':    
                    character = "01011010";
                    break;
            }

            return character;
        }
    }
}
