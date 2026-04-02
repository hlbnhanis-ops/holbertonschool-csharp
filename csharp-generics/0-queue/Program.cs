/// <summary>
/// 
/// </summary>
/// <typeparam name="T"></typeparam>
public class Queue<T>
{
    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    public string CheckType()
    {
        return typeof(T).ToString();
    }
}
