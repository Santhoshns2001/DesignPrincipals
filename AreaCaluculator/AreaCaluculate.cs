using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPrincipalsImpliDemo.AreaCaluculator
{
    public class AreaCaluculate
    {
        public static double AreaCal(Shape[] arrShapes ) {

            double area = 0;
            foreach(var objShape in arrShapes)
            {
                area += objShape.Area();
            }
            return area;
        }
    }
} 
