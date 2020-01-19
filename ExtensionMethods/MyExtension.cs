using System;
using System.Collections.Generic;
using System.Text;

namespace ExtensionMethods
{
    public static class MyExtension // třída pro extension metody musí být statická
    {
        /// <summary>
        /// Extension metoda pro zjištění zda seznam obsahuje sudý počet položek
        /// </summary>
        /// <typeparam name="T">Typ prvků v seznamu</typeparam>
        /// <param name="col">Seznam nad kterým se metoda volá (slovo this umožňuje volání ve tvaru list.metoda())</param>
        /// <returns>true nebo false</returns>
        public static bool IsCountEven<T>(this List<T> list) // metoda opět musí být statická
        {
            return (list.Count % 2 == 0);
        }

        /// <summary>
        /// Extension metoda vracející prvky seznamu řetězců, které jsou delší než daný počet znaků.
        /// </summary>
        /// <param name="list">Seznam nad kterým se metoda volá</param>
        /// <param name="limit">Délka řetězců</param>
        /// <returns>Seznam řetězců vyhovujících podmínce</returns>
        public static List<string> ShorterThen(this List<string> list, int limit)
        {
            List<string> result = new List<string>();
            foreach (var item in list)
            {
                if (item.Length < limit)
                    result.Add(item);
            }
            return result;
        }

        /// <summary>
        /// Extension metoda vracející prvky seznamu T, které jsou na sudých indexech (kde 0 je sudé číslo).
        /// </summary>
        /// <typeparam name="T">Typ prvků v seznamu</typeparam>
        /// <param name="list">Seznam nad kterým se metoda volá</param>
        /// <returns>Seznam řetězců vyhovujících podmínce</returns>
        public static List<T> Even<T>(this List<T> list)
        {
            List<T> result = new List<T>();
            for (int i = 0; i < list.Count; i++)
            {
                if (i % 2 == 0) result.Add(list[i]);
            }
            return result;
        }

        /// <summary>
        /// Extension metoda vracející prvky seznamu řetězců, které splňují danou podmínku (jako Where z LINQ).
        /// </summary>
        /// <typeparam name="T">Typ prvků v seznamu</typeparam>
        /// <param name="list">Seznam nad kterým se metoda volá</param>
        /// <param name="cond">Podmínka</param>
        /// <returns>Seznam řetězců vyhovujících podmínce</returns>
        public static List<T> Condition<T>(this List<T> list, Predicate<T> cond)
        {
            List<T> result = new List<T>();
            for (int i = 0; i < list.Count; i++)
            {
                if (cond(list[i])) result.Add(list[i]);
            }
            return result;
        }

        // Standardní delegáty:
        // Func - vrací generický typ
        // https://docs.microsoft.com/cs-cz/dotnet/api/system.func-1?view=netcore-3.1
        // Action - nic nevrací
        // https://docs.microsoft.com/cs-cz/dotnet/api/system.action?view=netcore-3.1
        // Predicate - vrací true/false
        // https://docs.microsoft.com/cs-cz/dotnet/api/system.predicate-1?view=netcore-3.1
    }
}
