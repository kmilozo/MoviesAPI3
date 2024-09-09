namespace MoviesAPI3.Models
{
    public class Review : NameEntity
    {
        public int MovieId { get; set; }  // Relación con Movie
        public string Title { get; set; }
        public string ReviewerName { get; set; }
        public string Comment { get; set; }
        public int Rating { get; set; }  // Por ejemplo, de 1 a 5 estrellas
        public DateTime ReviewDate { get; set; }
    }
}

