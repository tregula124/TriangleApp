namespace TriangleApp;

public class TriangleChecker
{
    public bool IsTriangle(int a, int b, int c)
    {
        // Check if side lengths are positive numbers
        if (a <= 0 || b <= 0 || c <= 0)
        {
            throw new ArgumentException("Side lengths are not positive numbers.");
        }

        // Check for triangle inequality
        return (a + b > c) && (a + c > b) && (b + c > a);
    }
}
