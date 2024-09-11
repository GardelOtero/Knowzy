using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KwonzyClases.Models
{
    public class Questions
    {
        public int Id { get; set; }
        public int GameId { get; set; }
        public string Title { get; set; }
        public int Points { get; set; }
        public string? Image { get; set; }
        public List<QuestionOptions> Options { get; set; }


    }
}
