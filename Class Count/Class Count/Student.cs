using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;

namespace Class_Count
{
    public class Student
    {
        // Private field for ID
        private int _id;

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Payment { get; set; }
        public int Sessions { get; set; }

        // Property for accessing ID (read-only)
        public int Id
        {
            get { return _id; }
        }

        // Constructor to initialize a student with a provided ID
        public Student(int id)
        {
            _id = id;
        }

        // Default constructor generates a unique ID
        public Student()
        {
            GenerateUniqueId();
        }

        // Private method to generate a unique ID
        private void GenerateUniqueId()
        {
            Guid uniqueId = Guid.NewGuid();
            int uniqueInt = uniqueId.GetHashCode();
            _id = Math.Abs(uniqueInt);
        }
    }
}

