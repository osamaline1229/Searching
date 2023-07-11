using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace File
{
    public class RangeAttribute : Attribute
    {
        public int Minimum { get; }
        public int Maximum { get; }

        public RangeAttribute(int minimum, int maximum)
        {
            Minimum = minimum;
            Maximum = maximum;
        }
    }

    public enum AgeGroup
    {
        [Range(0, 5)]
        Infant,

        [Range(6, 12)]
        Child,

        [Range(13, 19)]
        Teenager,

        [Range(20, 39)]
        Adult,

        [Range(40, 59)]
        MiddleAged,

        [Range(60, 120)]
        Senior
    }

    
}
