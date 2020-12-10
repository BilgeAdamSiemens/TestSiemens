using System;
using System.Collections.Generic;
namespace TestSiemens
{
    public class Stack<T>
    {
        //Push, Pop, Peek

        //private readonly List<T> _list = new List<T>();
        public List<T> _list = new List<T>();
        public int Count => _list.Count; //direk set ediyoruz

        public void Push(T obj)
        {
            if (obj == null)
                throw new ArgumentNullException();

            _list.Add(obj);

            //sadece int tipinde bir obje gelirse listeye ekleme islemi yapacak
            //Test tarafinda farkli tipler girerek bunu kontrol edicez ve hatayi
            //uygulamayi yayinlamadan once gorecegiz
            //var a = obj is int;

            //if (a)
            //    _list.Add(obj);
            //else
            //    throw new InvalidOperationException();
        }

        public T Pop()
        {
            if (_list.Count == 0)
                throw new InvalidOperationException("Silmek istediginiz liste zaten bos");

            var result = _list[_list.Count - 1];
            _list.Remove(result);
            return result;
        }

        public T Peek()
        {
            if (_list.Count == 0)
                throw new InvalidOperationException();

            return _list[Count - 1];
        }
    }
}
