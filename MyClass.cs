public class MyClass {
    public int MyMethod(int a, int b) {
        if (a == 0) {
            return b; // This is incorrect if b is also 0
        }
        return a + b;
    }
}