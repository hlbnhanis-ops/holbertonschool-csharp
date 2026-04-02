
public class Node<T>
{
    /// <summary>
    /// 
    /// </summary>
    public T value;
    
    /// <summary>
    /// 
    /// </summary>
    public Node<T> next;

    /// <summary>
    /// 
    /// </summary>
    /// <param name="value"></param>
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

    /// <summary>
    /// 
    /// </summary>
    public Node<T> Head{get; private set;}
    /// <summary>
    /// 
    /// </summary>
    public Node<T> Tail{get; private set;}
    // ?
    public int count;

    /// <summary>
    ///
    /// </summary>
    /// <returns></returns>
    public int Count()
    {
        return count;
    }

    /// <summary>
    /// 
    /// </summary>
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

    /// <summary>
    /// 
    /// </summary>
    /// <param name="value"></param>
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
