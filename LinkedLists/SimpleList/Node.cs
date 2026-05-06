namespace SimpleList;

public class Node<T>
    
{
    public Node(T Data)
    {
        Data = data;
        Next = null;
    }
    public T? Data{ get; set; }

    public Node<T>? Next { get; set; }
}
