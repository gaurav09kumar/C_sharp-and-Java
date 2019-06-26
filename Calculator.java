package jack;
import java.util.Scanner; 


public class Calculator {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		
		System.out.println("Welcome to the calculator application");
		int number1=0;
		int number2=0;
		Scanner sc=new Scanner(System.in);
		try {
		System.out.println("Enter the first number");
		number1=sc.nextInt();
		System.out.println("Enter the second number");
		number2=sc.nextInt();
		System.out.println("Enter the operation which u want to execute: + , - , * , /");
		char operator=sc.next().charAt(0);
		
		sc.close();
		
		int output=0;
		
		switch(operator)
		{
		case '+':
			output=number1+number2;
			break;
		case '-':
			output=number1-number2;
			break;
		case '*':
			output=number1*number2;
			break;
		case '/':
			output=number1/number2;
			break;
		default:
			System.out.println("Enter proper operator");
			return;

		}
		System.out.println(number1+" "+operator+" "+number2+": is "+output);
		}
		catch(Exception a) {
			System.out.println("Enter proper data");
			
		}

	}

}
