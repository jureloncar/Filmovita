using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Filmovita.Entity
{
    public class Review
    {
        public int Id { get; set; }
        public string? Reviews { get; set; }
        public int MovieId { get; set; }

        [NotMapped]
        [JsonIgnore]
        public Movie Movie { get; set; }
    }
}
 