namespace CommonLib.Classes
{

    public class Application
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Guid Status { get; set; }
        public Guid Department { get; set; }
        public Guid Executor { get; set; }
        public Guid Applicant { get; set; }
        public Guid Type { get; set; }
        public DateTime DateCreate { get; set; }
        public DateTime DateConfirm { get; set; }
        public DateTime DateClose { get; set; }


        public Application(string name, string description, Guid userId, Guid typeId)
        {
            Name = name;
            Description = description;
            //Status = Id Создана; // Id ApplicationStatus;
            Applicant = userId;
            DateCreate = DateTime.Now;
        }

        public Application()
        {
            //Status = Id Создана; // Id ApplicationStatus;
            DateCreate = DateTime.Now;
        }
    }
}
