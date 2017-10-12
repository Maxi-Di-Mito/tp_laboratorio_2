using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase17
{
    class MiLista<T>:IEnumerable<T>, IEnumerator<T>
    {
        T[] lista;
        
        public int Count
        {
            get
            {
                return this.lista.Length;
            }
        }

        public MiLista()
        {
            this.lista = new T[0];
        }


        public void Add(T item)
        {
            Array.Resize<T>(ref this.lista, this.lista.Length + 1);
            this.lista[this.lista.Length - 1] = item;

        }

        public void Remove(T newItem)
        {
            for (int i = 0; i < this.lista.Length;i++)
            {
                T item = this.lista[i];
                if (Object.ReferenceEquals(item, newItem))
                {                    
                    for (int j = i; j < this.lista.Length -1; j++)
                    {
                        this.lista[j] = this.lista[j + 1];                        
                    }
                    Array.Resize<T>(ref this.lista, this.lista.Length - 1);
                    
                }
            }
        }





        int position = -1;

        public IEnumerator<T> GetEnumerator()
        {
            return this;
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return this;
        }

        public T Current
        {
            get { return this.lista[this.position]; }
        }

        public void Dispose()
        {
            /*VACIO */
        }

        object System.Collections.IEnumerator.Current
        {
            get { return this.lista[this.position]; }
        }

        public bool MoveNext()
        {
            if (this.position < this.lista.Length - 1)
            {
                this.position++;
                return true;
            }
            return false;
        }

        public void Reset()
        {
            this.position = -1;
        }
    }
}
