namespace IMQ1.Caching.Fibonacci.Library
{
    public class Fibonacci
    {
        public ICacher _cacher;

        public Fibonacci()
        {
            _cacher = new CustomMemmoryCache();
        }

        public int Generate(int quantity)
        {

            if (quantity <= 0)
            {
                return 0;
            }

            if (quantity <= 2)
            {
                return 1;
            }
            else
            {
                var firstValue = _cacher.GetValue((quantity - 2).ToString());
                if (firstValue == null)
                {
                    firstValue = Generate((quantity - 2));
                    _cacher.SetValue((quantity - 2).ToString(), firstValue);
                }

                var secondValue = _cacher.GetValue((quantity - 1).ToString());
                if (secondValue == null)
                {
                    secondValue = Generate((quantity - 1));
                    _cacher.SetValue((quantity - 1).ToString(), secondValue);
                }

                return (int)firstValue + (int)secondValue;
            }
        }
    }
}
