using System;
using System.Collections;
using System.Collections.Generic;

namespace ConsoleApp.Service 
{
    public class LinkedList<T> : IEnumerable<T>
    {
        Nods<T> node;
        int Head;
        int Tail;
        int count;



        public LinkedList(int size)
        {
            node = new Nods<T>(size);
            count = node.Value.Length;
            Head = 0;
        }

        
        //Метод для вставки элемента в произвольную позицию
                
        public void AddRandom(T lists, int index)
        {
            node.Value[index] = lists;
            count ++;
            Tail = --count;
            node.Next = ++index;
            node.Previous = --index;
            Console.WriteLine("Следующий элемент:{0}, Предыдущий элемент:{1}", node.Next, node.Previous);

        }

        //Метод вставляет элемент в конец списка
        public void AddLast(T lists)
        {
            
            try{

                node.Value[--count] = lists;
                count++;
                Tail = --count;
                node.Next = Head;
                node.Previous = --Tail;
                Console.WriteLine("Следующий элемент:{0}, Предыдущий элемент:{1}", node.Next, node.Previous);

            } catch(Exception ex) {

                throw ex.InnerException;
            }
        }

        //Метод для вставки элемента после указанного индекса
        public void AddAfter(T list, int index)
        {
            
            if(node.Value[index] != null)
            {
                int ind = ++index;
                node.Value[index++] = list;
                node.Next = ind;
                node.Previous = --ind;
                count++;
                Tail = --count;
                Console.WriteLine("Следующий элемент:{0}, Предыдущий элемент:{1}", node.Next, node.Previous);
            }
        }

        //Метод для вставки элемента перед указаным индексом
        public void AddBefore(T list, int index)
        {
            if(node.Value[index] != null)
            {
                node.Value[--index] = list;
                count++;
                Tail = --count;
                node.Next = index;
                node.Previous = (index)-2;
                Console.WriteLine("Следующий элемент:{0}, Предыдущий элемент:{1}", node.Next, node.Previous);
            }
        }

        //Удаление эелемента по индексу
        public void Delete(int index)
        {
            for (int i = 0; i < count; i++)
            {
                if(i == index)
                {
                    node.Value[i] = node.Value[index++];
                    node.Value[count] = default;
                }
            }
        }




        //Метод для получения элемента по индексу
        public T Get(int index)
        {
            node.Next = index++;
            node.Previous = --index;
            return node.Value[index];
        }

        public int Count()
        {
            return node.Value.Length;
        }
        public IEnumerator<T> GetEnumerator()
        {
            
            while(Count() != 0)
            {
                int ind = 0;
                while(ind < count)
                {
                    yield return node.Value[ind];
                    ind++;
                }
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)this).GetEnumerator();
        }
    }
}