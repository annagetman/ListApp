﻿using System;

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
                if (index > Length - 1 || index < 0)
                {
                    throw new IndexOutOfRangeException();
                }
                return _array[index];
            }
            set
            {
                if (index > Length - 1 || index < 0)
                {
                    throw new IndexOutOfRangeException();
                }
                _array[index] = value;
            }
        }


        public ArrayList(int[] values)
        {
            if (values != null)
            {
                Length = values.Length;
                _array = new int[(int)(values.Length * 2)];
                for (int i = 0; i < Length; i++)
                {
                    _array[i] = values[i];
                }
            }
            else
            {
                throw new ArgumentException("Array is null");
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
        public void RemoveNElementByIndex(int index, int Nvalue)
        {
            for (int i = index + 1; i < Lenght - Nvalue; i -= Nvalue)
            {
                _array[i + Nvalue] = _array[i];
            }

            ReSize();

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
            for (int i = 0; i <= Length / 2 - 1; i++)
            {
                Swap(ref _array[i], ref _array[Length - i - 1]);
            }

        }

        //поиск значения максимального элемента
        public void SearchValueMaxElement(int value)
        {
            for (int i = 1; i < arr1.Length; i++)
            {
                if (arr1[i] > max)
                {
                    max = arr1[i];
                }
            }
            return max;
        }

        //поиск значения минимального элемента
        public void SearchValueMinElement(int value)
        {
            for (int i = 1; i < arr1.Length; i++)
            {
                if (arr1[i] < min)
                {
                    minIndex = i;
                }
            }
            return minIndex;

        }

        //поиск индекс максимального элемента
        public void SearchIndexMaxElement(int value)
        {
            for (int i = 1; i < arr1.Length; i++)
            {
                if (arr1[i] > max)
                {
                    maxIndex = i;
                }
            }
            return maxIndex;
        }

        //поиск индекс минимального элемента

        public void SearchIndexMinElement(int value)
        {
            for (int i = 1; i < arr1.Length; i++)
            {
                if (arr1[i] < min)
                {
                    minIndex = i;
                }
            }
            return minIndex;
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

        public void AddArrayList(ArrayList list)
        {
            if (list != null && list.Length != 0)
            {
                int lastIndex = Length;
                AddArrayListByIndex(list, lastIndex);
            }
            else
            {
                throw new ArgumentException("The list contains no elements");
            }
        }
        //добавление списка в начало

        public void AddArrayListToStart(ArrayList list)
        {
            if (list != null && list.Length != 0)
            {
                int firstIndex = 0;
                AddArrayListByIndex(list, firstIndex);
            }
            else
            {
                throw new ArgumentException("The list contains no elements");
            }
        }

        //добавление списка по индексу

        public void AddArrayListByIndex(ArrayList list, int index)
        {
            if (list != null && list.Length != 0)
            {
                if (index >= 0 && index <= Length)
                {
                    Length += list.Length;
                    if (Length >= _array.Length)
                    {
                        UpSize();
                    }

                    int n = list.Length;
                    for (int i = Length - 1; i >= index; i--)
                    {
                        if (i + n < _array.Length)
                        {
                            _array[i + n] = _array[i];
                        }
                    }

                    int count = 0;
                    for (int i = index; i < Length; i++)
                    {
                        if (count < list.Length)
                        {
                            _array[i] = list[count++];
                        }
                    }
                }
                else
                {
                    throw new IndexOutOfRangeException();
                }
            }
            else
            {
                throw new ArgumentException("The list contains no elements");
            }
        }



        private void Swap(ref int a, ref int b)
        {
            temp = a;
            a = b;
            b = temp;
        }
        //private void UpSize()
        //{
        //    int newLength = (int)(_array.Length * 1.33d + 1);
        //    int[] tmpArray = new int[newLength];
        //    for (int i = 0; i < _array.Length; i++)
        //    {
        //        tmpArray[i] = _array[i];
        //    }
        //}

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
