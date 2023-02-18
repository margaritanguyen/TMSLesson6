namespace TMSLesson6
{
    public class Patient
    {
        public TreatmentPlan Plan { get; set; }

        public Patient(int treatmentCodeInit)
        {
            Plan = new TreatmentPlan(treatmentCodeInit);
        }

        public void SelectDoctor()
        {
            int treatmentCode = Plan.Code;

            switch (treatmentCode)
            {
                case 1:
                    Surgeon surgeon = new Surgeon();
                    surgeon.Treat();
                    break;
                case 2:
                    Dentist dentist = new Dentist();
                    dentist.Treat();
                    break;
                default: 
                    Therapist therapist = new Therapist();
                    therapist.Treat();
                    break;
            }
        }
    }
}
