using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using Newtonsoft.Json;
using System.IO;

namespace BE
{
    public class GoogleEngine : SearchEngine
    {
        public GoogleEngine(string engNam, List<string> listItems) : base(engNam, listItems)
        {
           
        }

        public class Resultado
        {
            public string Title { get; set; }
            public string Link { get; set; }
            public string Snippet { get; set; }
            public string Source { get; set; }
            public string Query { get; set; }
            public int Index { get; set; }
        }

        // Google API returns only 10 searchs, so I am mockung resultas with a random function
        // But I include the code to access the Google API
        public int ResultsOfSearch(string cad)
        {
            string cx = "018250539026373314618:e_kun6fsucw";
            string apikey = "AIzaSyCCb4_nsjdNDeXK6AC5ZUs0t5TETkSX6jk";
            var request = WebRequest.Create("https://www.googleapis.com/customsearch/v1?key=" + apikey + "&cx=" + cx + "&q=" + cad);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            Stream dataStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(dataStream);
            string ResposeString = reader.ReadToEnd();
            dynamic JsonData = JsonConvert.DeserializeObject(ResposeString);

            var results = new List<Resultado>();
            foreach (var item in JsonData.items)
            {
                results.Add(new Resultado { Title = item.title, Link = item.link, Snippet = item.snippet }
                    );
            }
            List<Resultado> Lr = results.ToList();
            return Lr.Count;
        }
    }
}
