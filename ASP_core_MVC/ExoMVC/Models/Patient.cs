namespace ExoMVC.Models
{
    public class Patient
    {
        public string RegNat { get; }
        public string Lastname { get; }
        public string Firstname { get; }
        public string Phone { get; }
        public DateOnly BirthDate { get; }

        public Patient(string regNat, string lastname, string firstname, string phone, DateOnly birthDate)
        {
            RegNat = regNat;
            Lastname = lastname;
            Firstname = firstname;
            Phone = phone;
            BirthDate = birthDate;
        }
    }
}
