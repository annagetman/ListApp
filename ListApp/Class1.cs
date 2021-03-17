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

        public void AddByIndex(int value)
        {
          
        }

        //удаление из конца одного элемента

        public void RemoveElementFromEnd(int value)
        {

        }

        //удаление из начала одного элемента
        public void RemoveElementFromStart(int value)
        {

        }

        //удаление по индексу одного элемента
        public void RemoveElementByIndex(int value)
        {

        }

        //удаление из конца N элементов
        public void RemoveNElementsFromEnd(int value)
        {

        }

        //удаление из начала N элементов
        public void RemoveNElementsFromStart(int value)
        {

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


        private void UpSize()
        {
            int newLength = (int)(_array.Length * 1.33d + 1);
            int[] tmpArray = new int[newLength];
            for (int i = 0; i < _array.Length; i++)
            {
                tmpArray[i] = _array[i];
            }
        }
    }
}
