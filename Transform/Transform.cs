using System;
using System.Linq;
using System.Collections.Generic;

namespace Transform
{
    public static class Transform 
    { 
     public delegate int delegatesquare(int num); 
        public static List<int> Map(this int[] a,delegatesquare square)
        {
           List<int> number =new List<int>();
			foreach (int x in a)
            {
				number.Add(square(x));
            }
			return number;
        }
    }
}
