namespace DirectoryTravers
{
    using System;
    using System.IO;
    using System.Text;
    using System.Xml;
    using System.Xml.Linq;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            string folderLocation = "../../";
            string outpitFile = "../../directory.xml";
            DirectoryInfo dir = new DirectoryInfo(folderLocation);
            Encoding encoding = Encoding.GetEncoding("windows-1251");
            using (XmlTextWriter writer = new XmlTextWriter(outpitFile, encoding))
            {
                writer.Formatting = Formatting.Indented;
                writer.IndentChar = '\t';
                writer.Indentation = 1;
                writer.WriteStartDocument();
                writer.WriteStartElement("directories");
                CreateXML(writer, dir);
                writer.WriteEndDocument();
            }
            Console.WriteLine("Document {0} created.", outpitFile);
            Console.Read();
        }
        private static void CreateXML(XmlTextWriter writer, DirectoryInfo dir)
        {
            //get all the files first
            foreach (var file in dir.GetFiles())
            {
                string xml = new XElement("file", new XAttribute("name", file.Name)).ToString();
                XmlReader reader = XmlReader.Create(new StringReader(xml));
                writer.WriteNode(reader, true);
            }
            //get subdirectories
            var subdirectories = dir.GetDirectories().ToList().OrderBy(d => d.Name);
            foreach (var subDir in subdirectories)
            {
                CreateSubdirectoryXML(writer, subDir);
            }
        }
        private static void CreateSubdirectoryXML(XmlTextWriter writer, DirectoryInfo dir)
        {
            //get directories
            string xml = new XElement("dir", new XAttribute("name", dir.Name)).ToString();
            XmlReader reader = XmlReader.Create(new StringReader(xml));
            writer.WriteNode(reader, true);
            //get all the files first
            foreach (var file in dir.GetFiles())
            {
                xml = new XElement("file", new XAttribute("name", file.Name)).ToString();
                reader = XmlReader.Create(new StringReader(xml));
                writer.WriteNode(reader, true);
            }
            //get subdirectories
            var subdirectories = dir.GetDirectories().ToList().OrderBy(d => d.Name);
            foreach (var subDir in subdirectories)
            {
                CreateSubdirectoryXML(writer, subDir);
            }
        }
    }
}
