import java.util.Scanner;

public class LalaCalculator {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

    
        int age = 19;

        if (age >= 18) {
            System.out.println("You are an adult.");
        } else if (age >= 13) {
            System.out.println("You are a teenager.");
        } else {
            System.out.println("You are a child.");
        }

        scanner.close();
    }
}
