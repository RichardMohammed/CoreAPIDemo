﻿namespace CoreAPIDemo.Models
{
    public class PatientModel
    {
        public int Id { get; set; }
        public SurgeryModel Surgery { get; set; }
        public long SurgeryId { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Email { get; set; }
    }
}
