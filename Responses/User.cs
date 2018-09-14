using Newtonsoft.Json;

namespace Nekos.moe
{
    public class User
    {
        [JsonProperty("username")]
        public string Username;

        [JsonProperty("id")]
        public string ID;
    }
}