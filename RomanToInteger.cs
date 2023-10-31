using System.Collections;

namespace RomanToInteger
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string roman = "MCMXCIV";
            Hashtable ht = new Hashtable();

            ht.Add("I", 1);
            ht.Add("V", 5);
            ht.Add("X", 10);
            ht.Add("L", 50);
            ht.Add("C", 100);
            ht.Add("D", 500);
            ht.Add("M", 1000);

            int sum = 0;
            for (int i=0; i<roman.Length; ++i) 
            {
                bool isCalculated = false;
                switch (roman[i].ToString())
                {
                    case "I": 
                        {
                            if ((i + 1 < ht.Count) && (roman[i + 1]=='V' || roman[i + 1]=='X'))
                            {
                                sum -= Convert.ToInt32(ht[roman[i].ToString()]);
                                isCalculated = true;
                            }
                            break; 
                        }
                    case "X": 
                        {
                            if ((i + 1 < ht.Count) && (roman[i + 1]=='L' || roman[i + 1]=='C'))
                            {
                                sum -= Convert.ToInt32(ht[roman[i].ToString()]);
                                isCalculated = true;
                            }
                            break;
                        }
                    case "C":
                        {
                            if ((i + 1 < ht.Count) && (roman[i + 1]=='D' || roman[i + 1]=='M'))
                            {
                                sum -= Convert.ToInt32(ht[roman[i].ToString()]);
                                isCalculated = true;
                            }
                            break;
                        }

                }
                if(!isCalculated)
                    sum += Convert.ToInt32(ht[roman[i].ToString()]);

            }

            Console.WriteLine(sum.ToString());
            
        }
    }
}