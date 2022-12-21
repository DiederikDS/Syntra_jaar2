using System.Text.Json;
using System.Text.Json.Serialization;
using System.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVC_Klas.Models
{
    public class Dierenarts
    {
        public int ID { get; set; }
        public string Naam{ get; set; }
        public string Adres { get; set; }   
        public string Gemeente { get; set;}

        [ForeignKey("Familie")]
        public int Specialiatie { get; set;}

        public override string ToString() {
           return JsonSerializer.Serialize<Dierenarts>(this);
        }
    }
}
