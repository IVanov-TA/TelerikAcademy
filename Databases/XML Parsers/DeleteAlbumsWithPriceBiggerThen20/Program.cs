namespace DeleteAlbumsWithPriceBiggerThen20
{
    using System;
    using System.Xml;
    using System.Collections.Generic;


    class Program
    {
        static void Main()
        {
            XmlDocument xml = new XmlDocument();
            xml.Load(@"..\..\catalogue.xml");

            var root = xml.DocumentElement;

            var nodesToDelete = new List<XmlNode>();

            foreach (XmlNode artist in root.ChildNodes)
            {
                foreach (XmlNode album in artist.ChildNodes)
                {
                    var currentAlbumValue = decimal.Parse(album["Price"].InnerText);

                    if (currentAlbumValue > 20)
                    {
                        artist.RemoveChild(album);
                    }
                }
            }


            xml.Save(@"..\..\catalogue-deleted.xml");
        }
    }
}
