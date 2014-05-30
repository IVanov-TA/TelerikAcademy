namespace VersionAttributeTask
{
    using System;

    [AttributeUsage(AttributeTargets.Struct | AttributeTargets.Method |
    AttributeTargets.Class | AttributeTargets.Interface,
    AllowMultiple = false)]

    public class VersionAttribute : System.Attribute
    {
        public VersionAttribute(string version)
        {
            this.Version = version;
        }

        public string Version { get; private set; }
    }

    [Version("1.12")]
    public class Program
    {
       public static void Main()
        {
            Type type = typeof(Program);
            object[] allAttributes = type.GetCustomAttributes(false);
            foreach (VersionAttribute ver in allAttributes)
            {
                Console.WriteLine(ver.Version);
            }
        }
    }
}
