using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Introduction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Windows";

            ShowLargeFileWithouthLinq(path);
            Console.WriteLine("***");
            ShowLargeFileWithLinq(path);
        }

        private static void ShowLargeFileWithLinq(string path)
        {
            var query = from file in new DirectoryInfo(path).GetFiles()
                        orderby file.Length descending
                        select file;
            /* 
               var query = new DirectoryInfo(path).GetFiles()
                            .OrderByDescending(f => f.Length)
                            .Take(5);
             */
            foreach (var file in query.Take(5))
            {
                Console.WriteLine($"{file.Name,-20} : {file.Length,10:N}");
            }
        }

        private static void ShowLargeFileWithouthLinq(string path)
        {
            DirectoryInfo directory = new DirectoryInfo(path);
            FileInfo[] files = directory.GetFiles();
            Array.Sort(files, new FileInfoComparer());

            for (int i = 0; i < 5; i++)
            //foreach(FileInfo file in files)
            {
                FileInfo file = files[i];
                Console.WriteLine($"{file.Name,-20} : {file.Length,10:N}");
            }

        }
    }
    public class FileInfoComparer : IComparer<FileInfo>
    {
        public int Compare(FileInfo x, FileInfo y)
        {
            return y.Length.CompareTo(x.Length);
        }
    }
}
