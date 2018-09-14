using System.Text;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Nekos.moe
{
    public class NekoImage
    {
        [JsonProperty("id")]
        public string ID;

        [JsonProperty("originalHash")]
        public string OriginalHash;

        [JsonProperty("uploader")]
        public User Uploader;

        [JsonProperty("approver")]
        public User Approver;

        [JsonProperty("artist")]
        public string Artist;

        [JsonProperty("comments")]
        public List<string> Comments = new List<string>();

        [JsonProperty("favorites")]
        public int Favorites;

        [JsonProperty("likes")]
        public int Likes;

        [JsonProperty("tags")]
        public List<string> Tags = new List<string>();

        [JsonProperty("nsfw")]
        public bool Nsfw;

        [JsonProperty("createdAt")]
        public string CreatedAt;

        public string GetUrl()
        {
            return $"https://nekos.moe/image/{ID}.jpg";
        }

    }
}