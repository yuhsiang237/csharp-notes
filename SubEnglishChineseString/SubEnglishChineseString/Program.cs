using System;
using System.Text;
using System.Linq;

namespace SubEnglishChineseString
{
    public static class Program
    {
        /// <summary>
        /// C#中擷取某長度中英混雜字串範例
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            string str = "TESTWORD測試文字TEST";
            Console.WriteLine(SubBig5String(str, 1, 15));
        }
        /// <summary>
        /// C#中擷取Big5子字串
        /// </summary>
        /// <param name="str">字串</param>
        /// <param name="start">擷取起始索引</param>
        /// <param name="length">擷取長度</param>
        /// <returns>string</returns>
        public static string SubBig5String(string str, int start, int length)
        {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            byte[] subByteArray = Encoding.GetEncoding("big5").GetBytes(str).Skip(start).Take(length).ToArray();
            return Encoding.GetEncoding("big5").GetString(subByteArray);
        }
    }
}
