using CheckNS;
using LearningCSharp;
using System;
using System.Xml.Linq;
namespace CheckNS
{
    public partial class PersonType
    {
        public int ID { get; set; }
        public string? name { get; set; }

        public int[]? Scores { get; set; }
        public string Display()
        {
            return $"Name is {name}";
        }
        public string Addd()
        {
            return ID.ToString() + name;
        }
    }
}
public class ProgramXml
{
    static void Main(string[] args)
    {
        //PersonType person = new PersonType();
        //person.ID = 20;
        //person.name = "dd";
        //person.Scores = new int[] { 90, 80, 70 };


        ////Console.WriteLine(checker.Addd());


        //System.Xml.Serialization.XmlSerializer x = new System.Xml.Serialization.XmlSerializer(person.GetType());

        //x.Serialize(Console.Out, person);
        //Console.WriteLine();
        //Console.ReadLine();

        ExampleOfDelegate exampleOfDelegate = new ExampleOfDelegate();
        exampleOfDelegate.DelegateEx1();

    }
}

