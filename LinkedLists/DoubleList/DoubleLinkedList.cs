using Shared;


namespace DoubleList;

public class DoubleLinkedList<T> : ILinkedList<T>
{
    private Node<T>? _head;
    private Node<T>? _tail;
    public DoubleLinkedList()
    {
        _head = null;
        _tail = null;
    }
    public bool Contains(T data)
    {
        throw new NotImplementedException();
    }

    public void InsertAtBeginning(T data)
    {
        var NewNode = new Node<T>(data);
        if (_head == null)
        {
            _head = NewNode;
            _tail = NewNode;
        }
        else
        {
            NewNode.Next = _head;
            _head.Previous = NewNode;
            _head = NewNode;
        }
    }

    public void InsertAtEnd(T data)
    {
        throw new NotImplementedException();
    }

    public void Remove(T data)
    {
        throw new NotImplementedException();
    }

    public void Reverse()
    {
        throw new NotImplementedException();
    }

    override public string ToString()
    {

        var current = _head;
        var result = string.Empty;
        while (current != null)
        {
            result += $"{current.Data} -> ";
            current = current.Next;
        }
        result += "null";
        return result;
    }
}

