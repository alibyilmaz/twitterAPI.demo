using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

using System;
using twitterAPI.demo.Module2;

namespace twitterAPI.demo.Module2
{
    class Program
    {
        static void Main(string[] args)
        {
            string _ConsumerKey =
                   "1fba23y2C0iV6elj2pPavdKid";
            string _ConsumerSecret =
                "aGXkCSZWbHILwJHrXR6kfQ7T6aetcHgGJbGWY4tnJCCo0fz33D";

            TwitterClient twitterClient =
               new TwitterClient(_ConsumerKey, _ConsumerSecret);

            string userJson = twitterClient.UserLookup("saidkilinc8");

            string jsonFormatted =
               JValue.Parse(userJson).ToString(Formatting.Indented);

            Console.WriteLine(jsonFormatted);
        }

    }
}