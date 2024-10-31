namespace LeloProject.Models
{
    public class Claim
    {
        public int claimID { get; set; }

        public int Sessions { get; set; }

        public DateTime DateSubmitted { get; set; }


        //Approved, Pending, Submitted

        enum Status
        {
            Approved, Pending, Submitted
        }

        public int HoursWorked { get; set; }

        public decimal HourlyRate { get; set; }

        public string Notes { get; set; } = null;


        public Lecturer Lecturer { get; set; }
        public List<ProgrammeCoordinator> Programmes { get; set; }

        public AcademicManager AcademicManager { get; set; }

        





    }
}
