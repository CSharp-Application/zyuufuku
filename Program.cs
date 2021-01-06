using System;
using System.Collections.Generic;

namespace 重なってる確認
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("データを、\",\"で区切って入力してください。");
            string data = Console.ReadLine();
            string[] split = data.Split(',');
            List<string> kekka = new List<string>();
            foreach(string s in split)
            {
                if(kekka.IndexOf(s) == -1)
                {
                    kekka.Add(s);
                }
            }
            Console.Write("初めのデータには、");
            for(int i = 0;i < kekka.Count;i++)
            {
                if(i != kekka.Count-1)
                {
                    Console.Write($"「{kekka[i]}」,");
                }
                else
                {
                    Console.WriteLine($"「{kekka[i]}」");
                }
            }
            Console.WriteLine($"の、{kekka.Count}種類がありました。");
            Console.WriteLine("何かキーを押すと終了します...");
            Console.ReadKey();
            Environment.Exit(0);
        }
    }
}
