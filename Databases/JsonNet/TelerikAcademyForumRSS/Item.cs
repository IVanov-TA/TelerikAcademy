namespace TelerikAcademyForumRSS
{
    using Newtonsoft.Json;
    using System;

    public class Item
    {
        [JsonProperty(PropertyName = "title")]
        public string Title { get; set; }

        [JsonProperty(PropertyName = "link")]
        public string Link { get; set; }

        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        [JsonProperty(PropertyName = "category")]
        public string Category { get; set; }

        [JsonProperty(PropertyName = "pubDate")]
        public DateTime PubDate { get; set; }

        public override string ToString()
        {
            return string.Format("Title: {0}\nLink: {1}\nDescription: {2}\nCategory: {3}\nPublish Date: {4}\n{5}",
                this.Title, this.Link, this.Description, this.Category, this.PubDate, new string('-', Console.WindowWidth));
        }
    }
}
