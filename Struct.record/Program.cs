namespace Struct.record
{
    public class Program
    {
        static void Main(string[] args)
        {
            Student[] stu1 = new Student[]
            {
            new Student("Ali", "Veliyev", 12),
            new Student("Osman", "Veliyev", 17),
            new Student("Teymur", "Veliyev", 179),
            new Student("Alibaba", "Veliyev", 1)
            };
            Group grup = new Group();
            foreach (var item in stu1)
            {
                grup.AddStudent(item);
            }
            Student[] sort = grup.GetAllStudents();
            foreach (var item in sort)
            {
                Console.WriteLine(item);

            }
           Student[]sorted= grup.Sort();
            foreach (var item in sorted)
            {
                Console.WriteLine(item);
            }

            Group grup2 = new Group();

        }
    }
}





