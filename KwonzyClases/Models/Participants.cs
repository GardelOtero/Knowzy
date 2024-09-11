using KwonzyClases.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KwonzyClases.Models
{
    public class Participants
    {
        public int Id { get; set; }
        public int GameId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public Game Game { get; set; }

    }
}
