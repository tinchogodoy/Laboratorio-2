using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_clase_17
{
    public class MiLista<T> : IEnumerable<T>
    {
        private T[] lista;

        public MiLista()
        {
            this.lista = new T[0];
        }
        
        public int Count
        {
            get
            {
                return this.lista.Length;
            }
        }

        public void Add(T item)
        {
            Array.Resize(ref lista, this.Count + 1);
            this.lista[lista.Length - 1] = item;
        }


        public void Remove (T item)
        {
            T[] aux = new T[this.Count - 1];
            for(int i=0; i < this.Count; i++)
            {
                if (this.lista[i].Equals(item))
                {
                    if(i>0 )
                    {
                        Array.ConstrainedCopy(this.lista, 0, aux, 0, i);
                    }
                    if (i < this.Count)
                    {
                        Array.ConstrainedCopy(this.lista, i + 1, aux, i, this.Count - i - 1);
                    }
                    Array.Resize(ref lista, this.Count - 1);
                    Array.ConstrainedCopy(aux, 0, this.lista, 0, this.Count);
                }

                
            }



        }


        public IEnumerator<T> GetEnumerator()
        {
            for(int i = 0; i < this.Count; i++)
            {
                yield return this.lista[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            for (int i = 0; i < this.Count; i++)
            {
                yield return this.lista[i];
            }
        }
    }
}
