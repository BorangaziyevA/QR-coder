using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;

namespace SecondWpf.lib
{
    public class Qr
    {
        
        static public void genQR(int size,string text)
        {
            var client = new RestClient("http://qrcoder.ru");

            var request = new RestRequest($"code/?{text}&{size}&0");

            var response =client.Execute(request) ;

            var result = response.Content;
            
        }
    }
}
