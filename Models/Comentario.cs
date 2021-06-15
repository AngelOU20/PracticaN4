using System.Collections.Generic;
namespace PracticaN4.Models
{
    public class Comentario
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public string Comentarios {get; set;}

        public Meme Memes{get; set;}
        public int MemeId { get; set; }
    }
}