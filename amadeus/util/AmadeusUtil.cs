using System;
using System.Collections.Generic;

namespace amadeus.util
{
    /// <summary>
    /// Amadeus util class
    /// </summary>
    public class AmadeusUtil
    {
        /// <summary>
        /// Initializes a new instance of the AmadeusUtil class.
        /// </summary>
        public AmadeusUtil()
        {
        }

        /// <summary>
        /// Arraies to string generic.
        /// </summary>
        /// <returns>The to string generic.</returns>
        /// <param name="array">Array.</param>
        /// <param name="delimeter">Delimeter.</param>
        public static string ArrayToStringGeneric(Object[] array, string delimeter)
        {
            string outputString = "";

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] is Object[])
                {
                    //Recursively convert nested arrays to string
                    outputString += ArrayToStringGeneric((Object[])array[i], delimeter);
                }
                else
                {
                    outputString += array[i];
                }

                if (i != array.Length - 1)
                    outputString += delimeter;
            }

            return outputString;
        }
    }
}
