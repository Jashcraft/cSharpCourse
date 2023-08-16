namespace Arrays
{
  class Program
  {
    static void Main(string[] args)
    {
      //declare and initialize
      int[] grades = new int[5];
      grades[0] = 20;
      grades[1] = 15;
      grades[2] = 30;
      grades[3] = 40;
      grades[4] = 15;

      int[] gradesOfStudentsA = { 20, 22, 76, 15, 30 };
      int[] gradesOfStudentsB = new int[] { 20, 22, 33 };

      Console.WriteLine("length of gradesOfStudentsA array is: {0}", gradesOfStudentsA.Length);

      SetGrades();

      Exit();
    }
    public static void Exit()
    {
      Console.WriteLine("Program will exit in 4 seconds...");
      System.Threading.Thread.Sleep(4000);
    }

    public static void SetGrades()
    {
      Console.WriteLine("Choose a student to update(1-5): ");
      string indexInput = Console.ReadLine();
      Console.WriteLine("Set grade for student(0-100): ");
      string gradeInput = Console.ReadLine();

      int selectedStudent = int.Parse(indexInput) - 1;
      int grade = int.Parse(gradeInput);


      Console.WriteLine("Student {0} now has a grade of {1}", selectedStudent, grade);
    }
  }
}