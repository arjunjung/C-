using System;
using System.Collections.Generic;


namespace c_Programming
{
    public class Extra<T>{
        public Extra() {

        }

        public List<T> PlayingWithGenerics(T para1, T para2){
            List<T> result = new List<T>{para1,para2};
            return result;
            
        }

        /*
            Use generic types to maximize code reuse, type safety, and performance.
            The most common use of generics is to create collection classes.
            The .NET class library contains several generic collection classes in the System.Collections.Generic namespace. These should be used whenever possible instead of classes such as ArrayList in the System.Collections namespace.
            You can create your own generic interfaces, classes, methods, events, and delegates.
            Generic classes may be constrained to enable access to methods on particular data types.
        */
    }

    public class MYOwnDataStructure<T> {

        //This is a simple datastructure with can hold dynamic data of same type.
        private T[] _data;
        private T[] _temp;
        private bool isSizedProperly = false;
        private int sizeDSCounter = 1;
        private int lastIndex = 1;
        private int maxCapacity = 2000000000;
        private int lastCapacity = 4;

        public MYOwnDataStructure(int size) {
            this._data = new T[size];
            this.isSizedProperly = true;
        }

        public MYOwnDataStructure() {
            this._data = new T[lastCapacity];
        }

        public void AddData(T data) {
            if(_data.Length > 0 && isSizedProperly == false && maxCapacity>=_data.Length) {

                _data[lastIndex-1] = data;//0,1,2,3,4

                if(this.lastIndex == this.lastCapacity) {
                    this.lastCapacity += 4;
                    this._temp = this._data;
                    this._data = new T[this.lastCapacity];

                    for (int i = 0; i < this._temp.Length; i++) {
                        this._data[i] = this._temp[i];
                    }
                }
                lastIndex++;//1,2,3,4,5
                this._temp = this._data;
            } else {
                throw new System.SystemException();
            }
        }

        public void UpdataData(int index, T data) {
            if(index>=0 && index<_data.Length) {
                _data[index] = data;
            }
        }

        public T GetDataAt(int index) {
            if(index>=0 && index< _data.Length) {
                return _data[index];
            }
            return default(T);
        }

        public T[] GetFullData() {
            Console.WriteLine("last capacity: " + lastCapacity + ", last index : " + lastIndex);
            int possibleZeros = lastCapacity - lastIndex+1;
            for (int i = 0; i < possibleZeros; i++) {
                DeleteData((lastCapacity - possibleZeros));
            }
            
            return _temp;
        }

        public void DeleteData(int index) {
            T[] _finalData = new T[_temp.Length - 1];

            for (int z = 0; z < _temp.Length-1; z++) {
                if(z < index && index != 0) {
                    _finalData[z] = _temp[z];
                } else {
                    _finalData[z] = _temp[z + 1];
               }
            }
            _temp = _finalData;
        }
        
        private void DSSizeHandler() {
            this._data = new T[sizeDSCounter];
        }

        public int GetCapacity() {
            return this.maxCapacity;
        }
    }
    
}