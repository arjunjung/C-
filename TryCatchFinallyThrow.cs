using System;

namespace c_Programming{
    public class TryCatchFinallyThrow{
        public TryCatchFinallyThrow() {

        }

        public void SimpleTryCatch() {
            try{
                for (int j = 10; j >= 0; j--)
                {
                  Console.WriteLine("Result: " + (j/(j-1)));
                  
                  //It should create '1/0' exception. 
                }

            }catch(DivideByZeroException e) {
                Console.WriteLine("Error:\n" +e);
                //Exception was caught on 
            }
            // Console.WriteLine("Below falling into catch block");
        }

        public void SimpleTryCatchFinally() {
            try{
                for (int j = 10; j >= 0; j--)
                {
                  Console.WriteLine("Result: " + (j/(j-1)));
                }

            } catch(DivideByZeroException e) {
                Console.WriteLine("Error:\n" +e);
            } finally{
                Console.WriteLine("\nThis is finally");
                //Code inside finally block always runs, regardless of 'try' or 'catch' block
            }
            
        }

        public void SimpleTryCatchThrow() {
            try{
                for (int j = 10; j >= 0; j--)
                {
                  if(j==1) throw new System.DivideByZeroException();

                    Console.WriteLine("Result: " + (j/(j-1)));
                }

            } catch(Exception e) {
                Console.WriteLine("Error:\n"+ e);
            }
        }



    }
}