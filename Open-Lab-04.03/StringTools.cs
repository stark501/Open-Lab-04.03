using System;

namespace Open_Lab_04._03
{
    public class StringTools
    {
        public string RemoveFirstLast(string original)
        {
            if (original == "")
            {
                return "";
            }
            else
            {
                if (original.Length <= 1)
                {
                    return original.Substring(0, 1);

                }
                else
                {
                    return original.Substring(1, original.Length - 2);
                }
            }
        }
    }
}
