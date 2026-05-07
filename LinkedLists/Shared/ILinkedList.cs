namespace Shared;

public interface ILinkedList<T>
{
    bool Contains(T data);

    void InsertAtBeginning(T data);

    void InsertAtEnd(T data);
    void Remove(T data);

    void Reverse();

    string ToString();
}
