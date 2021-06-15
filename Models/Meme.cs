using System;
using System.Collections.Generic;

namespace PracticaN4.Models
{
    public class Meme
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Foto {get;set;}
        public string UserID {get; set; }

        public DateTime FechaRegistro { get; set; }
        public ICollection<Comentario> Comentarios { get; set; } 

        public Meme(){
            FechaRegistro = DateTime.Now;
        }
    }
}