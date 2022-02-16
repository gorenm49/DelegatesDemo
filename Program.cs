using System;

namespace DelegatesDemo
{
    public class Program
    {
        public static void Main(string[] args)
        {
          
            System.Console.WriteLine("Welcome to Delegates Demo!!!\n Enter number to Choose Operation:\n"+
            "1. Single Cast Delegates\n"+
            "2. Multi Cast Delegate\n"+
            "3. Exit");    
            int num = Convert.ToInt32(Console.ReadLine());

            switch (num)
            {
                case 1:
                    DelegatesSingle del = new DelegatesSingle();
                    del.Delegates();
                    break;
                case 2:
                    DelegatesMulti del1 = new DelegatesMulti();
                    del1.DelegatesMul();
                    break;
                case 3:
                    break;
                default:
                    System.Console.WriteLine("Choose valid option..");
                    break;
            }
        }
    }
}