using System;

namespace exercise_05
{
     class Container
    {
        public class MyContainer
        {
            private object[] _theObjects;
            private int _n;

            public MyContainer()
            {
                _theObjects = new object[2];
                _n = 0;
            }

            public void Add(object o)
            {
                if (_n == _theObjects.Length)
                {
                    object[] oldArray = _theObjects;
                    _theObjects = new object[2 * oldArray.Length];
                    Array.Copy(oldArray, _theObjects, _n);
                }

                _theObjects[_n] = o;
                _n++;
            }

            public object GetAt(int i)
            {
                return _theObjects[i];
            }

            public int Count
            {
                get { return _n; }
            }
        }
    }


    //Generic class der class MyContainer
    /*public class MyContainer<T>
    {
        private T[] _theObjects;
        private int _n;

        public MyContainer()
        {
            _theObjects = new T[2];
            _n = 0;
        }

        public void Add(T o)
        {
            if (_n == _theObjects.Length)
            {
                T[] oldArray = _theObjects;
                _theObjects = new T[2 * oldArray.Length];
                Array.Copy(oldArray, _theObjects, _n);
            }

            _theObjects[_n] = o;
            _n++;
        }

        public T GetAt(int i)
        {
            return _theObjects[i];
        }

        public int Count
        {
            get { return _n; }
        }
    }*/
}
