using Newtonsoft.Json;
using System.Net;
using System.Text.Json.Nodes;

namespace hometask_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string jsons;
            using (WebClient wc = new WebClient())
            {
               jsons = wc.DownloadString("https://jsonplaceholder.typicode.com/posts");
            }
            using(StreamWriter sw = new StreamWriter(@"C:\\Users\\samir\\Desktop\\codeAcademy\\backend\\hometask-13\\myJson.json"))
            {
                sw.Write(jsons);
            }
        }
    }
}