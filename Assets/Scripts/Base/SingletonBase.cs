using UnityEngine;
public class SingletonBase<T> : MonoBehaviour where T : Component 
{
    private T instance;
    public T Instance
    {
        get
        {
            instance = (T)FindObjectOfType(typeof(T));
            if (instance == null)
            {
                var newObject = new GameObject(typeof(T).ToString()).AddComponent<T>();
                DontDestroyOnLoad( newObject );
            }
            
            return instance;
        }
    }

    public void Init()
    {
    }

}

