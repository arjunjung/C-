using System;

namespace c_Programming{
    public class Miscellaneous{

        //practing constructors in c#

        private string yourName;

        public Miscellaneous(){
            Console.WriteLine("\nThis is the public contructor. I am running after static constructor and before finalizer start to clean things up.\n");
        }

        static Miscellaneous(){
            Console.WriteLine("I am Static Constructor. I runs at first of everything");
            /*
            This is static constructor.
            -> It runs at the beginning right after the class's instance is made.
            */
        }

        //practicing finalizers in c#
         ~Miscellaneous() {
            Console.WriteLine("Miscellaneous: I am closing.... ");

            /*
             This is finalizers:
             -> finalizers can be only one at each class
             -> finalizers can't be called explicitly . But like a static constructor it will be called by runtime itself before grabage cleaer clean the class's instance.
             -> finalizers doesn't allow any modifers(public or private or protected)
             -> finalizers is used to do necessary final clean up. Before it is done by garbase collector.
             -> finalizers can't be overloaded.
             -> programmers have no control over calling finalizers. 
             -> If the object is no longer being referenced by application, then it is eligible for garbage collection. 
                 then garbase collection calls finalizer of the app.
    
            */
        }

        public Miscellaneous(string yourName){
            this.yourName = yourName;

            /*
                This is a instance constructor.
                -> This constructor only used to initialize instance variables.
            */
        }

    }

    public class Deconstructors {
        private int age;
        public string name;

        public Deconstructors(int age, string name) {
            this.age = age;
            this.name = name;
        }

        public void Deconstruct(out int _Age, out string _Name) {
            _Age = this.age;
            _Name = this.name;

            /*
            This is Deconstructor. 
            This is called Deconstructor becoz, it brings out instance variable to the other classes. 
            Where as Constructor brings in data from other classes and stores in instance variables.
            
            To create Deconstructor in class. It is a method must NAMED "Deconstruct".
            
            */
        }
    }

      public class MyProperties{
            private int myage = 10;
            private string myname = "Baby AB";

            public MyProperties(){}

            public int MyAge{
            get
            {
                return this.myage;
            }

            set
            {
                this.myage = value;
            }

            /*
            This is called Properties. 
            Proporties allows to 'get' and 'set' instance variable without exposing it.
            -> Proporties is just a block of code with 'get' Accessors and 'set' Accessors
            -> Properties don't have parameters bracket.

            In the instance end. We will use this property like this:
            instance.MyAge (getting the age)
            instance.Myage = value (setting the age)
            */
        }
    }

    public class Indexers{
        private string[] listStrings = new string[10];

        public string this[int index]{
            get {
                return listStrings[index];
            }

            set {
                listStrings[index] = value;
            }

            /*
                This is indexers. 
                Indexers syntax defination is similar to the Properties, except Properties doesn't allow parameters whereas Indexders does.

                -> Indexers allows us to use class indexed as an Arrays. 
                -> Class defined with Indexer, is acts as virtual array.
                -> We use [] like a array to access class variable which in turn must use indexer.

            
            
            */
        }
    }

    public class DynamicBinding{
        //Using Dynamic Binding  we can "slip in to run-time avoiding compile time".
        //dynamic variable is used to denote dynamic binding. 
        public void TestDynamicBinding1(){
            dynamic num1 = 10; //System.Int32
            object num2 = 20; //System.Int32

            // Console.WriteLine("Dynamic Num1(Type Checking): "+num1.GetType());
            // Console.WriteLine("Object Num2(Type Checking): "+num2.GetType());

            num1 = num1 + 23434; //There is no compile time error in dynamic variable. 
            // num2 = num2 + 23434; //There is a compile time error . 
            //[Eventhough both variables have similar int32 type]
        }

        //The main purpose of the 'dynamic' binding is to avoid comile time error. And do more dynamic variable programming.
        public dynamic ShowMessage(string message) {
            return message + "| GREEAT ONE";
        }
    }

    public class OperatorOverloading_Plus{
        /*This is operator overlading 
        -> Operator overloading basically, allows us to overload system defined operators.
        -> We override system-defind operators(+,-,*,/...etc) and make user-defined operator.
        
        -> [Rule1] We must use public','static' modifiers to declare user-defined operator.
        -> [Rule2] We use this syntax:-    public static void operator+ [operator[sign]] (parameter)
        */

        private int num1;
        private int num2;

        public OperatorOverloading_Plus(int num1, int num2) {
            this.num1 = num1;
            this.num2 = num2;
        }

        public OperatorOverloading_Plus() {}

        //Using properties
        public int Num1_Properties{
            get{
                return num1;
            }

            set{
                num1 = value;
            }
        }

        public int Num2_Properties{
            get{
                return num2;

            }
            set{
                num2 = value;
            }
        }

        public int GetSum(){
            return num1 + num2;
        }

        //This is operator overloading
        public static OperatorOverloading_Plus operator + (OperatorOverloading_Plus op1 , OperatorOverloading_Plus op2) {
            OperatorOverloading_Plus operatorOverloading = new OperatorOverloading_Plus();
            operatorOverloading.Num1_Properties = op1.Num1_Properties + op2.Num1_Properties;
            operatorOverloading.Num2_Properties = op2.Num2_Properties + op2.Num2_Properties;
            return operatorOverloading;

            /*
                Basically we are taking 2 object of same class. 
                And adding their instance variables and storing it in another object of same class.
            */
        }

        /*
            Operators that supports 'OperatorOverloading'
            -> All unary operators:   ~, +, -, !, ++, --
            -> All relational operators: !=, > , < , <=, >=, ==
            -> All arithmetic operators: *, /, %, +, -

            Operators that doesn't supports 'OperatorOverloading'
            -> 2 Logical Operators: &&, ||
            -> Miscallaneous Operators: new, sizeof, typeof, is
            -> All assignment operators: -=, +=, =, *=, /=, %=
        
        */
    }

    public class OperatorOverloading_GT_LT{
        private double temp;

        public OperatorOverloading_GT_LT(){}
        public OperatorOverloading_GT_LT(double temp) {
            this.temp = temp;
        }

        //Definding properties
        public double Temp{
            get
            {
                return temp;
            }

            set
            {
                temp = value;
            }
        }

        // public void GetResult() {
        //     Console.WriteLine("\nThere is summer in ");
        // }

        //Relational or Comparision Operator Overloading
        public static bool operator > (OperatorOverloading_GT_LT op1, OperatorOverloading_GT_LT op2) {
            bool status = false;
            if(op1.Temp < op2.Temp) {
                status = true;
            }
            return status;
        }

         public static bool operator < (OperatorOverloading_GT_LT op1, OperatorOverloading_GT_LT op2) {
            bool status = false;
            if(op1.Temp > op2.Temp) {
                status = true;
            } 
            return status;
        }

        /*
            Relational Operators: To overload relational operators from C# 5.0 nowon. 
            ->[Rule] We need to overload pairs of each relational operators.
            meaning: 

            if we want to overload, ' < '  we need to overload ' > '  too. 
            if we want to overload, ' == ' we need to overload ' =! ' too. 
            if we want to overload, ' >= ' we need to overload ' <= ' too.
        */
    }

}