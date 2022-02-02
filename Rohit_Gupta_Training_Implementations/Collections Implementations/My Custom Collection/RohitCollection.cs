using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rohit_Gupta_Training_Implementations.Collections_Implementations.My_Custom_Collection
{
    internal class RohitCollection : IEnumerator,IEnumerable
    {
        private Monuments[] _monuments;
        private int position =-1;
        private int current = -1;
        private int capacity=2;
        private Boolean canExtend=true;

        public RohitCollection()
        {
            _monuments = new Monuments[this.capacity];
        }

        public RohitCollection(int capacity)
        {
            canExtend = false;
            this.capacity = capacity;
            _monuments=new Monuments[capacity];
        }

        public Boolean CanExtend
        {
            set { canExtend = value; }
        }

        public int Capacity
        {
            get { return capacity; }
        }
        
        public void Add(Monuments monument)
        {
            
            if (current < this.capacity-1)
            {
                current++;
                _monuments[current] = monument;
                Console.WriteLine($"{monument.Name} Added ");
               
            }
            else if (canExtend)
            {
                current++;
                Array.Resize(ref _monuments, capacity*2);
                _monuments[current]= monument;
                capacity=capacity*2;
                Console.WriteLine($"{monument.Name} Added ");
            }
            else 
            {
                Console.WriteLine($"{monument.Name} Additon Failed ");
                
            }
        }

        public void Remove(int index)
        {
            if (index < _monuments.Length)
            {
                Monuments[] new_monuments = new Monuments[this.capacity - 1];
                capacity--;

                for (int i = 0, j = 0; i < _monuments.Length; i++)
                {
                    if (i != index)
                        new_monuments[j++] = _monuments[i];
                    else
                    {
                        Console.WriteLine($"{_monuments[i].Name} Removed ");
                    }
                }

                _monuments = new_monuments;
            }
            else
            {
                Console.WriteLine("Deletion Failed ");
               
            }

        }

        public void Update(int index, Monuments monument)
        {
            try
            {
                Console.WriteLine($"{ _monuments[index].Name} Updated with {monument.Name}");
                _monuments[index] = monument;
                

            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Updation Failed ");
            }
        }

        public object Current
        {
            get
            {
                try
                {
                    return _monuments[position];
                }
                catch (IndexOutOfRangeException)
                {
                    throw new InvalidOperationException();
                }
                
            }
            
        }

        public IEnumerator GetEnumerator()
        {
            return (IEnumerator)this;
        }

        public bool MoveNext()
        {
            position++;
            return position < _monuments.Length;
        }

        public void Reset()
        {
            position = -1;
            
        }

    }
}
