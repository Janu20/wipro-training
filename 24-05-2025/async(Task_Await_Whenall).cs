using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Class5
    {
        public static async Task DownloadFileAsync(string file_name,int delayms)
        {
            Console.WriteLine(file_name + " File started downloading..");
            await Task.Delay(delayms);
            Console.WriteLine(file_name + " Download completed");

        }
        public static async Task Main(string[] args)
        {
            Task t1 = DownloadFileAsync("file1.pdf", 2000);
            Task t2 = DownloadFileAsync("file2.jpg", 4000);
            Task t3 = DownloadFileAsync("file3.doc", 6000);

            await Task.WhenAll(t1, t2, t3);

            Console.WriteLine("All file downloaded successfully.");
        }
    }
}
