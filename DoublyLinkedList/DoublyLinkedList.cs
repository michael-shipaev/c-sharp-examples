using System;

namespace DataStructures
{
    public class DoublyLinkedList
    {
        public int Count { get; private set; }

        public ListElement First { get; private set; }

        public ListElement Last { get; private set; }

        public ListElement AddFirst(string value)
        {
            var elementToAdd = new ListElement(value, this);

            elementToAdd.NextElement = First;
            First = elementToAdd;

            if (Last == null)
            {
                Last = elementToAdd;
            }
            Count++;

            return elementToAdd;
        }

        public ListElement AddLast(string value)
        {
            var elementToAdd = new ListElement(value, this);

            // TODO Implementation
            return elementToAdd;
        }

        public string GetAndRemoveFirst()
        {
            // TODO Implementation

            // Do not forget to DetachElement
            return null;
        }

        public string GetAndRemoveLast()
        {
            // TODO Implementation

            // Do not forget to DetachElement
            return null;
        }

        public void InsertAfter(ListElement element, string value)
        {
            ValidateElement(element);
            
            // TODO Implementation
        }

        public void RemoveElement(ListElement element)
        {
            ValidateElement(element);
            // TODO Implementation

            // After removing element from list
            // we need to nullify its OwnerList property to make it impossible
            // using it again with methods of our list after removing from the list:
            DetachElement(element);
        }

        private void ValidateElement(ListElement element)
        {
            if (element.OwnerList != this)
                throw new ElementNotIsListException();
        }

        private void DetachElement(ListElement element)
        {
            element.OwnerList = null;
            element.PreviousElement = null;
            element.NextElement = null;
        }
    }

    public class ListElement
    {
        internal ListElement(string value, DoublyLinkedList ownerList)
        {
            Value = value;
            OwnerList = ownerList;
        }

        internal DoublyLinkedList OwnerList { get; set; }

        public ListElement PreviousElement { get; internal set; }

        public ListElement NextElement { get; internal set; }

        public string Value { get; private set; }
    }

    public class LinkedListException : Exception { }

    public class ListIsEmptyException : LinkedListException { }

    public class ElementNotIsListException : LinkedListException { }
}
