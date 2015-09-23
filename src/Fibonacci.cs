namespace CSharp.Training
{
    public class Fibonacci
    {
        private Func<int, int> fib;
        
        public object this[int nth]
        {
            get
            {
                fib = n => n > 1 ? fib(n - 1) + fib(n - 2) : n;
                return fib( nth );
            }
        }
    }
}
