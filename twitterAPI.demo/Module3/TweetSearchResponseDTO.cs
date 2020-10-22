using System;
using System.Collections.Generic;
using System.Text;

namespace twitterAPI.demo.Module3
{
    public class TweetSearchResponseDTO
    {
        public class Status
        {
            public string created_at { get; set; }
            public string id { get; set; }
            public string id_str { get; set; }
            public string text { get; set; }
            public bool truncated { get; set; }
            public Entities entities { get; set; }
            public Metadata metadata { get; set; }
            public string source { get; set; }
            public long? in_reply_to_status_id { get; set; }
            public string in_reply_to_status_id_str { get; set; }
            public long? in_reply_to_user_id { get; set; }
            public string in_reply_to_user_id_str { get; set; }
            public string in_reply_to_screen_name { get; set; }
            public User user { get; set; }
            public object geo { get; set; }
            public object coordinates { get; set; }
            public object contributors { get; set; }
            public bool is_quote_status { get; set; }
            public int retweet_count { get; set; }
            public int favorite_count { get; set; }
            public bool favorited { get; set; }
            public bool retweeted { get; set; }
            public string lang { get; set; }
            public bool? possibly_sensitive { get; set; }
            public long? quoted_status_id { get; set; }
            public string quoted_status_id_str { get; set; }
        }

        public class Entities
        {
            public IList<Hashtag> hashtags { get; set; }
            public IList<UserMention> user_mentions { get; set; }
            public IList<Url> urls { get; set; }
        }

        public class Hashtag
        {
            public string text { get; set; }
            public IList<int> indices { get; set; }
        }

        public class UserMention
        {
            public string screen_name { get; set; }
            public string name { get; set; }
            public object id { get; set; }
            public string id_str { get; set; }
            public IList<int> indices { get; set; }
        }

        public class Url
        {
            public string url { get; set; }
            public string expanded_url { get; set; }
            public string display_url { get; set; }
            public IList<int> indices { get; set; }
        }

        public class User
        {
            public object id { get; set; }
            public string id_str { get; set; }
            public string name { get; set; }
            public string screen_name { get; set; }
            public string location { get; set; }
            public string description { get; set; }
            public string url { get; set; }
            public Entities Entities { get; set; }
            public int followers_count { get; set; }
            public int friends_count { get; set; }
            public int listed_count { get; set; }
            public string created_at { get; set; }
            public int favourites_count { get; set; }
            public object utc_offset { get; set; }
            public object time_zone { get; set; }
            public bool geo_enabled { get; set; }
            public bool verified { get; set; }
            public int statuses_count { get; set; }
            public object lang { get; set; }
            public bool contributors_enabled { get; set; }
            public bool is_translator { get; set; }
            public bool is_translation_enabled { get; set; }
            public string profile_background_color { get; set; }
            public string profile_background_image_url { get; set; }
            public string profile_background_image_url_https { get; set; }
            public bool profile_background_tile { get; set; }
            public string profile_image_url { get; set; }
            public string profile_image_url_https { get; set; }
            public string profile_banner_url { get; set; }
            public string profile_link_color { get; set; }
            public string profile_sidebar_border_color { get; set; }
            public string profile_sidebar_fill_color { get; set; }
            public string profile_text_color { get; set; }
            public bool profile_use_background_image { get; set; }
            public bool has_extended_profile { get; set; }
            public bool default_profile { get; set; }
            public bool default_profile_image { get; set; }
            public object following { get; set; }
            public object follow_request_sent { get; set; }
            public object notifications { get; set; }
            public string translator_type { get; set; }
        }

        public class Metadata
        {
            public string iso_language_code { get; set; }
            public string result_type { get; set; }
        }

        public IList<Status> statuses { get; set; }

        public SearchMetadata search_metadata { get; set; }

        public class SearchMetadata
        {
            public double completed_in { get; set; }
            public long max_id { get; set; }
            public string max_id_str { get; set; }
            public string next_results { get; set; }
            public string query { get; set; }
            public string refresh_url { get; set; }
            public int count { get; set; }
            public int since_id { get; set; }
            public string since_id_str { get; set; }
        }
    }
}
