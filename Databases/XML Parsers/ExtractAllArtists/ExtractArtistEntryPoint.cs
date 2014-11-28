namespace ExtractAllArtists
{
    using System;
    using System.Xml;
    using System.Collections.Generic;

    internal class ExtractArtistEntryPoint
    {
        internal static void Main()
        {
            XmlDocument xml = new XmlDocument();
            try
            {
                xml.Load(@"..\..\catalogue.xml");

                XmlNode root = xml.DocumentElement;
                Console.WriteLine("Document with root node {0}.xml is loaded", root.Name);

                var result = new Dictionary<string, int>();

                foreach (XmlNode artist in root.ChildNodes)
                {
                   var artistName = artist.Attributes["name"].Value;
                   var albumCount = artist.ChildNodes.Count;

                   if (!result.ContainsKey(artistName))
                   {
                       result.Add(artistName, albumCount);
                   }
                }

                foreach (var entity in result)
                {
                    Console.WriteLine("artist name : {0} -> albumCount:{1}", entity.Key, entity.Value);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error occured: {0}", e.Message);
            }
           
        }
    }
}
