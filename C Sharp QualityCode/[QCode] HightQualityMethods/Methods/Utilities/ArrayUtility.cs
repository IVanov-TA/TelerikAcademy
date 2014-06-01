namespace Methods.Utilities
{
    using System;

   public static class ArrayUtility
    {
       private const string ArrayElementsNullException = "Elements collection cannot be null";
       private const string ArrayNoElementsException = "Array contains no elements";

        public static int FindMax(params int[] elements)
        {
            if (elements == null)
            {
                throw new ArgumentNullException(ArrayElementsNullException);
            }

            if (elements.Length == 0)
            {
                throw new ArgumentException(ArrayNoElementsException);
            }

            int maxElement = elements[0];

            for (int i = 1; i < elements.Length; i++)
            {
                if (maxElement < elements[i])
                {
                    maxElement = elements[i];
                }
            }

            return maxElement;
        }
    }
}
