namespace KeyTools.Classes
{
    public class NotUsedImage : ResultItem
    {
        public string SvgLink => svgLink;
        public string PngLink => pngLink;

        private string svgLink;
        private string pngLink;
        
        public NotUsedImage(string id, string svgLink, string pngLink) : base(id)
        {
            this.svgLink = svgLink;
            this.pngLink = pngLink;
        }
    }
}