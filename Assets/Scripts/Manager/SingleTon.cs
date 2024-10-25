using UnityEngine;

public class SingleTon<T> : MonoBehaviour where T : Component
{
    static private T instance;

    static public T Instance
    {
        get
        {
            if (instance == null)
            {
                GameObject singleTonObject= new GameObject(typeof(T).Name);
                instance = singleTonObject.AddComponent<T>();
            }
            return instance;
        }
    }
    protected virtual void Awake()
    {
        if(instance == null)
        {
            instance = this as T;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}