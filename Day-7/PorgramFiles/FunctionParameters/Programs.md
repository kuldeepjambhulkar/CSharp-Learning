**Method Parameters, pass by value, pass by reference example**
```C#
using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int i = 10;
        Console.WriteLine(i);
        //passByValue(i);
        passByReference( ref i);
        Console.WriteLine(i);
    }
    
    public static void passByValue(int i) {
        i = 20;
        Console.WriteLine(i);
    }
    public static void passByReference( ref int i) {
        i = 20;
        Console.WriteLine(i);
    }
}
```

**Out parameter example**
```C#
using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int i = 100;
        int j = 200;
        int sum = 0;
        Console.WriteLine(DemoMethodOutParam(i, j, out sum));
        
    }
    
    public static int DemoMethodOutParam (int i, int j, out int sum) {
        sum = i + j;
        return sum;
    }
}
```


**Where `in` parameter comes into picture**
![image](https://user-images.githubusercontent.com/89466207/204211516-bd09c5b1-6483-48c8-b552-078e2d25a2f7.png)

```C#
using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int i = 100;
        int j = 200;
        int sum = 10;
        Console.WriteLine(DemoMethodOutParam(i, j, in sum));
        
    }
    
    public static int DemoMethodOutParam (int i, int j, in int sum) {
        //we cannot do this, since it is a readOnly variable 
        sum = 78;
        return i+j;
    }
}
```