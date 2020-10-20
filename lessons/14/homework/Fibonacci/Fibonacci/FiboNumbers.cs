using System.Collections;
using System.Collections.Generic;

namespace Fibonacci
{
    class FiboNumbers : IEnumerable<int>
    {
        private readonly int _count; 
        private int Fibonacci(int position) // Генерирует число Фибоначчи на заданной позиции в последовательности
        {
            int i1 = 0;
            int i2 = 1;
            int result = 0;

            for (int i=0; i<=position; i++)
            {
                if (i<=1)
                {
                    result = i;
                }
                else
                {
                    result = i2 + i1;
                    i1 = i2;
                    i2 = result;
                }                
            }
            return result;
        }        
        /*
        class Enumerator : IEnumerator<int>
        {
            private int _index;
            private FiboNumbers _generator;

            public int Current
            {
                get => _generator.Fibonacci(_index);
            }

            object IEnumerator.Current => this.Current;
            public bool MoveNext()
            {
                return ++_index < _generator._count;
            }

            public void Reset()
            {
                _index = -1;
            }

            public void Dispose()
            {
                if (_generator != null)
                {
                    _generator = null;
                }
            }

            public Enumerator(FiboNumbers fibonums)
            {
                _generator = fibonums;
                Reset();
            }
            
        }

        */
        public IEnumerator<int> GetEnumerator()
        {
            //   return new Enumerator(this);
            for (int i = 0; i < _count; i++)
            {
                yield return Fibonacci(i);
            }
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        public FiboNumbers(int count) 
        {
            if (count>47)
            {
                _count = 47;
            }
            else
            {
                _count = count;
            }
        }
    }
}
