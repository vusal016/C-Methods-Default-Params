namespace Struct.record
{
    public class Student : IComparable
    {
        public Student(string name, string surname, int point)
        {
            Name = name;
            Surname = surname;
            Point = point;
            Id = _id++;
        }

        private static int _id = 0;
        public int Id { get; private set; }

        public string Name { get; set; }
        public string Surname { get; set; }
        public int Point { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            return $"{Id},{Name},{Surname},{Age},{Point}";
        }

        public int CompareTo(object? obj)
        {
            if (obj != null && obj is Student a)
            {
                return Point.CompareTo(a.Point);
            }
            throw new Exception("Xeta bas verdi");
        }

        public static bool operator >(Student a, Student b)
        {
            return a.Point > b.Point;
        }
        public static bool operator <(Student a, Student b)
        {
            return a.Point < b.Point;
        }



    }
}





