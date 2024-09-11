using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KwonzyClases.Models
{
    public class QuestionOptions
    {
        public int Id { get; set; }
        public int QuestionId { get; set; }
        public int Order {  get; set; }
        public string Title { get; set; }
        public string? Image {  get; set; }
        public bool IsCorrect { get; set; } = false;
    }
}
