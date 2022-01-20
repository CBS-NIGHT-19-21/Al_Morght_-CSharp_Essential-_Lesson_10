
namespace Task4
{
    static class Extention
    {
        public static T[] GetArray<T>(this MyList<T> list)
        {
            T[] array = new T[list.Length];

            for (int i = 0; i < array.Length; i++)
                array[i] = list[i];

            return array;
        }
    }
}
