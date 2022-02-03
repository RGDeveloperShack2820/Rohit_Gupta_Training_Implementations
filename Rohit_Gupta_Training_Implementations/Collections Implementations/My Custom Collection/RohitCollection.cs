using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rohit_Gupta_Training_Implementations.Collections_Implementations.My_Custom_Collection
{
    internal class RohitCollection<T> : IEnumerator,IEnumerable
    {
        private List<T> _elements;
        private int position =-1;
        private int capacity;
        private Boolean canExtend=true;

        public RohitCollection()
        {
            this.capacity = 2;
            _elements = new List<T>(capacity);
        }

        public RohitCollection(int capacity)
        {
            canExtend = false;
            this.capacity = capacity;
            _elements=new List<T>(capacity);
        }

        public Boolean CanExtend
        {
            set { canExtend = value; }
        }

        public int Capacity
        {
            get { return capacity; }
        }
        
        public void Add(T element)
        {
            
            if (_elements.Count < this.capacity)
            {
                
                _elements.Add(element);
                Console.WriteLine(" Element Added");


            }
            else if (canExtend)
            {

                Console.WriteLine(" Element Added");
                UpdateCapacity(false);
                _elements.Add(element);

                
            }
            else 
            {
                Console.WriteLine(" Additon Failed");
                
            }
        }

        public void Remove(int index)
        {
            
            if (index < _elements.Count)
            {
               _elements.RemoveAt(index);
                Console.WriteLine(" Element Deleted");
            }
            else
            {
                Console.WriteLine(" Deletion Failed ");
            }

            if(_elements.Count<(capacity/2))
                UpdateCapacity(true);
        }

        private void UpdateCapacity(Boolean shrink)
        {
            if (shrink)
            {
                List<T> _newElements = new List<T>(capacity / 2);
                _newElements = _elements.ToList<T>();
                _elements = _newElements;
                capacity = capacity / 2;
            }
            else
            {
                List<T> _newElements = new List<T>(capacity * 2);
                _newElements = _elements.ToList<T>();
                _elements = _newElements;
                capacity = capacity * 2;
            }

            Console.WriteLine("Capacity Updated To : " + capacity);

        }

        public void Update(int index, T element)
        {
            try
            {
                
                _elements[index] = element;

                Console.WriteLine(" Element Updated");
            }
            catch (Exception)
            {
                Console.WriteLine(" Updation Failed ");
            }
        }

        public object Current
        {
            get
            {
                try
                {
                    return _elements[position];
                }
                catch (Exception)
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
            return position < _elements.Count;
        }

        public void Reset()
        {
            position = -1;
            
        }
    }
}
