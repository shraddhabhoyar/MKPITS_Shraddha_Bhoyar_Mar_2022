using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace circle_radius_circ_assignment
{
    class radius
    {
        public int a;
        public float area = 0;
        public float circ = 0;

        public void areadata()
        {
            area = 3.14f * a * a;
            Console.WriteLine("areaof circle =" + area);
        }
        public void circdata()
        {
            circ = 2 * 3.14f * a;
            Console.WriteLine("circ of circle=" + circ);
        }
        internal class program
        {
            static void Main(string[] args)
            {
                radius rad = new radius();
                Console.WriteLine("enter radius");
                rad.a = Convert.ToInt32(Console.ReadLine());

                rad.areadata();
                rad.circdata();

                Console.ReadLine();
            }
        }
    }
}
