using UnityEngine;

public class SingleTonBase<T> : MonoBehaviour where T : Component
{
    public T instance;

    public T Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new GameObject().AddComponent<T>();
            }
            return instance;
        }
    }
    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }
}