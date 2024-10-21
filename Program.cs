class Program
{
    static void Main(string[] args)
    {
        Student student1 = new Student("Taceddin", "Esedzade");

        Student student2 = new Student("Allahverdi", "Sultanov");

        Student student3 = new Student("Nicat", "Sahbazov");

        Group group1 = new Group("BP217", 3);

        group1.AddStudent();

        group1.AddStudent();

        group1.AddStudent();

        group1.DisplayGroupInfo();

        group1.ShowAllStudents();
    }
}