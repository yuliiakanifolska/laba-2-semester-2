using System;
using System.Drawing;
using System.IO;
using Newtonsoft.Json;


namespace Application
{
    public class DynamicArray
    {
        public int[] Array;
        public int Size;
        public DynamicArray(int size)
        {
            Array = new int[size];
            Size = size;

        }

        public void Random()
        {
            Random ran = new Random();

            for (int i = 0; i < Size; i++)
            {
                Array[i] = ran.Next(0, 10);

                Console.Write(Array[i] + " ");
            }

            

        }
        public void Shuffle()
        {
            Random rand = new Random();

            for (int i = 0; i < Array.Length; i++)
            {
                int randomIndex = rand.Next(i, Array.Length); // Включая i, исключая Array.Length
                int temp = Array[i];
                Array[i] = Array[randomIndex];
                Array[randomIndex] = temp;

                Console.Write(Array[i] + " ");
            }
        }

        public int FindUnique()
        {
            int count = 0;
            for (int i = 0; i < Array.Length; i++)
            {
                bool isUnique = true;
                int tempNumber = Array[i];
                for (int k = i + 1; k < Array.Length; k++)
                {
                    int tempnumber1 = k;
                    if (Array[k] == tempNumber)
                    {
                        isUnique = false;
                        break;
                    }
                }
                if (isUnique)
                {
                    count++;
                }
            }
            return count;
        }
        ~DynamicArray()
        {
            Console.WriteLine("Useless Object have been delete");
        }

        public void SaveJSON()
        {
            string json = JsonConvert.SerializeObject(this);
            string filePath = "/Users/admin/Projects/Laba2(2)/file.json";
        File.WriteAllText(filePath, json);
        }
        public void AddJSON()
        {
            string filePath = "/Users/admin/Projects/Laba2(2)/file.json";
            string json = JsonConvert.SerializeObject(this, Formatting.None);
            using (StreamWriter writer = new StreamWriter(filePath, true))
            {
                writer.WriteLine(json);
            }
        }

    }
}


