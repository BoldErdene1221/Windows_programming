using System;
using System.Collections.Generic;
using System.Text;

namespace Battsetseg
{
    namespace Labrator1
    {
        class Age
        {
            private int age;
            public Age() {
                age = 0;
            }
            public int GetAge()
            {
                return age;
            }

            public void SetAge(int value)
            {
                age = value;
            }

            public int getYear()
            {
                int year;
                year = 2020 - age;
                return year;
            }
        }
    }
}