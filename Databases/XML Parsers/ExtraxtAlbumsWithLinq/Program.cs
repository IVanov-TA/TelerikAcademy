namespace ExtraxtAlbumsWithLinq
{
    using System;
    using System.Xml.Linq;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {

            string fileLocation = @"..\..\catalogue.xml";
            XDocument xmlDoc = XDocument.Load(fileLocation);
            XName albumTitle = "name";
            int currentYear = DateTime.Now.Year;
            var albums =
            from album in xmlDoc.Descendants("Album")
            where ((currentYear - int.Parse(album.Element("Year").Value)) <= 5)
            select new
            {
                Title = album.Attribute(albumTitle).Value,
                Year = int.Parse(album.Element("Year").Value),
                Price = album.Element("Price").Value
            };

            foreach (var album in albums)
            {
                Console.WriteLine("{0}: {1}y :${2}\n", album.Title, album.Year, album.Price);
            }
        }
    }
}
