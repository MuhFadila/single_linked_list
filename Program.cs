using System;

namespace single_linked_list
{
    // each node consist of the information part and lik to thr next mod

    class Node
    {
        public int rollNumber;
        public string name;
        public Node next;
    }
    class List
    {
        Node START;

        public List()
        {
            START = null;
        }
    }
}
