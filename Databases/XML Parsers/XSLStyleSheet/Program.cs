namespace XSLStyleSheet
{
    using System;
    using System.Xml.Xsl;

    class Program
    {
        static void Main(string[] args)
        {
            XslCompiledTransform xslt = new XslCompiledTransform();
            xslt.Load("../../Catalogue.xslt");
            xslt.Transform("../../catalogue.xml", "../../catalogue.html");
        }
    }
}
