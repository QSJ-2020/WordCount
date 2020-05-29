using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //获取文章
            string word = File.ReadAllText(@"args[1]").ToLower();//将输入的英文字符全部转换为小写字符
            string n = args[0];
            if (n == "-c")
                countChar(word);//获取字符数
            if (n == "-w")
                countword(word);//获取单词数
        }

        //统计字符个数
        public static void countChar(string word)
        {
            int num = 0;
            char[] word1 = word.ToCharArray();//将接收的英文存入字符数组方便统计个数
            for (int i = 0; i < word1.Length; i++)
            {
                if (word[i] >= 0 && word[i] <= 127)
                {
                    num++;
                }
            }
            Console.WriteLine(num);
        }

        //统计单词数
        public static void countword(string q)
        {
            int n = 0;
            int num = 0;
            string[] words = q.Split(new char[] { ',', ' ', '.', '?', '!', ':', ';', '—', ',', '"', '\n' });//提取单词
            foreach (string i in words)//判断是否为单词
            {
                if (i.Length >= 4)
                {
                    int cout = 0;
                    int m = 0;
                    n++;
                    char[] ch = i.ToCharArray();
                    foreach (char chs in ch)
                    {
                        cout++;
                        if (chs <= 'z' && chs >= 'a')
                        {
                            m++;
                        }
                        while (m == 4 && cout == 4)
                        {
                            num++;
                            break;
                        }
                    }
                }
            }
            Console.WriteLine(num);
        }
    }
}