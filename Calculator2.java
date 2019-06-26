package jack;
import java.util.Scanner; 

public class Calculator2 {
	public static void main(String args[]) {
		System.out.println("Welcome to the calculator application");
		int number1=0;
		int number2=0;
		Scanner sc=new Scanner(System.in);
		System.out.println("Enter the first number");
		number1=sc.nextInt();
		System.out.println("Enter the second number");
		number2=sc.nextInt();
		sc.close();
		System.out.println("Addition result of "+number1+" and "+number2+" is "+(number1+number2));
		System.out.println("Subtraction result of "+number1+" and "+number2+" is "+(number1-number2));
		System.out.println("Multiplication result of "+number1+" and "+number2+" is "+(number1*number2));
		System.out.println("Division result of "+number1+" and "+number2+" is "+(number1/number2));
	}
}
