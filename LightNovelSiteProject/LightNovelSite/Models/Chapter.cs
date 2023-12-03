using System.ComponentModel.DataAnnotations;

namespace LightNovelSite.Models
{
    public class Chapter
    {
        [Key]
        public int Id { get; set; }
        public string NovelTitle { get; set; }
        public string ChapterTitle { get; set; }
        public int ChapterCount { get; set; }
        public string Content { get; set; }
    }
}
