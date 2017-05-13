using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeStudy1
{
    class Manager<T>
    {
        private const int Capacity = 5;

        private T[] entities;

        private int counter = 0;
        
        //Indexer
        public T this[int i]
        {
            get { return entities[i]; }
            set { entities[i] = value; }

        }
        public Manager () : this (Capacity)
        {

        }
        public Manager (int capacity)
        {
            entities = new T[Capacity];

         }
         
        public void AddEntity (T entity)
        {
            if (counter >= entities.Length)
            {
                throw new InvalidOperationException("The stack is full!");
            }
            this.entities[counter] = entity;
            counter++;
        }

        public T RemoveEntity ()
        {
           if (counter == 0)
           {
               throw new InvalidOperationException("stack is empty");
           }
            T temp = entities[counter - 1];
            entities[counter - 1] = default(T);
            counter--;
            return temp;

        }

        public int GetNumberOfEntities()
        {

            return counter;
        }

    }
}
