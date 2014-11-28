namespace ExtractAllSongTitlesWithXMLReader
{
    using System;
    using System.Xml;
    using System.Collections.Generic;

    class Program
    {
        static void Main()
        {
            var songTitles = new List<string>();

            using (XmlReader reader = XmlReader.Create("../../catalogue.xml"))
            {
                while (reader.Read())
                {
                    if ((reader.NodeType == XmlNodeType.Element) && (reader.Name == "Title"))
                    {
                        songTitles.Add(reader.ReadElementString());
                    }
                }
            }

            foreach (var title in songTitles)
            {
                Console.WriteLine(title);
            }
        }
    }
}
