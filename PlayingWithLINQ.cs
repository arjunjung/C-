using System;
using System.Linq;
using System.Data;

namespace c_Programming {
    public class PlayingWithLINQ{
        public PlayingWithLINQ() {
            
        }

        public int[] GetNumberData() {
            int[] data = new int[] { 1, 2, 3, 4, 5 };
            return data;

        }

        public void SimpleLINQQuery() {
            int[] numbers = GetNumberData();
            var afterLinq = from number in numbers where number > 3 select number;
            
            foreach(int i in afterLinq) {
                Console.Write(i+", ");
            }
        }

    }
}