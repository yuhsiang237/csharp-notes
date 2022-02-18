using System;
using System.Linq;

namespace LinqNote.Command
{
    public class LINQElementOperatorCommand : ILINQElementOperatorCommand
    {
        private class User
        {
            public string Name { get; set; }
        }
        public bool Run()
        {
            var result = true;
            try
            {
                First();
                FirstOrDefault();
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine(ex.Message);
                result = false;
            }
            return result;
        }


        /// <summary>
        /// FirstOrDefault
        /// 傳回序列中符合條件的第一個元素；如果找不到這類元素，則傳回預設值。
        /// </summary>
        /// <returns></returns>
        private void FirstOrDefault()
        {
            Console.WriteLine("FirstOrDefault:");
            Console.WriteLine("var arr = new int [] { 1, 2, 3, 4, 5 };");
            var arr = new int[] { 1, 2, 3, 4, 5 };
            var res1 = arr.Where(x => x == 10).FirstOrDefault();
            var res2 = arr.Where(x => x == 5).FirstOrDefault();
            Console.WriteLine("arr.Where(x => x == 10).FirstOrDefault()," + res1);
            Console.WriteLine("arr.Where(x => x == 5).FirstOrDefault()," + res2);
            var arr2 = new User[] { new User(), new User() { Name = "Yu Hsiang" } };
            Console.WriteLine("var arr2 = new User[] { new User(), new User() { Name = \"Yu Hsiang\" } };");
            var res3 = arr2.Where(x => x.Name == "XXX").FirstOrDefault();
            var res4 = arr2.Where(x => x.Name == "Yu Hsiang").FirstOrDefault();
            Console.WriteLine("arr2.Where(x => x.Name == \"XXX\").FirstOrDefault()," + res3);
            Console.WriteLine("arr2.Where(x => x.Name == \"Yu Hsiang\").FirstOrDefault()," + res4);
        }

        /// <summary>
        /// First 
        /// 傳回序列的第一個項目。
        /// </summary>
        /// <returns></returns>
        private void First()
        {
            Console.WriteLine("First:");
            Console.WriteLine("var arr = new int [] { 1, 2, 3, 4, 5 };");
            var arr = new int[] { 1, 2, 3, 4, 5 };
            try
            {
                var res1 = arr.Where(x => x == 10).First();
            }
            catch (Exception ex)
            {
                Console.WriteLine("arr.Where(x => x == 10).First()\nresponse:\n" + "error:" + ex.Message);
            }
            var res2 = arr.Where(x => x == 5).First();
            Console.WriteLine("arr.Where(x => x == 5).First()\nresponse:\n" + res2);

            var arr2 = new User[] { new User(), new User() { Name = "Yu Hsiang" } };
            Console.WriteLine("var arr2 = new User[] { new User(), new User() { Name = \"Yu Hsiang\" } };");
            try
            {
                var res3 = arr2.Where(x => x.Name == "XXX").First();
            }
            catch (Exception ex)
            {
                Console.WriteLine("arr2.Where(x => x.Name == \"XXX\").First()\nresponse:\n" + "error:" + ex.Message);
            }
            var res4 = arr2.Where(x => x.Name == "Yu Hsiang").First();
            Console.WriteLine("arr2.Where(x => x.Name == \"Yu Hsiang\").FirstOrDefault()\nresponse:\n" + res4);
        }
    }
}
