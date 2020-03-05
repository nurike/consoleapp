using System;

namespace ConsoleApp.Service
{
    public class Nods<T> 
    {
        public Nods()
        {
            
        }
        public Nods(int size)
        {
            Value = new T[size];
        }
        public T[] Value { get; set;}
        public int Previous { get; set;}
        public int Next { get; set;}
    }
}