
namespace Nekos.moe
{
    public class RandomOption
    {
        public NSFW NSFW;
        public int Count;

        public RandomOption(int Count, NSFW type)
        {
            this.Count = Count;
            this.NSFW = type;
        }
    }
}