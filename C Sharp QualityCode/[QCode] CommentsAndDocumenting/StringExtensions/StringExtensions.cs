namespace StringExtensions
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;
    using System.Security.Cryptography;
    using System.Text;
    using System.Text.RegularExpressions;

    /// <summary>
    /// Contains string extension methods for <seealso cref="System.String"/>
    /// </summary>
    public static class StringExtensions
    {
        /// <summary>
        /// Returns the given <paramref name="input"/> as <seealso cref="System.String"/> in 128bit hash value format.
        /// </summary>
        /// <param name="input">The given instance of string, that should be crypted.</param>
        /// <returns>128bit hash value as <seealso cref="System.String"/>.</returns>
        /// <example>
        /// <code>
        /// class TestExtensions
        /// {
        ///     static void Main()
        ///     {
        ///         Console.WriteLine("Return string to MD5Hash".ToString().ToMD5Hash());
        ///     }
        /// }   
        /// </code>
        /// </example>
        public static string ToMd5Hash(this string input)
        {
            var md5Hash = MD5.Create();

            // Convert the input string to a byte array and compute the hash.
            var data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

            // Create a new StringBuilder to collect the bytes
            // and create a string.
            var builder = new StringBuilder();

            // Loop through each byte of the hashed data 
            // and format each one as a hexadecimal string.
            for (int i = 0; i < data.Length; i++)
            {
                builder.Append(data[i].ToString("x2"));
            }

            // Return the hexadecimal string.
            return builder.ToString();
        }

        /// <summary>
        /// Processing a given string, returns true if the given string contain a boolean value within. 
        /// See reference <seealso cref="System.Boolean"/>
        /// </summary>
        /// <param name="input">The given string, that will be checked.</param>
        /// <returns>True if contains a boolean value, false if otherwise.</returns>
        /// <example>
        /// A simple example of the method logic.
        /// <code>
        /// class TestExtensions
        /// {
        ///     static void Main()
        ///     {
        ///         Console.WriteLine("1".ToBoolean());
        ///         //ouput : True
        ///     }
        /// }         
        /// </code>
        /// </example>
        public static bool ToBoolean(this string input)
        {
            var stringTrueValues = new[] { "true", "ok", "yes", "1", "да" };
            return stringTrueValues.Contains(input.ToLower());
        }

        /// <summary>
        /// Returns a given <seealso cref="System.String"/> value in <seealso cref="System.Int16"/> format.
        /// </summary> 
        /// <param name="input">The given string, that should be tried to be parsed to short number.</param>
        /// <returns>Returns the number if successful, otherwise return zero(0).</returns>
        /// <example>
        /// A simple example of the method logic.
        /// <code>
        /// class TestExtensions
        /// {
        ///     static void Main()
        ///     {
        ///         Console.WriteLine("1".ToShort());
        ///         //ouput : 1
        ///     }
        /// }        
        /// </code>
        /// </example>
        public static short ToShort(this string input)
        {
            short shortValue;
            short.TryParse(input, out shortValue);
            return shortValue;
        }

        /// <summary>
        /// Processing a given string, trying to parse it to integer number.
        /// <seealso cref="System.Int32"/>
        /// </summary> 
        /// <param name="input">The given string, that should be tried to be parsed to an integer number.</param>
        /// <returns>Returns the number if successful, otherwise return zero(0).</returns>
        /// <example>
        /// A simple example of the method logic.
        /// <code>
        /// class TestExtensions
        /// {
        ///     static void Main()
        ///     {
        ///         Console.WriteLine("1".ToInteger());
        ///         //ouput : 1
        ///     }
        /// }         
        /// </code>
        /// </example>
        public static int ToInteger(this string input)
        {
            int integerValue;
            int.TryParse(input, out integerValue);
            return integerValue;
        }

        /// <summary>
        /// Processing a given string, trying to parse it to a long number.
        /// <seealso cref="System.Int64"/>
        /// </summary> 
        /// <param name="input">The given string, that should be tried to be parsed to a long number.</param>
        /// <returns>Returns the number if successful, otherwise return zero(0).</returns>
        /// <example>
        /// A simple example of the method logic.
        /// <code>
        /// class TestExtensions
        /// {
        ///     static void Main()
        ///     {
        ///         Console.WriteLine("1".ToLong());
        ///         //ouput : 1
        ///     }
        /// }         
        /// </code>
        /// </example>
        public static long ToLong(this string input)
        {
            long longValue;
            long.TryParse(input, out longValue);
            return longValue;
        }

        /// <summary>
        /// Processing a given string, trying to parse it to valid DateTime value.
        /// <seealso cref="System.DateTime"/>
        /// </summary>
        /// <param name="input">The given string, that should be processed to DateTime type value.</param>
        /// <returns>Returns DateTime value if the input can be parsed correctly, otherwise return the default DateTime value.</returns>
        /// <example>
        /// A simple example of the method logic.
        /// <code>
        /// class TestExtensions 
        /// {
        ///     static void Main()
        ///     {
        ///         Console.WriteLine("non-parseble value".ToDateTime());
        ///         //output : 1/1/0001 12:00:00 AM
        ///     }
        /// }   
        /// </code>
        /// </example>
        public static DateTime ToDateTime(this string input)
        {
            DateTime dateTimeValue;
            DateTime.TryParse(input, out dateTimeValue);
            return dateTimeValue;
        }

        /// <summary>
        /// Capitalize the first letter of a given string.
        /// </summary>
        /// <param name="input">String value</param>
        /// <returns>Return null value if the string is empty or null, otherwise return the given string with capitalized first letter.</returns>
        /// <example>
        /// A simple example of the method logic.
        /// <code>
        /// class TestExtensions
        /// {
        ///     static void Main()
        ///     {
        ///         Console.WriteLine("hello world.".CapitalizeFirstLetter());
        ///         //output : Hello world.
        ///     }
        /// }   
        /// </code>
        /// </example>
        public static string CapitalizeFirstLetter(this string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return input;
            }

            return input.Substring(0, 1).ToUpper(CultureInfo.CurrentCulture) + input.Substring(1, input.Length - 1);
        }

        /// <summary>
        /// Return substring by given params - between the <paramref name="startString"/> and the <paramref name="endString"/>.
        /// </summary>
        /// <param name="input">The given string that should be processed.</param>
        /// <param name="startString">The left part of the given string.</param>
        /// <param name="endString">The right part of the given string.</param>
        /// <param name="startFrom">Optional param, which if left unvalueted gets default value 0, else the given value.</param>
        /// <returns>Return String.Empty if the given string is empty or it doesn't exist in the given input.</returns>
        /// <example>
        /// A simple example of the method logic.
        /// <code>
        /// class TestExtensions
        /// {
        ///     static void Main()
        ///     {
        ///         Console.WriteLine("hello beautiful kind world.".GetStringBetween("hello","world"));
        ///         //output :  beatufiul kind 
        ///     }
        /// }  
        /// </code>
        /// </example>
        public static string GetStringBetween(this string input, string startString, string endString, int startFrom = 0)
        {
            input = input.Substring(startFrom);
            startFrom = 0;
            if (!input.Contains(startString) || !input.Contains(endString))
            {
                return string.Empty;
            }

            var startPosition = input.IndexOf(startString, startFrom, StringComparison.Ordinal) + startString.Length;
            if (startPosition == -1)
            {
                return string.Empty;
            }

            var endPosition = input.IndexOf(endString, startPosition, StringComparison.Ordinal);
            if (endPosition == -1)
            {
                return string.Empty;
            }

            return input.Substring(startPosition, endPosition - startPosition);
        }

        /// <summary>
        /// Convert the given <paramref name="input"/> as <seealso cref="System.String"/> to latin-alphabet representation.
        /// </summary>
        /// <param name="input">The given string in cyrillic to be converted to latin.</param>
        /// <returns>Return the given string in cyrillic to it's latin representation, 
        /// if <paramref name="input"/> is empty - returns null.
        /// </returns>
        /// <example>
        /// A simple example of the method logic.
        /// <code>
        /// class TestExtensions
        /// {
        ///     static void Main()
        ///     {
        ///         Console.WriteLine("Здравей свят.".ConvertCyrillicToLatinLetters());
        ///         //output :  Zdravey svyat. 
        ///     }
        /// }  
        /// </code>
        /// </example>
        public static string ConvertCyrillicToLatinLetters(this string input)
        {
            var bulgarianLetters = new[]
            {
                "а", "б", "в", "г", "д", "е", "ж", "з", "и", "й", "к", "л", "м", "н", "о", "п",
                "р", "с", "т", "у", "ф", "х", "ц", "ч", "ш", "щ", "ъ", "ь", "ю", "я"
            };
            var latinRepresentationsOfBulgarianLetters = new[]
            {
                "a", "b", "v", "g", "d", "e", "j", "z", "i", "y", "k",
                "l", "m", "n", "o", "p", "r", "s", "t", "u", "f", "h",
                "c", "ch", "sh", "sht", "u", "i", "yu", "ya"
            };
            for (var i = 0; i < bulgarianLetters.Length; i++)
            {
                input = input.Replace(bulgarianLetters[i], latinRepresentationsOfBulgarianLetters[i]);
                input = input.Replace(bulgarianLetters[i].ToUpper(), latinRepresentationsOfBulgarianLetters[i].CapitalizeFirstLetter());
            }

            return input;
        }

        /// <summary>
        /// Convert the given <paramref name="input"/> as <seealso cref="System.String"/> to cyrillic-alphabet representation.
        /// </summary>
        /// <param name="input">The given string in latin to be converted to cyrillic-alphabet.</param>
        /// <returns>Return the given string in latin to it's cyrillic representation, 
        /// if <paramref name="input"/> is empty - returns null.
        /// </returns>
        /// <example>
        /// A simple example of the method logic.
        /// <code>
        /// class TestExtensions
        /// {
        ///     static void Main()
        ///     {
        ///         Console.WriteLine("Zdravey svqat.".ConvertLatinToCyrillicKeyboard());
        ///         //output :  Здравей свят. 
        ///     }
        /// }  
        /// </code>
        /// </example>
        public static string ConvertLatinToCyrillicKeyboard(this string input)
        {
            var latinLetters = new[]
            {
                "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p",
                "q", "r", "s", "t", "u", "v", "w", "x", "y", "z"
            };

            var bulgarianRepresentationOfLatinKeyboard = new[]
            {
                "а", "б", "ц", "д", "е", "ф", "г", "х", "и", "й", "к",
                "л", "м", "н", "о", "п", "я", "р", "с", "т", "у", "ж",
                "в", "ь", "ъ", "з"
            };

            for (int i = 0; i < latinLetters.Length; i++)
            {
                input = input.Replace(latinLetters[i], bulgarianRepresentationOfLatinKeyboard[i]);
                input = input.Replace(latinLetters[i].ToUpper(), bulgarianRepresentationOfLatinKeyboard[i].ToUpper());
            }

            return input;
        }

        /// <summary>
        /// Returns the given <paramref name="input"/> as <seealso cref="System.String"/> in valid format.
        /// </summary>
        /// <param name="input">The input value, which have to be validated.</param>
        /// <returns>Returns the given <paramref name="input"/>,
        /// excluding it's non-alphabet symbols, except for numbers, lower nyphen and dot!
        /// </returns>
        /// <example>
        /// A simple example of the method logic.
        /// <code>
        /// class TestExtensions
        /// {
        ///     static void Main()
        ///     {
        ///         Console.WriteLine("borisla21321(*67123)".ToValidUsername());
        ///         //output :  borisla2132167123 
        ///     }
        /// }  
        /// </code>
        /// </example>
        public static string ToValidUsername(this string input)
        {
            input = input.ConvertCyrillicToLatinLetters();

            //remove all non-alphabet symbols, excluding numbers, lower hyphen and dot(.)
            return Regex.Replace(input, @"[^a-zA-z0-9_\.]+", string.Empty);
        }

        /// <summary>
        /// Returns the given <paramref name="input"/> as <seealso cref="System.String"/> in valid file format.
        /// </summary>
        /// <param name="input">The input value, which have to be validated.</param>
        /// <returns>Returns the given <paramref name="input"/>,
        /// excluding it's non-alphabet symbols, except for numbers, lower and upper nyphen and dot!
        /// Also replaces " " - whitespaces with upper nyphen.
        /// </returns>
        /// <example>
        /// A simple example of the method logic.
        /// <code>
        /// class TestExtensions
        /// {
        ///     static void Main()
        ///     {
        ///         Console.WriteLine("NotValid file name ***lalala*** .docx".ToValidLatinFileName());
        ///         //output :  NotValid-file-name-lalala-.docx
        ///     }
        /// }  
        /// </code>
        /// </example>
        public static string ToValidLatinFileName(this string input)
        {
            input = input.Replace(" ", "-").ConvertCyrillicToLatinLetters();

            //remove all non-alphabet symbols, excluding number, lower and upper hyphen as we as dot(.)
            return Regex.Replace(input, @"[^a-zA-z0-9_\.\-]+", string.Empty);
        }

        /// <summary>
        /// Returns substring from a given <seealso cref="System.String"/> as first param, and <seealso cref="System.Int32"/> length as second param.
        /// </summary>
        /// <param name="input">The given string to be processed.</param>
        /// <param name="charsCount">The length of the substring.</param>
        /// <returns>If <paramref name="charsCount"/> is bigger than the <paramref name="input"/> length, returns the word itself as a substring,
        /// else return a substring with length the value of <paramref name="charsCount"/> 
        /// </returns>
        /// <exception cref="System.ArgumentOutOfRangeException">
        /// If <paramref name="charsCount"/> contains a negative value.
        /// </exception>
        /// <example>
        /// A simple example of the method logic.
        /// <code>
        /// class TestExtensions
        /// {
        ///     static void Main()
        ///     {
        ///         Console.WriteLine("Test".GetFirstCharacters(3));
        ///         //output :  Tes
        ///     }
        /// }  
        /// </code>
        /// </example>
        public static string GetFirstCharacters(this string input, int charsCount)
        {
            return input.Substring(0, Math.Min(input.Length, charsCount));
        }

        /// <summary>
        /// Process the given <paramref name="fileName"/> as <seealso cref="System.String"/>, returning its file extension.
        /// </summary>
        /// <param name="fileName">The given param as <seealso cref="System.String"/></param>
        /// <returns>Return String.Empty if there is not extension in the given <paramref name="fileName"/> or empty,
        /// otherwise return the file extension.
        /// </returns>
        /// <example>
        /// A simple example of the method logic.
        /// <code>
        /// class TestExtensions
        /// {
        ///     static void Main()
        ///     {
        ///         Console.WriteLine("Correct-File-Name.txt.exe".GetFileExtension());
        ///         //output : exe
        ///     }
        /// }  
        /// </code>
        /// </example>
        public static string GetFileExtension(this string fileName)
        {
            if (string.IsNullOrWhiteSpace(fileName))
            {
                return string.Empty;
            }

            string[] fileParts = fileName.Split(new[] { "." }, StringSplitOptions.None);
            if (fileParts.Count() == 1 || string.IsNullOrEmpty(fileParts.Last()))
            {
                return string.Empty;
            }

            return fileParts.Last().Trim().ToLower();
        }

        /// <summary>
        /// Process the given <paramref name="fileName"/> as <seealso cref="System.String"/>, returning its content type.
        /// </summary>
        /// <param name="fileExtension">The given param as <seealso cref="System.String"/></param>
        /// <returns>
        /// Return null if the given <paramref name="fileName"/> is empty,
        /// otherwise return the file content type.
        /// </returns>
        /// <example>
        /// A simple example of the method logic.
        /// <code>
        /// class TestExtensions
        /// {
        ///     static void Main()
        ///     {
        ///         Console.WriteLine("doc".ToContentType());
        ///         //output : application/msword
        ///     }
        /// }  
        /// </code>
        /// </example>
        public static string ToContentType(this string fileExtension)
        {
            var fileExtensionToContentType = new Dictionary<string, string>
            {
                { "jpg", "image/jpeg" },
                { "jpeg", "image/jpeg" },
                { "png", "image/x-png" },
                {
                        "docx",
                        "application/vnd.openxmlformats-officedocument.wordprocessingml.document"
                },
                { "doc", "application/msword" },
                { "pdf", "application/pdf" },
                { "txt", "text/plain" },
                { "rtf", "application/rtf" }
            };
            if (fileExtensionToContentType.ContainsKey(fileExtension.Trim()))
            {
                return fileExtensionToContentType[fileExtension.Trim()];
            }

            //default value, if fileExtension was not found
            return "application/octet-stream";
        }

        /// <summary>
        /// Convert the given <paramref name="fileName"/> as <seealso cref="System.String"/>, returning array of bytes.
        /// </summary>
        /// <param name="input">The instance of the <seealso cref="System.String"/></param>
        /// <returns>A byte array, containing each symbol of the given instance converted to byte.</returns>
        /// <example>
        /// A simple example of the method logic.
        /// <code>
        /// class TestExtensions
        /// {
        ///     static void Main()
        ///     {
        ///         var arr = "Hello world.".ToByteArray();
        ///         Console.WriteLine(String.Join(" ",arr));
        ///         //output : 72 0 101 0 108 0 108 0 111 0 32 0 119 0 111 0 114 0 108 0 100 0 46 0
        ///     }
        /// }  
        /// </code>
        /// </example>
        public static byte[] ToByteArray(this string input)
        {
            var bytesArray = new byte[input.Length * sizeof(char)];

            //Copies a specified number of bytes from a source array starting at a particular offset to a destination array starting at a particular offset.
            Buffer.BlockCopy(input.ToCharArray(), 0, bytesArray, 0, bytesArray.Length);
            return bytesArray;
        }
    }
}