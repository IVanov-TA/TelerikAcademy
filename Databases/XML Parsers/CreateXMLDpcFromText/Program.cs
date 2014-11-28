namespace CreateXMLDocFromText
{
    using System;
    using System.Xml.Linq;
    using System.IO;

    class Program
    {
        static void Main()
        {
            StreamReader reader = new StreamReader(@"..\..\input.txt");

            using (reader)
            {
                XElement pesonXml = new XElement("data");
                var currentLine = reader.ReadLine();

                while (currentLine != null)
                {
                    var data = SeperateDataLine(currentLine);

                    pesonXml.Add(
                         new XElement("person",
                         new XElement("name", data[0]),
                         new XElement("address", data[1]),
                         new XElement("phoneNumber", data[2])
                 ));

                    currentLine = reader.ReadLine();
                }

                Console.WriteLine(pesonXml);

                pesonXml.Save(@"..\..\persons.xml");
            }

        }

        private static string[] SeperateDataLine(string currentLine)
        {
            var elements = currentLine.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            return elements;
        }
    }
}
