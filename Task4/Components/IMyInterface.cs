﻿
namespace Task4
{
    interface IMyInterface<T>
    {
        void Add(T arg);
        T this[int index] { get; }
        int Length { get; }
    }
}
