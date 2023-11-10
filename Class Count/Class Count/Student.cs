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
        protected int Id;
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Payment { get; set; }
        public int Sessions { get; set; }


        public void SetId()
        {
            // Generate a unique ID
            Guid uniqueId = Guid.NewGuid();

            // Convert the Guid to an integer (32 bits)
            int uniqueInt = uniqueId.GetHashCode();

            // Ensure the integer is non-negative
            uniqueInt = Math.Abs(uniqueInt);


            Id = uniqueInt;

        }

        public void SetId(int id)
        { this.Id = id; }

        public int getId()
        { return Id; }
    }

}
