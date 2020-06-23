using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Common
{
    public class UtilText
    {

        public static string removeQuotes(string s)
        {
            string sRes = s.Replace("\"", "");
            return sRes;
        }

        public static string removeAllSpaces(string s)
        {
            string sRes = s.Replace(" ", "");
            return sRes;
        }

        public static string removeAdditionalSpaces(string s)
        {
            string sRes = "";
            Regex trimmer = new Regex(@"\s\s+");
            sRes = trimmer.Replace(s, " ");
            return sRes;
        }

        public static int numOccurrencesOfChar(string s, string sChar)
        {
            int n = 0;
            for (int i = 0; i <= s.Length - 1; i++)
            {
                if (s.Substring(i, 1) == sChar)
                {
                    n++;
                }
            }
            return n;
        }

        public static bool AtLeastOneLetter(string s)
        {
            Regex rg = new Regex(@"\w*[a-zA-Z]\w*");
            return rg.IsMatch(s);
        }

        public static bool ListContainsChar(List<string> L, string sChar)
        {
            bool b = false; 
            IEnumerable<string> results = L.Where(s => s == sChar);
            if (results.ToList().Count > 0)
            {
                b = true;
            }
            return b;
        }


        public static bool RepeatedItemsInList(List<string> L)
        {
            var query = L.GroupBy(x => x)
                .Where(g => g.Count() > 1)
                .Select(y => y.Key)
                .ToList();
            return (query.Count > 0);
        }

        public static List<string> SplitSpaces(string s)
        {
            string[] Arr = s.Split(' ');
            return Arr.ToList();
        }

        public static bool ListWithoutItemsOrNull(List<string> L, ref string msgErr)
        {
            bool b = false;
            if (L == null || L.Count == 0)
            {
                b = true;
                msgErr = "List null or without items";
            }
            return b;
        }

        public static string StringSeparator(List<string> LisElms, string Separator)
        {
            string s = "";
            foreach (string it in LisElms)
            {
                s = s + Separator + it;
            }
            return s;
        }

        public static string Line(string s)
        {
            return s + Environment.NewLine;
        }

        public static string CaptionValue(string sCap, string sVal)
        {
            return sCap + ": " + sVal;
        }

    }
}
