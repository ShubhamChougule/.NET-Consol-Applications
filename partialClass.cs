using System;

public partial class box {
    private int w;
    private int h;

    public box(int w, int h) {
        this.w = w;
        this.h = h;
    }
}

public partial class box {
    public void areaOfRectangle() {
        Console.WriteLine("Area of Rectangle : {0}" , w * h);
    }
}


class Program {
     static void Main() {
        // creating an object of partial class box
        box obj = new box(5, 7);
        obj.areaOfRectangle();
    }
}




