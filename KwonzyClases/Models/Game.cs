using KwonzyClases.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KwonzyClases.Modelos
{
    public class Game
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime EventDay { get; set; }
        public DateTime LastDayToAnswer { get; set; }
        public bool IsMultipleDays { get; set; } = false;
        public DateTime EventStart { get; set; }
        public DateTime EventEnd { get; set; }
        public List<Questions> Questions { get; set; }
        public int CountParticipants { get; set; }
        public string Link { get; set; }
        public List<Participants> Participants { get; set; }
        //public string QR { get; set; } It's the same of the Link
    }
}
