namespace Struct.record
{
    public class Group
    {
        private static int _no = 101;

        public Group()
        {
            No = "AP" + _no++;
        }

        public string No { get; private set; }
        private Student[] array = new Student[0];
        public void AddStudent(Student a)
        {
            Array.Resize(ref array, array.Length + 1);
            array[array.Length - 1] = a;
        }
        public Student[] GetAllStudents()
        {
            return array;
        }
        public Student[] Sort()
        {
            Student[] arclon = (Student[])array.Clone();
            Array.Sort(arclon);
            return arclon;
        }
    }

}


