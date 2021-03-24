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
            Length++;

            Node first = new Node(value);

            first.Next = _root;
            _root = first;
        }


        //добавление значения по индексу

        public void AddValueByIndex(int value, int index)
        {
            if (Length != 0)
            {
                Node ByIndex = new Node(value);

                Node current = GetNodeByIndex(index - 1);

                ByIndex.Next = current.Next;
                current.Next = ByIndex;
            }
            else
            {
                _root = new Node(value);
                _tail = _root;
            }

            Length++;
        }

        //удаление из конца одного элемента

        public void RemoveElementFromEnd()
        {
            RemoveElementByIndex(Length-1);

        }

        //удаление из начала одного элемента
        public void RemoveElementFromStart()
        {
            _root = _root.Next;
        }

        //удаление по индексу одного элемента

        public void RemoveElementByIndex(int index)
        {
            Node current = _root;

            for (int i = 1; i < index; i++)
            {
                current = current.Next;
            }

            current.Next = current.Next.Next;

            Length--;
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


        //добавление списка(вашего самодельного) в конец
        public void AddArrayList(ArrayList list)
        {
           
        }

        //добавление списка в начало

        public void AddArrayListToStart(ArrayList list)
        {
           
        }
       
        //добавление списка по индексу
        public void AddArrayListByIndex(ArrayList list, int index)
        { }









        public void SortAscending(bool v)
        {

        }
        private Node GetNodeByIndex(int index)
        {
            Node current = _root;

            for (int i = 1; i <= index; i++)
            {
                current = current.Next;
            }
            return current;
        }

        public override string ToString()
        {
            if (Length != 0)
            {
                Node current = _root;
                string s = current.Value + " ";

                while (current.Next! is null)
                {
                    current = current.Next;
                    s += current.Value + " ";
                }
                return s;
            }
            else
            {
                return String.Empty;
            }
        }


        public override bool Equals(object obj)
        {
            if (obj is LinkedList || obj is null)
            {
                LinkedList list = (LinkedList)obj;
                bool isEqual = false;

                if (this.Length == list.Length)
                {
                    isEqual = true;
                    Node currentThis = this._root;
                    Node currentList = list._root;

                    while (!(currentThis is null))
                    {
                        if (currentThis.Value != currentList.Value)
                        {
                            isEqual = false;
                            break;
                        }

                        currentThis = currentThis.Next;
                        currentList = currentList.Next;
                    }
                }

                return isEqual;
            }

            throw new ArgumentException("obj is not LinkedList");
        }
    }
}
