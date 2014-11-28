namespace CreateCatalogue
{
    using System;
    using System.Xml;

    internal class CatalogueCreatorEntryPoint
    {
        static Random random = new Random();
        static string[] artists = new string[] { "John Carter", "DJ Hummer", "SomeOneElse" };
        static string[] songs = new string[] { "Ne mi puka", "Mai mi e zle", "Sigurno sam se pobarkal", "Shto gi chetesh tiq raboti" };
        static string[] durations = new string[] { "2.33", "2.77", "44.43", "9.41" };
        static string[] prices = new string[] { "9.99", "6.99", "3.55", "18.99" };
        static string[] producers = new string[] { "Nqkoi si", "Nikoi si" };
        static string[] years = new string[] { "1999", "1898", "2011", "2222" };
        static string[] albumNames = new string[] {"Vechno omazan", "Kolko", "Nikoga" };

        internal static void Main()
        {
            XmlDocument xml = new XmlDocument();
            XmlNode root = xml.AppendChild(xml.CreateElement("Catalogue"));

            for (int i = 0; i < 3; i++)
            {
                var albumName = GenerateCustom(albumNames);
                var artistName = GenerateCustom(artists);
                var year = GenerateCustom(years);
                var producerName = GenerateCustom(producers);
                var price = GenerateCustom(prices);

                var album = AddAlbum(xml, root, albumName, artistName, year, producerName, price);
                AddSongs(xml, album["Songs"], songs, durations);
            }

            xml.Save(@"..\..\catalogue.xml");
        }

        private static XmlNode AddAlbum(XmlDocument xml, XmlNode root, string albumName, string artistName, string year, string producerName, string price)
        {
            XmlNode artist = root.AppendChild(xml.CreateElement("Artist"));
            XmlAttribute artistNameAttribute = artist.Attributes.Append(xml.CreateAttribute("name"));
            artistNameAttribute.InnerText = artistName;

            XmlNode album = AppendChild(xml, artist, "Album");
            XmlAttribute albumNameAttribute = album.Attributes.Append(xml.CreateAttribute("name"));
            albumNameAttribute.InnerText = albumName;

            XmlNode yearPromoted = AppendChild(xml, album, "Year");
            yearPromoted.InnerText = year;

            XmlNode producer = AppendChild(xml, album, "Producer");
            producer.InnerText = producerName;

            XmlNode priceNode = AppendChild(xml, album, "Price");
            priceNode.InnerText = price;

            XmlNode songs = AppendChild(xml, album, "Songs");
            return album;
        }

        private static void AddSongs(XmlDocument xml, XmlNode album, string[] songs, string[] durations)
        {
            var countOfSoungToBeAdded = random.Next(1, 12);

            for (int i = 0; i < countOfSoungToBeAdded; i++)
            {
                var songTitle = GenerateCustom(songs);
                var durationValue = GenerateCustom(durations);

                XmlNode currentSong = album.AppendChild(xml.CreateElement("Song"));
                XmlNode title = currentSong.AppendChild(xml.CreateElement("Title"));
                XmlNode duration = currentSong.AppendChild(xml.CreateElement("Duration"));

                title.InnerText = songTitle;
                duration.InnerText = durationValue;
            }
                         
        }

        private static XmlNode AppendChild(XmlDocument xml, XmlNode artist, string name)
        {
            var childToReturn = artist.AppendChild(xml.CreateElement(name));
            return childToReturn;
        }

        private static string GenerateCustom(string[] collection)
        {
            return collection[random.Next(0, collection.Length)];
        }
    }
}
