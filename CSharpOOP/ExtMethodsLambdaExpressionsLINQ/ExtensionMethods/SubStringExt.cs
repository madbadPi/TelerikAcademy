namespace ExtensionMethods
{
    using System;
    using System.Text;

    public static class SubStringExt
    {
        //extension method Substring(int index, int length) 
        //for the class StringBuilder that returns new StringBuilder and
        //has the same functionality as Substring in the class String
        public static StringBuilder SubString(this StringBuilder originalString, int index, int length)
        {
            StringBuilder result = new StringBuilder();
            if (index < 0 || index  + length > originalString.Length || length < 0)
            {
                throw new ArgumentOutOfRangeException("Out of the range");
            }
            for (int i = index; i < index + length; i++)
			{
                result.Append(originalString[i]);
			}
            return result;
        }
    }
}
