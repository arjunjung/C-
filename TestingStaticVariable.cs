using System;

namespace c_Programming{
    public class TestingStaticVariable{
        int x = 10;
        int y = 20;

        static int result;


        public TestingStaticVariable(){
            result += x + y;
            Console.WriteLine("\nResult is: " + result);
        }

        //Conclusion:
        //Static variable lives until the program closes. 
    }
}