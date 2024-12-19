public class MyClass {
    public int MyMethod(int a, int b) {
        if (a == 0 && b == 0) {
            return 0; // Or throw an exception: throw new ArgumentException("Both inputs cannot be zero");
        }
        if (a == 0) {
            return b;
        }
        return a + b;
    }
}