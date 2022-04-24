using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace AddressBookProblem
{
    internal class StreamReaderAndWriter
    {
        public void WritingUsingStreamWriter()
        {
            string path = @"D:\.Net program\AddressBookProblem_FileIO\AddressBookProblem\StreamWriterdemo.txt";

            using (StreamWriter sw = File.AppendText(path))
            {
                sw.WriteLine("Hello World - .net is Awesome ");
                sw.Close();

                Console.WriteLine(File.ReadAllText(path));
            }
            Console.ReadKey();
        }
        public void ReadlingUsingStreamReader()
        {
            string path = @"D:\.Net program\AddressBookProblem_FileIO\AddressBookProblem\StreamWriterdemo.txt";

            using (StreamReader sr = File.OpenText(path))
            {
                string s = " ";
                while ((s = sr.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                }
            }
            Console.ReadKey();

        }
    }
}