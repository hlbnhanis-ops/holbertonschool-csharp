
public class Node<T>
{
    public T value;
    public Node<T> next;

    public Node(T value)
    {
        this.value = value;
        this.next = null;
    }
}

/// <summary>
/// 
/// </summary>
/// <typeparam name="T"></typeparam>
public class Queue<T>
{

    public Node<T> Head{get; private set;}
    public Node<T> Tail{get; private set;}
    public int count;

    public int Count()
    {
        return count;
    }

    public Queue()
    {
        Head = null;
        Tail = null;
        count = 0;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    public string CheckType()
    {
        return typeof(T).ToString(); 
    }

    public void Enqueue(T value)
    {
        Node<T> newNode = new Node<T>(value);

        if(Head == null)
        {
            Head = newNode;
            Tail = newNode;
        }
        else
        {
            Tail.next = newNode;
            Tail = newNode;
        }

        count++;
    }
}
