using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Initializer_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //ObjectInitialzer();
            //InitializerAnonymousType();
            CollectionInitializer();

            Console.ReadLine();

        }

        private static void ObjectInitialzer()
        {
            var student1 = new StudentName("MeiMei", "Wang");
            var student2 = new StudentName { FirstName = "MeiMei", LastName = "Wang" };
            var student3 = new StudentName { ID = 100 };
            var student4 = new StudentName("Lei", "Li") { ID = 101 };

            Console.WriteLine(student1.ToString());
            Console.WriteLine(student2.ToString());
            Console.WriteLine(student3.ToString());
            Console.WriteLine(student4.ToString());
        }

        private static void InitializerAnonymousType() {
            var pet = new { Age = 10, Name = "MiaoMiao" };
            var students = new List<StudentName> { new StudentName("Li", "LI"), new StudentName("Mei", "MEI") };
            var studentForm = new List<StudentFrom> {
                new StudentFrom{ FirstName = "Li",City = "Beijing"},
                new StudentFrom{ FirstName = "Mei",City = "Shanghai"}
            };
            var joinquery = from s in students
                            join f in studentForm on s.FirstName equals f.FirstName
                            select new { FirstName = s.FirstName, LastName = s.LastName, City = f.City };

            foreach (var j in joinquery)
            {
                Console.WriteLine("{0} {1} {2}", j.FirstName, j.LastName, j.City);
            }
        }

        private static void CollectionInitializer() {
            var students = new List<StudentName> {
                new StudentName { FirstName = "Mei", LastName = "MEI",ID=100 },
                new StudentName() { FirstName = "Lei", LastName = "LEI",ID=101 },
                new StudentName("Li","LI"){ ID =102}
            };

            foreach (var s in students) {
                Console.WriteLine(s.ToString());
            }

            Dictionary<int, StudentName> studentDic = new Dictionary<int, StudentName> {
                {111,new StudentName{FirstName ="Mei",LastName = "MEI",ID=111 }},
                {112,new StudentName{FirstName ="Lei",LastName = "LEI",ID=112 }},
            };

            foreach (var s in studentDic)
            {
                Console.WriteLine(s.Value.ToString());
            }
        }
    }

    public class StudentName {

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int ID { get; set; }

        public StudentName() {


        }

        public StudentName(string first, string last) {
            FirstName = first;
            LastName = last;
        }

        public override string ToString()
        {
            return FirstName + " " + ID;
        }

    }

    public class StudentFrom {
        public string FirstName { get; set; }

        public string City { get; set; }
    }

}
