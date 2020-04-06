using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BuildSHA256
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("請輸入任意字串(產製SHA256)> ");
                string cmd = Console.ReadLine();
                Console.WriteLine(StringGetSHA256ByteEncodeByBase64(cmd));
                Console.WriteLine("");
            }
        }
        /// <summary>
        /// 字串取得SHA256後以Base64編碼
        /// </summary>
        /// <param name="_Str"></param>
        /// <returns></returns>
        public static string StringGetSHA256ByteEncodeByBase64(string _Str)
        {
            try
            {
                SHA256 sha256 = new SHA256CryptoServiceProvider();
                byte[] buffer = Encoding.Default.GetBytes(_Str);
                byte[] hashcode = sha256.ComputeHash(buffer);
                return Convert.ToBase64String(hashcode);
            }
            catch (Exception ex)
            {
                throw new Exception("GetSHA256HashFromString() fail,error:" + ex.Message);
            }
        }
    }
}
