using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numerical_Analysis_Project
{
    class GlobalVaribles
    {
        private static string v_Function = " ";
        public static string Function
        {
            get { return v_Function;}
            set { v_Function = value; }
        }
        private static string v_XL = " ";
        public static string XL
        {
            get { return v_XL; }
            set { v_XL = value; }
        }
        private static string v_XU = " ";
        public static string XU
        {
            get { return v_XU; }
            set { v_XU = value; }
        }
        private static string v_X0 = " ";
        public static string X0
        {
            get { return v_X0; }
            set { v_X0 = value; }
        }
        private static string v_XMins1 = " ";
        public static string XMins1
        {
            get { return v_XMins1; }
            set { v_XMins1 = value; }
        }
        private static string v_Iter = " ";
        public static string Iter
        {
            get { return v_Iter; }
            set { v_Iter = value; }
        }
       
        private static string v_Error = " ";
        public static string Error
        {
            get { return v_Error; }
            set { v_Error = value; }
        }
     
    }
}
