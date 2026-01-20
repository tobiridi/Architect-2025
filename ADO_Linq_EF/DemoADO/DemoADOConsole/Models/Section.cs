namespace DemoADOConsole.Models
{
    public class Section
    {
        public int ID { get; set; }
        public string SectionName { get; set; }

        public Section(int id, string sectionName)
        {
            this.ID = id;
            this.SectionName = sectionName;
        }

        public override string ToString()
        {
            return $"id : {this.ID} | name : {this.SectionName}";
        }
    }
}
