using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
using RestSharp.Deserializers;

namespace portfolioApi.Models
{
    public class Project
    {
        public string name { get; set; }
        public string starred_url { get; set; }
        public static List<Project> GetProjects()
        {
            var client = new RestClient("https://api.github.com/users/rouz1130/repos");
            var request = new RestRequest("",Method.GET);

        }
            

    }
}
