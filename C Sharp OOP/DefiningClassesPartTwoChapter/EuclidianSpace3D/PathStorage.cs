namespace EuclidianSpace3D
{
    using System;
    using System.IO;
    using System.Linq;

    public static class PathStorage
    {
        #region FIELDS

        private const string FileName = "data.txt";

        #endregion

        #region METHODS

        public static void SaveData(Path path)
        {
            var writeToFIle = new StreamWriter(FileName, false);

            using (writeToFIle)
            {
                writeToFIle.Write(path);
            }
        }

        public static Path LoadData()
        {
            Path loadedPath = new Path();
            var readFromFile = new StreamReader(FileName);

            using (readFromFile)
            {
                string currentLine = readFromFile.ReadLine();

                while (!string.IsNullOrEmpty(currentLine))
                {
                    currentLine = currentLine.Substring(currentLine.IndexOf(":") + 2);

                    int[] pointValues = currentLine.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                    loadedPath.AddPoint(pointValues[0], pointValues[1], pointValues[2]);

                    currentLine = readFromFile.ReadLine();
                }
            }

            return loadedPath;
        }

        #endregion
    }
}
