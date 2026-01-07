using System;

class Int{

    public static void divide(int a, int b){
        try{
            int result = a / b;
            Console.WriteLine("{0} / {1} = {2}", a, b, result);
        }
        catch{
            Console.WriteLine("Cannot divide by zero");
        }
    }
}
