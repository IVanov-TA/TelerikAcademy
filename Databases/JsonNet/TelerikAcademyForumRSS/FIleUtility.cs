namespace TelerikAcademyForumRSS
{
    using System;
    using System.IO;
    using System.Text;

    public static class FIleUtility
    {
        public static void CreateFile(string file, string path)
        {
            using (FileStream fs = new FileStream(path, FileMode.Create))
            {
                using (StreamWriter writer = new StreamWriter(fs, Encoding.UTF8))
                {
                    writer.WriteLine(file);
                }
            }
        }
    }
}
