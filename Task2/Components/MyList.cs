
namespace Task2
{
    class MyList<T> : IMyInterface<T>
    {
        T[] array = new T[default];

        public T this[int index] { get { return array[index]; } }

        public void Add(T arg)
        {
            T[] arrayTemp = new T[array.Length + 1];
            
            for (int i = 0; i < array.Length; i++)
                arrayTemp[i] = array[i];

            arrayTemp[array.Length] = arg;

            array = arrayTemp;
        }

        public int Length { get { return array.Length; } }
    }
}
