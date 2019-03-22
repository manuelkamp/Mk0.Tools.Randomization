using System;
using System.Text;

namespace Mk0.Tools.Randomization
{
    public class Randomize
    {
        /// <summary>
        /// Generiert einen zufälligen String aus Zahlen und Buchstaben mit optionalem Endzeichen
        /// </summary>
        /// <param name="length"></param>
        /// <param name="endzeichen"></param>
        /// <returns>Zufallsstring</returns>
        public static string NumbersAndDigits(int length, string beginnzeichen = "", string endzeichen = "")
        {
            string ret = string.Empty;
            StringBuilder SB = new StringBuilder();
            string Content = "1234567890ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvw";
            Random rnd = new Random();
            if (beginnzeichen != "")
            {
                SB.Append(beginnzeichen);
            }
            for (int i = 0; i < length; i++)
                SB.Append(Content[rnd.Next(Content.Length)]);
            if (endzeichen != "")
            {
                SB.Append(endzeichen);
            }
            return SB.ToString();
        }

        /// <summary>
        /// Generiert einen zufälligen String Buchstaben mit optionalem Endzeichen
        /// </summary>
        /// <param name="length"></param>
        /// <param name="endzeichen"></param>
        /// <returns>Zufallsstring</returns>
        public static string Digits(int length, string beginnzeichen = "", string endzeichen = "")
        {
            string ret = string.Empty;
            StringBuilder SB = new StringBuilder();
            string Content = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvw";
            Random rnd = new Random();
            if (beginnzeichen != "")
            {
                SB.Append(beginnzeichen);
            }
            for (int i = 0; i < length; i++)
                SB.Append(Content[rnd.Next(Content.Length)]);
            if (endzeichen != "")
            {
                SB.Append(endzeichen);
            }
            return SB.ToString();
        }

        /// <summary>
        /// Generiert einen zufälligen String aus Zahlen mit optionalem Endzeichen
        /// </summary>
        /// <param name="length"></param>
        /// <param name="endzeichen"></param>
        /// <returns>Zufallsstring</returns>
        public static string Numbers(int length, string beginnzeichen = "", string endzeichen = "")
        {
            string ret = string.Empty;
            StringBuilder SB = new StringBuilder();
            string Content = "1234567890";
            Random rnd = new Random();
            if (beginnzeichen != "")
            {
                SB.Append(beginnzeichen);
            }
            for (int i = 0; i < length; i++)
                SB.Append(Content[rnd.Next(Content.Length)]);
            if (endzeichen != "")
            {
                SB.Append(endzeichen);
            }
            return SB.ToString();
        }
    }
}
