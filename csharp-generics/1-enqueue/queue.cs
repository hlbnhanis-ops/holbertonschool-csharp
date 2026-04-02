
public class Node<T>
{
    public T value;
    public Node<T> next;

    public Node(T value)
    {
        this.value = T;
        this.next = null;
    }
}

/// <summary>
/// 
/// </summary>
/// <typeparam name="T"></typeparam>
public class Queue<T>
{

    public Node<T> Head{get;}
    public Node<T> Tail{get;}
    public int Count{get;}

    public Queue()
    {
        Head = null;
        Tail = null;
        Count = 0;
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

        Count++;
    }
}
