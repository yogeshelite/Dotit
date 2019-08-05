using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpicorDaily.Service
{
    public class Util
    {

        public static T? GetEnum<T>(string value) where T : struct
        {
            T result;

            return Enum.TryParse<T>(value, out result) ? (T?)result : null;
        }

        public static List<T> EnumToList<T>() where T : struct
        {


            return Enum.GetValues(typeof(T)).OfType<T>().ToList();
        }


    }
}
