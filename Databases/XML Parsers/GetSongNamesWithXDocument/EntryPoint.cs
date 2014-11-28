namespace GetSongNamesWithXDocument
{
    using System;
    using System.Linq;
    using System.Xml.Linq;

    class EntryPoint
    {
        static void Main()
        {
            XDocument xmlDoc = XDocument.Load(@"..\..\catalogue.xml");

            var allSongNames =
                from song in xmlDoc.Descendants("Song")
                select new
                {
                    Title = song.Element("Title").Value
                };

            foreach (var item in allSongNames)
            {
                Console.WriteLine(item.Title);
            }
        }
    }
}
