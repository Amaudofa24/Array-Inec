using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Inec
{
    internal class Program
    {
        static void Main(string[] args)
        {
            InecAssignment2 inec= new InecAssignment2();
            inec.Name();
            SortedList<string, int> duplicate = new SortedList<string, int>();
            string[] names = { "Aaran", "Aaren", "Aayan", "Aarman", "Aaron", "Aaron-James", "Aaron", "Abdul", "Aaryn", "Aayan", "Aazaan", "Abaan", "Abbas", "Abdul", "Abdalroof", "Abdihakim", "Abdirahman", "Abdisalam", "Abdul", "Abdul-Aziz", "Abdulbasir", "Abdulkadir", "Abdulkarem", "Abdulkhader", "Aaron", "Abdul-Majeed", "Aaron" };
            
            
                foreach (var item in names)
                {

                if (duplicate.ContainsKey(item))
                {
                    continue;
                }
                int count = 0;
                for (int i = 0; i < names.Length; i++)
                    {
                    if (item == names[i] )
                    {
                        count++;
                    }
                    }
                if(count > 1)
                     {
                    duplicate.Add(item, count);
                }

                
            }
            foreach (var item in duplicate)
            {
                Console.WriteLine(item);
            }
        }
    }
    
}