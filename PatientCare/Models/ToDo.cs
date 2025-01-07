using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientCare.Models
{
    internal class ToDo : BaseModel
    {
        public int OwnerId { get; set; }
        public int PatientId { get; set; }
        public string? ToDoName { get; set; }
        public string? ToDoDate { get; set; }
        public string? ToDoNote { get; set; }
    }
}
