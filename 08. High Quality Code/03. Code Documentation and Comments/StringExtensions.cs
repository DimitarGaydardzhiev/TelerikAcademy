namespace Telerik.ILS.Common
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;
    using System.Security.Cryptography;
    using System.Text;
    using System.Text.RegularExpressions;
    /// <summary>
    /// Extensions to convert a given input to string value. Static class.
    /// </summary>
    public static class StringExtensions
    {
        /// <summary>
        /// Converts a string byte by bute to its hexadecimal representation.
        /// </summary>
        /// <param name="input">The string value to convert</param>
        /// <returns>The hexadecimal string</returns>
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
        /// Checks if a givven string has a truly value.
        /// </summary>
        /// <remarks>
        /// Tryly values: "true", "ok", "yes", "1", "да".
        /// </remarks>
        /// <param name="input">The given string</param>
        /// <returns>True or false</returns>
        public static bool ToBoolean(this string input)
        {
            var stringTrueValues = new[] { "true", "ok", "yes", "1", "да" };
            return stringTrueValues.Contains(input.ToLower());
        }
        /// <summary>
        /// Convert a string to a variable of type Short.
        /// </summary>
        /// <param name="input">The given string</param>
        /// <returns>The input parameter as a Short</returns>
        /// <exception cref="System.ArgumentException"
        /// <seealso cref="ToBoolean"/>
        /// <seealso cref="ToInteger"/>
        /// <seealso cref="ToLong"/>
        /// <seealso cref="ToDateTime"/>
        public static short ToShort(this string input)
        {
            short shortValue;
            short.TryParse(input, out shortValue);
            return shortValue;
        }
        /// <summary>
        /// Convert a string to a variable of type Int32
        /// </summary>
        /// <param name="input">The given string</param>
        /// <returns>The input parameter as a Int32</returns>
        /// <exception cref="System.ArgumentException"
        /// <seealso cref="ToBoolean"/>
        /// <seealso cref="ToShort"/>
        /// <seealso cref="ToLong"/>
        /// <seealso cref="ToDateTime"/>
        public static int ToInteger(this string input)
        {
            int integerValue;
            int.TryParse(input, out integerValue);
            return integerValue;
        }
        /// <summary>
        /// Convert a string to a variable of type Int64
        /// </summary>
        /// <param name="input">The given string</param>
        /// <returns>The input parameter as a Int34</returns>
        /// <exception cref="System.ArgumentException"
        /// <seealso cref="ToBoolean"/>
        /// <seealso cref="ToShort"/>
        /// <seealso cref="ToInteger"/>
        /// <seealso cref="ToDateTime"/>
        public static long ToLong(this string input)
        {
            long longValue;
            long.TryParse(input, out longValue);
            return longValue;
        }
        /// <summary>
        /// Convert a string to a variable of type IDateTime
        /// </summary>
        /// <param name="input">The given string</param>
        /// <returns>The input parameter as a DateTime</returns>
        /// <exception cref="System.ArgumentException"
        /// <seealso cref="ToBoolean"/>
        /// <seealso cref="ToShort"/>
        /// <seealso cref="ToInteger"/>
        /// <seealso cref="ToLong"/>
        public static DateTime ToDateTime(this string input)
        {
            DateTime dateTimeValue;
            DateTime.TryParse(input, out dateTimeValue);
            return dateTimeValue;
        }
        /// <summary>
        /// Capitalize the first letter of a given string
        /// </summary>
        /// <param name="input">The given string</param>
        /// <returns>The string with capitalized first letter</returns>
        public static string CapitalizeFirstLetter(this string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return input;
            }

            return input.Substring(0, 1).ToUpper(CultureInfo.CurrentCulture) + input.Substring(1, input.Length - 1);
        }
        /// <summary>
        /// Extracts a substring by given string values.
        /// </summary>
        /// <param name="input">The given string.</param>
        /// <param name="startString">The string to start from.</param>
        /// <param name="endString">The string to end.</param>
        /// <param name="startFrom">Starting index (the input will be cut before this value). Initially = 0.</param>
        /// <returns>The extracted substiring.</returns>
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
        /// Converts a string in cyrillic to its latin representation.
        /// </summary>
        /// <param name="input">The input string (in cyrillic).</param>
        /// <returns>The input with its latin representation.</returns>
        /// <example>"а", "б", "в", "г" -> "a", "b", "v", "g" ... "ч", "ш", "щ" -> "ch", "sh", "sht"</example>
        /// <exception cref="System.ArgumentException"
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
        /// Converts a string in latin to its cyrillic representation from the phonetic traditional keyboard.
        /// </summary>
        /// <param name="input">The input string (in latin).</param>
        /// <returns>The input with its cyrillic representation from the phonetic traditional keyboard.</returns>
        /// <example>""a", "b", "c", "d" -> "а", "б", "ц", "д" ... "w", "x", "y", "z" -> "в", "ь", "ъ", "з"</example>
        /// <exception cref="System.ArgumentException"
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
        /// Convert an input string as a valid username from Cyrillic to Latin, and repllaces all invalid sybols with empty string.
        /// </summary>
        /// <param name="input">The givven string</param>
        /// <returns>The input converted to its latin representation, without any invalid sybmols.</returns>
        public static string ToValidUsername(this string input)
        {
            input = input.ConvertCyrillicToLatinLetters();
            return Regex.Replace(input, @"[^a-zA-z0-9_\.]+", string.Empty);
        }
        /// <summary>
        /// Convert an input string as a valid filename from Cyrillic to Latin, and repllaces all invalid sybols with empty string, and spacfes with a dash "-".
        /// </summary>
        /// <param name="input">The givven string</param>
        /// <returns>The input converted to its latin representation, without any invalid sybmols.</returns>
        public static string ToValidLatinFileName(this string input)
        {
            input = input.Replace(" ", "-").ConvertCyrillicToLatinLetters();
            return Regex.Replace(input, @"[^a-zA-z0-9_\.\-]+", string.Empty);
        }
        /// <summary>
        /// Extracts first N characters from a givven string.
        /// </summary>
        /// <param name="input">The given string</param>
        /// <param name="charsCount">The number of characters to extract</param>
        /// <returns>Extracted characters begining from start to N. If N is more than the length of the input, the method retuns the all input.</returns>
        public static string GetFirstCharacters(this string input, int charsCount)
        {
            return input.Substring(0, Math.Min(input.Length, charsCount));
        }
        /// <summary>
        /// Extracts the extension from a given file.
        /// </summary>
        /// <param name="fileName">The filname, with its extension as a string.</param>
        /// <returns>The extension of the input.</returns>
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
        /// Get the content type of a file.
        /// </summary>
        /// <param name="fileExtension">The file extension, as a string.</param>
        /// <returns>The content type. If unknown - returns: "application/octet-stream".</returns>
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

            return "application/octet-stream";
        }
        /// <summary>
        /// Converts a string to a byte array.
        /// </summary>
        /// <param name="input">The given string to be converted.</param>
        /// <returns>The input as a byte array.</returns>
        public static byte[] ToByteArray(this string input)
        {
            var bytesArray = new byte[input.Length * sizeof(char)];
            Buffer.BlockCopy(input.ToCharArray(), 0, bytesArray, 0, bytesArray.Length);
            return bytesArray;
        }
    }
}
