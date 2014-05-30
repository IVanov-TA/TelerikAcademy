namespace SubstringExtensionMethod
{
    using System;
    using System.Text;

    public static class Substring
    {
        public static StringBuilder SubstringBuilder(this StringBuilder str, int index, int lenght)
        {
            if ((index < 0 || index >= str.Length) || index + lenght >= str.Length)
            {
                throw new IndexOutOfRangeException("Index out of Range");
            }

            StringBuilder result = new StringBuilder();
            result.Append(str.ToString().Substring(index, lenght));
            return result;
        }

        public static StringBuilder SubstringBuilder(this StringBuilder str, int index)
        {
            if (index >= str.Length || index < 0)
            {
                throw new IndexOutOfRangeException("Index out of Range");
            }

            StringBuilder result = new StringBuilder();
            result.Append(str.ToString().Substring(index));
            return result;
        }
    }
}
