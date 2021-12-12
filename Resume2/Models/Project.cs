using System.ComponentModel.DataAnnotations;

namespace Resume2.Models
{
    public class Project
    {
        [Key]
        public string title { get; set; } 
        public string url { get; set; }
        public string description { get; set; }

       
        public override bool Equals(object? obj)
        {
            return obj is Project project &&
                   title == project.title &&
                   url == project.url &&
                   description == project.description;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(title, url, description);
        }
    }
}
