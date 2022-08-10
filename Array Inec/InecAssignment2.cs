using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Inec
{
    internal class InecAssignment2
    {
        public void Name()
        {
            /*database adjusted to have no duplicates*/
            SortedList<string, int> sortList = new SortedList<string, int>();

            string[] inecArray = { "Aaran", "Aaren", "Aayan", "Aarman", "Aaron", "Aaron-James", "Aaron", "Abdul", "Aaryn", "Aayan", "Aazaan", "Abaan", "Abbas", "Abdul", "Abdalroof", "Abdihakim", "Abdirahman", "Abdisalam", "Abdul", "Abdul-Aziz", "Abdulbasir", "Abdulkadir", "Abdulkarem", "Abdulkhader", "Aaron", "Abdul-Majeed", "Aaron" };                     //initial inec database



            foreach (var name in inecArray)                     //loop  through the items
            {
                int noOfTimes = 0;
                if (sortList.ContainsKey(name))
                {
                    continue;
                }
                for (int i = 0; i < inecArray.Length; i++)         /*check through each element for duplicate
*/
                {
                    if (name == inecArray[i])
                    {
                        noOfTimes++;
                    }
                }
                if (noOfTimes >= 1)
                {
                    sortList.Add(name, noOfTimes);
                }
            }


            SortedSet<string> voterList = new SortedSet<string>();

            foreach (var item in sortList)
            {
                voterList.Add(item.Key);
            }

            foreach (var item in voterList)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("enter voter name");
            string newName = Console.ReadLine();
            newName = newName.ToLower();

            if (voterList.Contains(newName))
            {
                Console.WriteLine("Voter already exists");
            }
            else
            {
                voterList.Add(newName);
                Console.WriteLine("User successfully added");

            }
        }
    }
}
