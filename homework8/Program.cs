namespace homework8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student myStudent = new Student();

            myStudent.Id = 101;
            myStudent.FirstName = "Nika";
            myStudent.LastName = "Gelashvili";
            myStudent.Age = 20;
            myStudent.Gpa = 91.5;
            myStudent.Course = 2;
            myStudent.Email = "nika@gmail.com";
            myStudent.PhoneNumber = "599112233";
            myStudent.Faculty = "Informatika";
            myStudent.IsActive = true;

            myStudent.PrintInfo();

        }
    }
}
