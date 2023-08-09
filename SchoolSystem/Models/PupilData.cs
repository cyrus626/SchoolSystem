using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LiteDB;
namespace SchoolSystem.Models
{
    class PupilData
    {
        [BsonId(true)] public int Id { get; set; }
        public string FName { get; set; }
        public string MName { get; set; }
        public string LName { get; set; }
        public string Gemder { get; set; }
        public string Adress { get; set; }
        public string ContactNumber { get; set; }
        public string DOB { get; set; }
        public string PupilClass { get; set; }
        public Uri Passport { get; set; }
        public string PassportText {get; set; }
    }
}
