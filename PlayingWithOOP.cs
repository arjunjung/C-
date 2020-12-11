using System;
using System.Text;
using System.Collections;

namespace c_Programming
{
    public class Color{

        //Using private Properties and get,set Accessors
        //Encapsulation 
        private string name { get; set; }
        private string hexvalue { get; set; }
        private int Red { get; set; }
        private int Green { get; set; }
        private int Blue { get; set; }
        private bool isPrimaryColor { get; set; }

        private string HEX_RED = "#FF0000";
        private string HEX_GREEN = "#00FF00";
        private string HEX_BLUE = "#0000FF";

        //Polymorphism: Where one object has take many forms.
        private HexGenerable hexGenerable = new HexGenerator();

        public Color(string name, int rgbRed, int rgbGreen, int rgbBlue)
        {
            if (rgbRed < 0 || rgbGreen < 0 || rgbBlue < 0 ||
                rgbRed > 255 || rgbGreen > 255 || rgbBlue > 255)
                throw new ColorException("\nYou have to specifiy color values between 0-255. Thank you.\n");

            this.name = name;
            this.Red = rgbRed;
            this.Green = rgbGreen;
            this.Blue = rgbBlue;
            ///Abstraction: Hiding how the hex is calculated.
            this.hexvalue = hexGenerable.HexCalculator(Red, Green, Blue);
            IsPrimaryChecker();
        }

        public string GetRGBvalue()
        {
            return $"rgb({Red}, {Green}, {Blue})";
        }

        public string GetHexValue()
        {
            return $"#{hexvalue}";
        }

        public string IsPrimary()
        {
            if (isPrimaryColor) return "This is a primary color.";
            else return "This isn't a primary color.";
        }

        private void IsPrimaryChecker()
        {
            if (GetHexValue() == HEX_RED || GetHexValue() == HEX_GREEN || GetHexValue() == HEX_BLUE)
            {
                isPrimaryColor = true;
            }else isPrimaryColor = false;
        }
    }

    //Abstraction
    interface HexGenerable{
        //Abstract method
        public string HexCalculator(int red, int green, int blue);
    }

    internal class HexGenerator: HexGenerable{
        public string HexCalculator(int red, int green, int blue){
            double decimalResult;
            int beforeDecimal = 0;
            int afterDecimal16 = 0;
            StringBuilder tempHex = new StringBuilder("000000");
            int[] colors = new int[3];
            colors[0] = red;
            colors[1] = green;
            colors[2] = blue;

            Hashtable hexvalues = new Hashtable();
            hexvalues.Add(0, "0");
            hexvalues.Add(1, "1");
            hexvalues.Add(2, "2");
            hexvalues.Add(3, "3");
            hexvalues.Add(4, "4");
            hexvalues.Add(5, "5");
            hexvalues.Add(6, "6");
            hexvalues.Add(7, "7");
            hexvalues.Add(8, "8");
            hexvalues.Add(9, "9");
            hexvalues.Add(10, "A");
            hexvalues.Add(11, "B");
            hexvalues.Add(12, "C");
            hexvalues.Add(13, "D");
            hexvalues.Add(14, "E");
            hexvalues.Add(15, "F");

            int insertAt = 0;
            int removeAt = 0;
            string tempstring = "";

            for (int i = 0; i < 3; i++)
            {
                decimalResult = colors[i] / 16d;
                beforeDecimal = (int)Math.Truncate(decimalResult);
                decimalResult = decimalResult - beforeDecimal;
                afterDecimal16 = (int)(decimalResult * 16);

                if (beforeDecimal <= 15 && beforeDecimal >= 0)
                {
                    tempstring = tempstring + hexvalues[beforeDecimal];
                    tempstring = tempstring + hexvalues[afterDecimal16];

                    tempHex.Remove(removeAt, 2);
                    tempHex.Insert(insertAt, tempstring);

                    removeAt += 2;
                    insertAt += 2;
                }
                beforeDecimal = 0;
                afterDecimal16 = 0;
                decimalResult = 0d;
                tempstring = "";
            }
            return tempHex.ToString();
            /*
                How does Stringbuilder.remove(int startindex, int length_from_startindex) works?
                How does Stringbuilder.remove(int startindex, int length_from_startindex) works?
                for remove;
                if, startindex = 2; we insert values between 1,2
                if, startindex = 3; we insert values between 2,3;
            */
        }
    }

    class ColorException: System.Exception{
        public ColorException() {}

        public ColorException(string message):base(message){}

        public ColorException(string message, Exception ce): base(message, ce){}

    }

    enum Days{
        sunday,
        monday,
        tuesday,
        wednesday,
        thursday,
        friday,
        saturday

        /*  This is enum
            -> enum is used to store constants data that don't changes.
            -> enum recognize its values from 0-n 

            We can use enum: 
            eg: Days.sunday

            We can get the position of the 'sunday' too.
            eg: int position = (int)Days.sunday
        */
    }

    internal struct PixelPoint{
        private double x{ get; set; }
        private double y{ get; set; }

        PixelPoint(double x, double y) {
            this.x = x;
            this.y = y;
        }

        static PixelPoint(){

        }
        /*
            This is Struct.
            -> Struct is data type of nature 'value-type'. That means it stores data inside its own memory. 
            -> Struct is like a class, but constructors must be parameterized and we can't use empty constructor, except static one. 
            -> Struct can't be used using inheritance. 

        */
    }



}