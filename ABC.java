package jack;
class Demo{
	Demo(){
		System.out.println("1");
	}
	Demo(int i){
		System.out.println(i);
	}
	Demo(int a, int b){
		System.out.println(a+b);
	}
}
public class ABC {
	
	public static void main(String[] args) {
		// TODO Auto-generated method stub
		Demo d1=new Demo();
		Demo d2=new Demo(1);
		Demo d3=new Demo(1,2);
	}

}