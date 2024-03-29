﻿using System;

///<summary>Queue Class</summary>
class Queue<T>
{
    private Node head = null;
    private Node tail = null;
    private int count = 0;
    ///<summary>Returns the Queue’s type</summary>
    public Type CheckType()
    {
        return typeof(T);
    }

    ///<summary>Class Node</summary>
    public class Node
    {
        public T value { set; get; }
        public Node next { set; get; }

        public Node(T value)
        {
            this.value = value;
            this.next = null;
        }
    }

    ///<summary>Creates a new Node and adds it to the end of the queue</summary>
    public void Enqueue(T t)
    {
        Node n = new Node(t);
        n.next = null;
        if (head == null)
            head = tail = n;
        else
        {
            tail.next = n;
            tail = n;
        }
        count++;
    }

    ///<summary>Returns the number of nodes in the Queue.</summary>
    public int Count()
    {
        return count;
    }
}
