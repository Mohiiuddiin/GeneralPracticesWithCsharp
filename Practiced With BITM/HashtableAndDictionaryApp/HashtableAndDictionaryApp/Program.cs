using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashtableAndDictionaryApp
{
    class Program
    {
        static void Main(string[] args)
        {

            Dictionary<string,string> myDictionary = new Dictionary<string, string>();
            myDictionary.Add("ab", "amar desh bangladesh");
            myDictionary.Add("bc", "tomar desh bangladesh");


            Console.WriteLine(myDictionary["ab"]);
            

            //foreach (KeyValuePair<string, string> valuePair in myDictionary)
            //{
            //    Console.WriteLine(valuePair.Key+" "+valuePair.Value);
            //}


            //Hashtable myHashtable = new Hashtable();
            //myHashtable.Add("ab", "amar desh bangladesh");
            //myHashtable.Add("bc", "tomar desh bangladesh");

            //bool isExists = myHashtable.ContainsKey("abd");
            //Console.WriteLine(isExists);
            //Console.WriteLine(myHashtable["ab"]);


        }
    }
}
