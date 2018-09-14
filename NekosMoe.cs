using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Nekos.moe
{

    public class NekosClient
    {
        private string BaseUrl = "https://nekos.moe/api/";
        public readonly string Version = "v1";

        public NekosClient()
        {

        }

        public async Task<List<NekoImage>> GetImageAsync(string ID)
        {
            List<NekoImage> Response = await GetNekoImage($"images/{ID}");
            return Response;
        }

        public async Task<List<NekoImage>> GetRandomImageAsync(RandomOption Option = null)
        {
            string Url = "random/image";
            if(Option != null)
            {
                int C = 0;
                if(Option.Count > 100)
                    C = 100;
                else if (Option.Count < 1)
                    C = 1;
                else C = Option.Count;
                Url += $"?count={C}";
                switch (Option.NSFW)
                {
                    case NSFW.With:
                    Url += "&nsfw=true";
                    break;
                    case NSFW.Without:
                    Url += "&nsfw=false";
                    break;
                }
            }
            List<NekoImage> Response = await GetNekoImage(Url);
            return Response;
        }

        public async Task<List<NekoImage>> SearchImage(SearchOption Option)
        {
            var Data = await GetNekoImage(Option.GenerateUrl());
            return Data;
        }

        private async Task<List<NekoImage>> GetNekoImage(string Path)
        {
            Console.WriteLine(Path);
            HttpClient Client = new HttpClient();
            string Data = await Client.GetStringAsync($"{BaseUrl}{Version}/{Path}");
            return JsonConvert.DeserializeObject<ImagesResponse>(Data).Images;
        }

    }

}
