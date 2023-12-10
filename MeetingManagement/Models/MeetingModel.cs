using System;
using System.Collections.Generic;

namespace WindowsFormsApp1.Models
{
    public class MeetingModel 
    {
        public string CreateMeetingIdInformation { get; set; }
        public string Topic { get; set; }
        public string Content { get; set; }
        public List<string> Dates { get; set; }
        public string SecretKey { get; set; }
        public string AdminSecretKey { get; set; }
        public string DecidedDate { get; set; }
        public List<MeetingParticipant> MeetingParticipants { get; set; } = new List<MeetingParticipant>();
    }

    public class MeetingParticipant
    {
        public string FullName { get; set; }
        public string Date { get; set; }
    }
}
