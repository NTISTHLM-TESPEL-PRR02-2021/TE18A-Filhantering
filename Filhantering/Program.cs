using System;
using System.IO;
using System.Xml.Serialization;

namespace Filhantering
{
  class Program
  {
    static void Main(string[] args)
    {

      // Platform myPlatform = new Platform();

      // myPlatform.width = 10;
      // myPlatform.x = 5;
      // myPlatform.y = 2;
      // myPlatform.falling = true;

      // 10|5|2|1


      XmlSerializer serializer = new XmlSerializer(typeof(Platform));

      FileStream file = File.Open("platforms.xml", FileMode.OpenOrCreate);

      Platform myPlatform = (Platform) serializer.Deserialize(file);

      // serializer.Serialize(file, myPlatform);

      file.Close();

      System.Console.WriteLine(myPlatform.width);

      Console.ReadLine();

      // string[] nonsens = {"a", "b", "c"};

      // File.WriteAllLines(@"lines.txt", nonsens);

      

      // Directory.Delete("Hej");

      // string n = File.ReadAllText("test.txt");


      // System.Console.WriteLine(n);

      // Console.ReadLine();

      // string t = "Hello everybody!";
      
      // File.WriteAllText("test.txt", t);



    }
  }
}
