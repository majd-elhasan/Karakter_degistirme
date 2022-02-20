using System;
namespace Karakter_degistirme{
    static class MainClass{
        static void Main(string[] args){
            List<string> input_list = Console_processor.input();
            List<string> output_list = new List<string>();

            for (int i = 0; i < input_list.Count; i++)
            {

                char firstChar = input_list[i][0];
                char lastChar =  input_list[i][input_list[i].Length-1];
                string trimmed_word = "";
                for(int j = 0 ; j < input_list[i].Length-1 ; j++){
                    if(j != 0 && j != input_list[i].Length-1)
                    trimmed_word += input_list[i][j];
                }
                string word ="";
                if (input_list[i].Length == 1)  word = input_list[i];
                else 
                word = lastChar + trimmed_word + firstChar;
                Console.Write(word + " ");
            }
            
        }
    }
}
