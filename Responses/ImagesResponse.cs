using System.Collections.Generic;
using Newtonsoft.Json;

namespace Nekos.moe
{
    public class ImagesResponse
    {
        [JsonProperty("images")]
        public List<NekoImage> Images = new List<NekoImage>();
    }
}