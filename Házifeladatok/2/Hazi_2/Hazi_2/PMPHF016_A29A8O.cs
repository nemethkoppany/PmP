using System;
using System.Collections.Generic;
using System.IO;

namespace Hazi_2
{
    internal class PMPHF016_A29A8O
    {
        static void Main(string[] args)
        {


            string[] lines = File.ReadAllLines("input.txt");
            string[] headers = lines[0].Split(' ');
            int weight = int.Parse(headers[0]);
            int count = int.Parse(headers[1]);
            Dictionary<string, int> frequency = new Dictionary<string, int>();


            string text = "";
            for (int i = 1; i < lines.Length; i++)
            {
                text += $"{lines[i]} ";
            }

            char[] separators = new char[] { ',', ' ', '.', '?', '!' };
            string[] words = text.ToLower().Split(separators, StringSplitOptions.RemoveEmptyEntries);


            foreach (string w in words)
            {
                int sum = 0;
                foreach (char c in w)
                {
                    sum += c - 'a' + 1;

                }
                if (sum >= weight)
                {
                    if (frequency.ContainsKey(w))
                    {
                        frequency[w]++;
                    }
                    else
                    {
                        frequency.Add(w, 1);
                    }
                }
            }

            List<string> output = new List<string>();
            List<int> countList = new List<int>();
            if (frequency.Count == 0)
            {
                File.WriteAllText("output.txt", "Not Found!");
            }
            else
            {
                foreach (KeyValuePair<string, int> pair in frequency)
                {
                    if (!countList.Contains(pair.Value))
                    {
                        countList.Add(pair.Value);
                    }
                }
                countList.Sort();
                countList.Reverse();

                int threshold;
                if (countList.Count >= count)
                {
                    threshold = countList[count - 1];
                }
                else
                {
                    threshold = countList[countList.Count - 1];
                }

                foreach (KeyValuePair<string, int> pair in frequency)
                {
                    if (pair.Value >= threshold)
                    {
                        output.Add(pair.Key);
                    }
                }
                output.Sort();
                output.Reverse();
                string outputString = string.Join(",", output);
                File.WriteAllText("output.txt", outputString);
            }
        }
    }
}
