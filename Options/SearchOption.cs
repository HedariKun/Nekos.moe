
namespace Nekos.moe
{
    public class SearchOption
    {
        public string ID;
        public NSFW NSFW;
        public string UploaderID;
        public string Artist;
        public Sort Sort;
        public int Limit = 1;

        public string GenerateUrl()
        {
            string Url = "images/search?";
            if(this.ID != null)
                Url += $"id={ID}&";

            if(this.UploaderID != null)
                Url += $"uploader={UploaderID}&";

            if(this.Artist != null)
                Url += $"artist={Artist}&";
            
                Url += $"limit={Limit}&";

            switch (NSFW)
            {
                case NSFW.With:
                Url += "nsfw=true";
                break;

                case NSFW.Without:
                Url += "nsfw=false";
                break;
            }

            switch (Sort)
            {
                case Sort.Newest:
                Url += "sort=newest";
                break;
                case Sort.Likes:
                Url += "sort=likes";
                break;
                case Sort.Oldest:
                Url += "sort=oldest";
                break;
                case Sort.Relevance:
                Url += "sort=relevance";
                break;
            }
            if(Url[Url.Length-1] == '&')
                Url = Url.Remove(Url.Length-1);
            return Url;
        }
    }
}