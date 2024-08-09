namespace HospitalApp.Entities
{
    public class Doctor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Experience { get; set; }
        public Department Department { get; set; }
        public int DepartmentId { get; set; }

    }
}
