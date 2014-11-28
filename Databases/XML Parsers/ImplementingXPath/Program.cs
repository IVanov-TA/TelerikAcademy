namespace ImplementingXPath
{
    using System;
    using System.Collections.Generic;
    using System.Xml;
    using System.Xml.XPath;

    internal class Program
    {
        internal static void Main()
        {
            XmlDocument xml = new XmlDocument();
            xml.Load(@"..\..\catalogue.xml");

            var xPathQuery = "/Catalogue/Artist";

            XmlNodeList artistList = xml.SelectNodes(xPathQuery);

            var result = new Dictionary<string, int>();

            foreach (XmlNode artist in artistList)
            {
                var artistName = artist.Attributes["name"].Value;
                var albumsCount = artist.ChildNodes.Count;

                if (!result.ContainsKey(artistName))
                {
                    result.Add(artistName, albumsCount);
                }
            }

            foreach (var entity in result)
            {
                Console.WriteLine("artist name : {0} -> albumCount:{1}", entity.Key, entity.Value);
            }
        }
    }
}
