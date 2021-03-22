using System;
using System.Collections.Generic;
using System.Text;

namespace List
{
    public class LinkedList
    {
        public int Length { get; private set; }

        public int this[int index]
        {
            get
            {
                Node current = _root;

                for(int i = 1; i<=index; i++)
                {
                    current = current.Next;
                }

                return current.Value;
            }
            set
            {
                Node current = _root;

                for (int i = 1; i <= index; i++)
                {
                    current = current.Next;
                }
                current.Value = value;
            }
        }

        private Node _root;
        private Node _tail;

        public LinkedList()
        {
            Length = 0;
            _root = null;
            _tail = null;

        }

        public LinkedList(int value)
        {
            Length = 1;
            _root = new Node(value);
            _tail = _root;
        }

        public LinkedList(int[] values)
        {
            Length = values.Length;

            if  (values.Length != 0)
            {
                _root = new Node(values[0]);
                _tail = _root;

                for (int i = 1; i < values.Length; i++)
                {
                    _tail.Next = new Node(values[i]);
                }
            }
            else
            {
                _root = null;
                _tail = null;
            }
        }






        //добавление значения в конец
        public void Add(int value)
        {
            Length++;
            _tail.Next = new Node(value);
            _tail = _tail.Next;
        }

        //добавление значения в начало

        public void AddToStart(int value)
        {
            
        }

        //добавление значения по индексу

        public void AddValueByIndex(int value, int index)
        {
           
          
        }

        //удаление из конца одного элемента

        public void RemoveElementFromEnd()
        {
          

        }

        //удаление из начала одного элемента
        public void RemoveElementFromStart()
        {
           
        }

        //удаление по индексу одного элемента

        public void RemoveElementByIndex(int index)
        {
          

        }


        //удаление из конца N элементов
        public void RemoveNElementsFromEnd(int Nvalue)
        {
           
        }


        //удаление из начала N элементов
        public void RemoveNElementsFromStart(int Nvalue)
        {
          

        }

        //удаление по индексу N элементов
        public void RemoveNElementByIndex(int index, int Nvalue)
        {
            
        }


        //первый индекс по значению
        public void SearchFirstIndexByValue(int value)
        {
           

        }

        //реверс(123 -> 321)

        public void ReverseArray(int value)
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

        public void RemoveElementByValue(int value)
        {
           
        }

        public void SearchIndexMaxElement(object value)
        {
            
        }

        //удаление по значению всех(?вернуть кол-во)

        public void RemoveAllElementsByValue(int value)
        {
            
        }



        //3 конструктора(пустой, на основе одного элемента, на основе массива )



        //добавление списка(вашего самодельного) в конец
        public void AddArrayList(ArrayList list)
        {
           
        }
        //добавление списка в начало

        public void AddArrayListToStart(ArrayList list)
        {
           
        }

        public void SortAscending(bool v)
        {
            
        }


        //добавление списка по индексу
        public void AddArrayListByIndex(ArrayList list, int index)
        { }
    }
}
