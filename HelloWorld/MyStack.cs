namespace HelloWorld
{
   
    class MyStack<T>
    {
        MyArray<T>  stack = new MyArray<T>();
       private int head = -1;

        public bool isEmpty()
        {
            return head == -1;
        }
        public void push(T elem)
        {
            head++;
            stack.AddElementTo(elem, head);
        }

        public T peek()
        {
            return isEmpty() ? default(T) : stack.GetDeletedAtElem(head);
        }

        public T pop()
        {
            if (isEmpty()) return default (T);
            head--;
            return stack.GetDeletedAtElem(head + 1);
        }
    }
}
