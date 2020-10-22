using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.IO;
using System.Net;
using System.Text;
using System.Web;
using twitterAPI.demo.Module3;

namespace twitterAPI.demo.Module2
{
    public class TwitterClient
    {
        string _consumerKey = string.Empty;
        string _consumerSecret = string.Empty;

        const string _UsersLookup = "https://api.twitter.com/1.1/users/lookup.json";

        public TwitterClient(string consumerKey, string consumerSecret)
        {
            _consumerKey = consumerKey;
            _consumerSecret = consumerSecret;
        }

        private string GetBearerToken()
        {
            // step 1:encode the consumer key and secret
            string bearerRequest =
                HttpUtility.UrlEncode(_consumerKey)
                + ":" + HttpUtility.UrlEncode(_consumerSecret);

            bearerRequest =
                Convert.ToBase64String(Encoding.UTF8.GetBytes(bearerRequest));

            // step 2: setup the request to obtain the Bearer Token from 
            //         the Twitter API using the key and secret
            WebRequest request =
                WebRequest.Create("https://api.twitter.com/oauth2/token");

            request.Headers.Add("Authorization", "Basic " + bearerRequest);
            request.Method = "POST";
            request.ContentType =
                "application/x-www-form-urlencoded;charset=UTF-8";

            // step 3: set the OAuth Grant Type. 
            // Using this Grant Type, we get a Bearer Token from Twitter if our 
            // Consumer Key and Secret are valid. 
            // (Twitter current only support "grant_type=Client_Credential)
            string grantType =
                "grant_type=client_credentials";
            byte[] requestContent = Encoding.UTF8.GetBytes(grantType);

            // fetch the stream
            Stream requestStream = request.GetRequestStream();
            requestStream.Write(requestContent, 0, requestContent.Length);
            requestStream.Close();

            string jsonResponse = string.Empty;

            // get the response
            HttpWebResponse response =
                (HttpWebResponse)request.GetResponse();

            if (response.StatusCode == HttpStatusCode.OK)
            {
                Stream responseStream = response.GetResponseStream();
                jsonResponse = new StreamReader(responseStream).ReadToEnd();
            }

            JObject jObject = JObject.Parse(jsonResponse);

            // return the bearer token
            return jObject["access_token"].ToString();
        }

        internal TweetSearchResponseDTO SearchForTweets(string query, int numberOfTweets, string language)
        {
            throw new NotImplementedException();
        }

        private string SendGET(string address)
        {
            WebRequest request = WebRequest.Create(address);

            request.Headers.Add("Authorization", "Bearer " + GetBearerToken());
            request.Method = "GET";
            request.ContentType = "application/x-www-form-urlencoded;charset=UTF-8";

            string responseJson = string.Empty;

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            if (response.StatusCode == HttpStatusCode.OK)
            {
                Stream responseStream = response.GetResponseStream();
                responseJson = new StreamReader(responseStream).ReadToEnd();

                return responseJson;
            }
            else
            {
                return "Error:" + response.StatusDescription;
            }
        }

        public string UserLookup(string username)
        {
            return SendGET(_UsersLookup + "?screen_name=" + username);
        }


    }

}

