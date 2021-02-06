using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<double, string> myDictonary = new MyDictionary<double, string>();

            myDictonary.Add(12456391101, "Gökçe Aktuğ");
            myDictonary.Add(12456391102, "Büşra Ayverdi");
            myDictonary.Add(12456391103, "Ezgi Aslan");
            myDictonary.Add(10000000001, "Büşra Özen");
            myDictonary.Add(10104007001, "Engin Demiroğ");

            myDictonary.MyList();
        }
    }
}
