package jack;

class Z
{
     Z()
     {
          //By Default, Compile will keep super() calling statement here.
          System.out.println("First Constructor");
     }
     Z(int i)
     {
         super();

          //Compiler will not keep any statement here
          System.out.println("Second Constructor");
     }
     Z(int i, int j)
     {
          //Compiler will not keep any statement here
    	 
          this();
          System.out.println("Third Constructor");
     }
     Z(int i, int j, int k)
     {
    	 this(6);
          System.out.println("Fourth Constructor");
          // super(); It will give error if you keep super() here
     }
}
public class Constructor1
{
    public static void main(String args[]){
        Z a1=new Z();
        Z a2=new Z(5);
        Z a3=new Z(4,7);
        Z a4=new Z(1,2,3);
    }
    
    
}