﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_3_Sort
{
    class Sorting
    {
        public static void BubbleSort(int[] arr)
        {
            int i = 0;
            bool swap_cnt = false;

            if (arr.Length == 0)
                return;

            while (i < arr.Length)
            {
                if (i + 1 != arr.Length && arr[i] > arr[i + 1])
                {
                    Swap(ref arr[i], ref arr[i + 1]);
                    swap_cnt = true;
                }
                i++;
                if (i == arr.Length && swap_cnt)
                {
                    swap_cnt = false;
                    i = 0;
                }
            }
        }

        static void Swap<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }
    }
}