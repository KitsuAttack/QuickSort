public static class QuickSort
    {
        public static void QuickSortConventional<T>(this T[]arr,int start,int end) where T:IComparable<T>
        {
            if ((end - start) < 1)
            {
                return;
            }
            int divIndex = start;
            bool hasElements = false;
         
            for (int i = start; i < end; i++)
            {
                if (arr[i].CompareTo(arr[end]) >= 0)
                {
                    if (arr[i + 1].CompareTo(arr[end]) < 0)
                    {
                        
                        arr.Swap(divIndex, i + 1);
                        divIndex++;
                    }
                    hasElements = true;
                }
                else
                {
                    divIndex++;
                }
            }
            if (hasElements)
            {
                arr.Swap(divIndex, end);
                arr.QuickSortConventional(start, divIndex - 1);
                arr.QuickSortConventional(divIndex + 1, end);
            }
            else
            {
                arr.QuickSortConventional(start, divIndex-1);
            }   
        }

        private static void Swap<T>(this T[]arr,int x,int y)
        {
            T temp = arr[x];
            arr[x] = arr[y];
            arr[y] = temp;
        }
    }
