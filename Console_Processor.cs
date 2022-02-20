using System;
namespace Karakter_degistirme{
    public static class Console_processor{
        static List<string> input_list = new List<string>();
        public static List<string> input(){
             string input_s = "";
            try_input();
            void try_input(){
                Console.WriteLine("ifadeyi giriniz.");
                input_s = Console.ReadLine();
                input_s =  input_s.Trim();
                if (input_s == "" ) {Console.WriteLine("hiçbir veri girmediniz."); try_input();}
            }
                
            input_list = input_s.Split(' ').ToList();

            return input_list;
        }
    }
}