using System.Security.Cryptography;
using System.Text;

namespace BankingWebApp.Services
{
    public class PasswordEncrypter
    {
        /* 
         * Todo:
         * Add "salt" column to Customer table
         * Saving into database -> Save hashedPasswordWithSalt as "password" and save "salt" alongside it
         * Retrieving from database-> check user input by adding the inputPassword with saved salt, and hashing it again, and then checking the hashedPassword with the saved hashPasword in database.
         */

        /// <summary>
        /// Generates a random salt using RandomNumberGenerator
        /// </summary>
        /// <returns>Random string text of Salt</returns>
        public static string GenerateSaltForPassword()
        {
            const int size = 128 / 8;
            var saltValue = "";
            var bytesContainer = new byte[size];
            using (var keyGenerator = RandomNumberGenerator.Create())
            {
                keyGenerator.GetBytes(bytesContainer);
                saltValue = BitConverter.ToString(bytesContainer).Replace("-", "").ToLower();
                return saltValue;
            }
        }

        /// <summary>
        /// Hasing string plus salt value
        /// </summary>
        /// <param name="password"></param>
        /// <param name="salt"></param>
        /// <returns>Hashed Value combining password and salt</returns>
        public static string HashPasswordWithSalt(string password, string salt)
        {
            var hashedPasswordWithSalt = "";
            var bytes = Encoding.UTF8.GetBytes(password + salt);
            using (var sha256 = SHA256.Create())
            {
                var hash = sha256.ComputeHash(bytes);
                hashedPasswordWithSalt = BitConverter.ToString(hash).Replace("-", "").ToLower();
                return hashedPasswordWithSalt;
            }
        }

        /// <summary>
        /// Hashing string value
        /// </summary>
        /// <param name="password"></param>
        /// <returns>Hashed value of password</returns>
        public static string HashPassword(string password)
        {
            var hashedPassword = "";
            var bytes = Encoding.UTF8.GetBytes(password);
            using (var sha256 = SHA256.Create())
            {
                var hash = sha256.ComputeHash(bytes);
                hashedPassword = BitConverter.ToString(hash).Replace("-", "").ToLower();
                return hashedPassword;
            }
        }


        /* 
         * Notes to be taken when using different Encoding types: UTF8, UTF32, Unicode, BigEndianUnicode, ASCII, Latin1
         * when converting string -> bytes using System.Text.Encoding.<EncodingType>.GetBytes(stringValue)
         * 
         * Observation made:
         * UTF8, ASCII, Latin has same values
         * UTF32, Unicode, & BigEndianUnicode has different values
         */
    }
}
