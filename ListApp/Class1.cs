using System;

namespace ListApp
{
    public class ArrayList
    {
       

        public int Length { get; private set; }

        private int[] _array;

        public ArrayList()
        {
            Length = 0;

            _array = new int[10];
        }

        public int this[int index]
        {
            get
            {
                if(index>Length-1 || index <0)
                {
                    throw new IndexOutOfRangeException();
                }
                return _array[index];
            }
            set
            {
                if (index > Length - 1 || index <0)
                {
                    throw new IndexOutOfRangeException();
                }
                _array[index] = value;
            }
        }


        //добавление значения в конец
        public void Add(int value)
        {
            if (Length == _array.Length)
            {
                UpSize();
            }
            _array[Length] = value;
            Length++;
        }

 

        //добавление значения в начало

        public void AddToStart(int value)
        {
            if (Length == _array.Length)
            {
                UpSize();
            }

            for (int i = Length; i >= 0; --i)
            {
                _array[i + 1] = _array[i];

            }
            _array[0] = value;

            Length++;
        }

        //добавление значения по индексу

        public void AddValueByIndex(int value, int index)
        {
            if (index < Lenght && index >= 0)
            {
                ReSize();

                for (int i = Lenght - 1; i <= index; i--)
                {
                    _array[i + 1] = _array[i];
                }

                _array[index] = value;
                ++Lenght;
            }

            throw new Exception("Error");
        }
      
        //удаление из конца одного элемента

        public void RemoveElementFromEnd()
        {
            ReSize();

            Lenght--;

        }

        //удаление из начала одного элемента
        public void RemoveElementFromStart()
        {
            ReSize();

            for (int i = Lenght - 1; i >= 0; i--)
            {
                _array[i + 1] = _array[i];
            }

            Lenght--;
        }

        //удаление по индексу одного элемента
        public void RemoveElementByIndex(int index)
        {
            if (index < Lenght && index >= 0)
            {
                ReSize();

                for (int i = Lenght - 1; i <= index; i--)
                {
                    _array[i + 1] = _array[i];
                }

                Lenght--;
            }
        }

        //удаление из конца N элементов
        public void RemoveNElementsFromEnd(int Nvalue)
        {
            Lenght -= Nvalue;
            ReSize();
        }


        //удаление из начала N элементов
        public void RemoveNElementsFromStart(int Nvalue)
        {
            for (int i = Nvalue + 1; i < Lenght - 1; i -= Nvalue)
            {
                _array[i + Nvalue] = _array[i];
            }

            ReSize();

        }

        //удаление по индексу N элементов
        public void RemoveNElementByIndex(int value)
        {

        }

        //вернуть длину
        public void ReturnLength(int value)
        {

        }

        //доступ по индексу
        public void AccessByIndex(int value)
        {

        }

        //первый индекс по значению
        public void FirstIndexByValue(int value)
        {

        }

        //изменение по индексу
        public void СhangesByIndex(int value)
        {

        }

        //реверс(123 -> 321)
        public void Reverse(int value)
        {
            for(int i =0; i<=Length/2-1; i++)
            {
                Swap(ref _array[i], ref _array[Length - i - 1]);
            }

        }

        //поиск значения максимального элемента
        public void SearchValueMaxElement(int value)
        {

        }

        //поиск значения минимального элемента
        public void SearchValueMinElement(int value)
        {

        }

        //поиск индекс максимального элемента
        public void SearchIndexMaxElement(int value)
        {

        }

        //поиск индекс минимального элемента

        public void SearchIndexMinElement(int value)
        {

        }

        //сортировка по возрастанию
        public void SortAscending(int value)
        {

        }

        //сортировка по убыванию
        public void DescendingSort(int value)
        {

        }

        //удаление по значению первого(?вернуть индекс)
        //удаление по значению всех(?вернуть кол-во)
        //3 конструктора(пустой, на основе одного элемента, на основе массива )
        //добавление списка(вашего самодельного) в конец
        //добавление списка в начало
        //добавление списка по индексу


        private void Swap(ref int a, ref int b)
        {
            temp = a;
            a = b;
            b = temp;
        }
        private void UpSize()
        {
            int newLength = (int)(_array.Length * 1.33d + 1);
            int[] tmpArray = new int[newLength];
            for (int i = 0; i < _array.Length; i++)
            {
                tmpArray[i] = _array[i];
            }
        }

        private void ReSize()
        {
            if ((Lenght >= _array.Length) || (Lenght <= _array.Length / 2))
            {
                int newLenght = (int)(_array.Length * 1.33 + 1);
                int[] tmpArray = new int[newLenght];

                for (int i = 0; i < Lenght; i++)
                {
                    tmpArray[i] = _array[i];
                }

                _array = tmpArray;
            }



        }
}
