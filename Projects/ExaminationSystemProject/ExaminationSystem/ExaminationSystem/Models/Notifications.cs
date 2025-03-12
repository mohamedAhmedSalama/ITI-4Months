using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem.Models
{
    public class Notifications
    {
        public int NotificationId { get; set; }
        public string Message { get; set; }
        public bool IsRead { get; set; }
        public DateTime NotificationDate { get; set; } = DateTime.Now;

        //Foreign Key
        public int? StudentId { get; set; }
        public Student Student { get; set; }

        public int? InstructorId { get; set; }
        public Instructor Instructor { get; set; }
    }
}
