using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EmployeeMan
{
    class EmployeeDTO
    {
        private int id, age, salary;
        private String name;

        public EmployeeDTO(int id,int age,int salary,String name)
        {
            this.id = id;
            this.age = age;
            this.salary = salary;
            this.name = name;
        }

        public int ID
        {
            get{ return id; }

            set{ id = value; }
        }

        public int AGE
        {
            get { return age; }

            set { age = value; }
        }

        public int SALARY
        {
            get { return salary; }

            set { salary = value; }
        }

        public String NAME
        {
            get { return name; }

            set { name = value; }
        }

    }
}
