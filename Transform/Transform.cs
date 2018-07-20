using System;
using System.Linq;
using System.Collections.Generic;

namespace Transform
{
    public static class Transform 
    {
        public static List<int> Map(this int[] a,Func<int,int>square)
        {
           List<int> number =new List<int>();
			foreach (int x in a){
				number.Add(square(x));
}
			return number;
        }
    }
}
