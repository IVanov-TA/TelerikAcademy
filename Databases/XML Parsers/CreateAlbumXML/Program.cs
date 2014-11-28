namespace CreateAlbumXML
{
    using System;
    using System.Text;
    using System.Xml;

    class Program
    {
        static void Main(string[] args)
        {
            string fileName = @"..\..\album.xml";
            Encoding encoding = Encoding.GetEncoding("windows-1251");
            XmlTextWriter writer = new XmlTextWriter(fileName, encoding);
            using (writer)
            {
                writer.WriteStartDocument();
                writer.Formatting = Formatting.Indented;
                writer.IndentChar = '\t';
                writer.Indentation = 1;
                writer.WriteStartElement("albums");
                string name = string.Empty;
                string artist = string.Empty;
                using (XmlReader reader = XmlReader.Create(@"..\..\catalogue.xml"))
                {
                    while (reader.Read())
                    {
                        if ((reader.NodeType == XmlNodeType.Element) &&
                        (reader.Name == "Album"))
                        {
                            name = reader.GetAttribute("name");
                            WriteBook(writer, name, artist);
                        }
                        else if ((reader.NodeType == XmlNodeType.Element) &&
                        (reader.Name == "Artist"))
                        {
                            artist = reader.GetAttribute("name");
                        }
                        
                    }
                }
                writer.WriteEndDocument();
                Console.WriteLine("Document {0} was created.", fileName);
            }
        }
        private static void WriteBook(XmlWriter writer, string name, string artist)
        {
            writer.WriteStartElement("album");
            writer.WriteElementString("name", name);
            writer.WriteElementString("artist", artist);
            writer.WriteEndElement();
        }
    }
}
