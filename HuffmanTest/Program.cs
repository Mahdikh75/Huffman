using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace HuffmanTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "App Huffman";
            while (true)
            {
                //ورود اطلاعات
                Console.Write("String :");
                string input = Console.ReadLine();
                HuffmanTree huffmanTree = new HuffmanTree();
                // ساخت درخت هافمن
                huffmanTree.Build(input);
                //کد بوک
                BitArray encoded = huffmanTree.Encode(input);
                Console.Write("Encode : ");
                foreach (bool bit in encoded)
                {
                    Console.Write((bit ? 1 : 0) + "");
                }
                Console.WriteLine();
                // رشته اصلی
                string decoded = huffmanTree.Decode(encoded);
                Console.WriteLine("Decode : " + "'" + decoded + "'" + ", Count : " + decoded.Length);
                Console.WriteLine("---------------------------");
            }
        }
    }
}