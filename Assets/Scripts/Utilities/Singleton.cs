using UnityEngine;

public abstract class Singleton<T> : MonoBehaviour where T: Singleton<T> 
{
    public static T instance { get; private set; }

    protected void InitializeSingleton(T singletonInstance)
    {
        if (instance != null && !instance.Equals(singletonInstance))
        {
            Destroy(singletonInstance);
            return;
        }
        
        instance = singletonInstance;
    }
}
