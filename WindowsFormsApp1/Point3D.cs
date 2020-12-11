using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyLib;

namespace WindowsFormsApp1
{
    [Serializable]
    public class Point3D:Point
    {
        public Int32 z;
        public Point3D() : base()
        {
            z = 0;
        }

        public Point3D(Int32 x, Int32 y, Int32 z) : base(x, y)
        {
            this.z = z;
        }

        public override double Metric()
        {
            return Math.Sqrt((x * x + y * y + z * z));
        }

        public override string ToString()
        {
            return String.Format("({0} , {1}, {2})", x, y, z);
        }
    }
}
