var singleton = SingletonClass.GetInstance();


public class SingletonClass
{
    public static SingletonClass instance;      // storing the static instance of this class
    
    private SingletonClass(){}             // creating the private constructor that forbid to create the object outside this class

    public static SingletonClass GetInstance()   // static method for getting this one instance
    {
        if (instance == null)
            instance = new SingletonClass();
        return instance;
    }
}