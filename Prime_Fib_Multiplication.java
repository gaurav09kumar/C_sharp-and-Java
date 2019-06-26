package jack;

public class Prime_Fib_Multiplication {
	public static void PrimeNum() {
		System.out.println("Prime numbers between 1 and 500 are:");
		for(int i=1;i<=500;i++) {
		int count=0;
		for(int n=1;n<=i;n++) {
			if(i%n==0) {
				count++;
			}
		}
		if(count==2) {
			System.out.println(i);
		}
		}
	}
	public static void fibonacci() {
		System.out.println("Fibonacci series is:");
		int n1 = 0, n2 = 1, num;
        System.out.print(n1 + " " +
                n2 + " ");
 
        for (int i = 0; i < 10; i++) {
            num = n2 + n1;
            System.out.print(num + " ");
            n1 = n2;
            n2 = num;
        }
	}
	public static void main(String args[]) {
		PrimeNum();
		fibonacci();
	}
}
