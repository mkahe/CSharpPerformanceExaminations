using System;

namespace CSharpPerformanceExaminations
{
    public class CopyToVSClone : IPerformanceExamination
    {
        public void DoWork()
        {
            int[] myArray = new int[]{1,2,3,4,5};
            int[] copy = new int[6];
            int[] clone = new int[5];
            myArray.CopyTo(copy, 1);
            clone = (int[]) myArray.Clone();
            copy[0] = 444;
            clone[0] = 500;
            Console.WriteLine("Array is: " + string.Join(", ", myArray));
            Console.WriteLine("Clone is: " + string.Join(", ", clone));
            Console.WriteLine("Copy is: " + string.Join(", ", copy));
        }
    }
}