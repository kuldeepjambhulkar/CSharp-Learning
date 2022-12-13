using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    public class Program2
    {
        public static void method3() {
            try
            {
                method2();
            }
            catch (Exception ex) { 
                Console.WriteLine(ex.StackTrace.ToString());
            }
        }
        public static void method2() {
            try
            {
                method1();
            }
            catch (Exception ex) {
                throw;
            }
        }
        public static void method1() {
            try
            {
                throw new Exception("Exception from method1()");
            }
            catch (Exception ex) {
                throw ex;
            }
        }

    }
}
