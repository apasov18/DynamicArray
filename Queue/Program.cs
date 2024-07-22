using System.Collections;
using System.Runtime.CompilerServices;

namespace Queue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DynamicArray array = new DynamicArray();
           array.Add("A");
           array.Add("B");
           array.Add("C");
           array.Add("D");
           array.Add("E");
            array.Delete("C");

            Console.WriteLine(array.ToString());
            Console.WriteLine("Size:" + array.size);
            Console.WriteLine("Capacity:" + array.capacity);
            Console.WriteLine("Empty:"+array.IsEmpty());





        }
    }
    public class DynamicArray
    {
         public int size;
        public int capacity = 10;
        object[] array;

        public DynamicArray() 
        {
            this.array= new object[capacity];
        }
        public DynamicArray(int capacity) 
        {
            this.capacity= capacity;
            this.array= new object[capacity];
        
        }

        public void Add(object value) 
        {
            if (size >= capacity)
            {
                Grow();
                    
             }
            array[size] = value;
            size ++; 

        }
        public void Insert (int index, object value) 
        {
            if (size >= capacity) 
            {
                Grow();
            
            }
            for (int i = size; i > index; i --)
            {
                array[i] = array[i -1];
            }
            array[index] = value;
            size++;
        }

        public void Delete (object value) 
        {
            for(int i = 0; i < size; i ++) 
            {
                if (array[i] == value)
                {
                    for (int j = 0;j < (size- i - 1);j ++)
                    {
                        array[i + j] = array[i + j + 1];
                    }
                    array[size - 1] = null;
                    size--;
                    if(size<=(int)(capacity/3)) 
                    {
                        Shrink();
                    }
                    break;
                }
            
            }
        
        }

        public int Search (object value) 
        {
            for( int i = 0; i < size;i++)
            {
                if (array[i] == value)
                {
                    return i;
                }
            }
            return 0;
        
        }
        private void Grow()
        {
            int newCapacity = (int)(capacity * 2);
            object[] newArray = new object[newCapacity];
            for (int i = 0;i < size;i ++)
            {
                newArray[i] = array[i];
            }
            capacity = newCapacity;
            array = newArray;

        }
        private void Shrink () 
        {
            int newCapacity = (int)(capacity / 2);
            object[] newArray = new object[newCapacity];
            for (int i = 0; i < size; i++)
            {
                newArray[i] = array[i];
            }
            capacity = newCapacity;
            array = newArray;
        }

        public bool IsEmpty()
        {
            return size == 0;

        }
        public string ToString()
        {
            string str = "";
            for (int i = 0;i< size;i++)
            {
                str += array[i] + ", ";
            }
            if(str != "")
            {
                str = "[" +str.Substring(0,str.Length-2) + "]";
            }
            else
            {
                str="[]";
            }
            return str;
        }

    }
}