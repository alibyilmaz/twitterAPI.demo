using System;
using System.Collections.Generic;
using System.Text;
using twitterAPI.demo.Module2;

using static twitterAPI.demo.Module3.TweetSearchResponseDTO;

namespace twitterAPI.demo.Module3
{
   public class Program
    {
        static void InvokeSearch(string query, int numberOfTweets,
                               string language)
        {
            string consumerKey =
                  "1fba23y2C0iV6elj2pPavdKid";
            string consumerSecret =
                "aGXkCSZWbHILwJHrXR6kfQ7T6aetcHgGJbGWY4tnJCCo0fz33D";
            TwitterClient twitterClient =
                new TwitterClient(consumerKey, consumerSecret);

            TweetSearchResponseDTO responseDTOs =
                twitterClient.SearchForTweets(query, numberOfTweets, language);

            foreach (Status status in responseDTOs.statuses)
            {
                Console.WriteLine("ID:" + status.id_str
                                   + ". Text:"
                                   + status.text);
            }
        }


        static void Main(string[] args)
        {
            InvokeSearch("fenerbahçe", 1, "tr");
            Console.WriteLine(Environment.NewLine);

            InvokeSearch("@fenerbahçe", 1, "tr");
            Console.WriteLine(Environment.NewLine);

            InvokeSearch("@fenerbahce", 1, "tr");
            Console.WriteLine(Environment.NewLine);
            Console.ReadLine();
        }
    }
}
