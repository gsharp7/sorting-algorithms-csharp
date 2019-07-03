using System;

namespace SortingAlgo
{
    public class Program
    {
        public static void Main(string[] args)
        {   
            int[] input = {15, 25, 30, 10, 5, 40, 35, 45, 20};
            int[] sort1 = {5, 10, 20, 25, 50};
            int[] sort2 = {15, 30, 35, 40, 45};
            Console.WriteLine("#### INPUT ARRAY #####");
            printA(input);
            Console.WriteLine();
            
            //BubbleSort(input);
            //printA(input);

            //InsertionSort(input);
            //printA(input);
            
            //ShellSort(input);
            //printA(input);

            QuickSort(input, 0, input.Length - 1);
            printA(input);

            //printA(merge(sort2, sort1));
        }

        public static void BubbleSort(int[]  A){
            Console.WriteLine("#### BUBBLE SORT #####");
            for(int pass = 0; pass < A.Length - 1; pass++){
                int swap = 0;
                for(int i = 0; i < A.Length - pass - 1; i++){
                    if(A[i] > A[i + 1]){
                        int tmp = A[i];
                        A[i] = A[i + 1];
                        A[i + 1] = tmp;
                        swap++;
                    }
                }
                if(swap == 0)
                    break;
            }
            
        }

        public static void InsertionSort(int[] A){
            Console.WriteLine("#### INSERTION SORT #####");
            for(int newidx = 1; newidx < A.Length; newidx++){
                for(int i = newidx; i > 0; i--){
                    if(A[i] < A[i - 1]){
                        int tmp = A[i];
                        A[i] = A[i - 1];
                        A[i - 1] = tmp;
                    }
                    else
                        break;
                }
            }
        }

        public static void ShellSort(int[] A){
            Console.WriteLine("#### INSERTION SORT #####");
            int k = A.Length / 2, i = 0, j = i + k;
            while(j < A.Length){
                if(A[i] > A[j]){
                    int tmp = A[i];
                    A[i] = A[j];
                    A[j] = tmp;
                    if(k != A.Length / 2){
                        for(int x = i; x - k >= 0; x--){
                            if(A[x] < A[x - k]){
                                int tmp2 = A[x];
                                A[x] = A[x - k];
                                A[x - k] = tmp2;
                            }
                            else
                                break;
                        }
                    }
                }
                i++;
                j = i + k;
                if(j == A.Length){
                    if(k == 0)
                        break;
                    k /= 2;
                    i = 0;
                    j = i + k;
                }
            }
        }

        public static void QuickSort(int[] A, int start, int end){
            if(start >= end)
                return;
            int pivotidx = end, i = start, current = start;
            while(current < end){
                if(A[current] < A[pivotidx]){
                    int tmp = A[current];
                    A[current] = A[i];
                    A[i] = tmp;
                    i++;
                }
                current++;
                if(current == end){
                    int tmp = A[i];
                    A[i] = A[pivotidx];
                    A[pivotidx] = tmp;
                    break;
                }
            }
            QuickSort(A, start, i - 1);
            QuickSort(A, i + 1, end);

        }

        public static void MergeSort(int[] A){
            if(A.Length == 1)
                return;
        }

        public static int[] merge(int[] A, int[] B){
            int[] merged = new int[A.Length + B.Length];
            int i = 0, a = 0, b = 0;
            for(; i < merged.Length; i++){
                if(A[a] < B[b]){
                    merged[i] = A[a];
                    a++;
                    if(a == A.Length){
                        while(b < B.Length){
                            i++;
                            merged[i] = B[b];
                            b++;
                        }
                        break;
                    }
                }
                else{
                    merged[i] = B[b];
                    b++;
                    if(b == B.Length){
                        while(a < A.Length){
                            i++;
                            merged[i] = A[a];
                            a++;
                        }
                        break;
                    }
                }
            }
            return merged;
        }

        public static void BucketSort(){

        }

        public static void RadixSort(){
            
        }



        public static void printA(int[] A){
            foreach(var i in A)
                Console.Write(i + " ");
            Console.WriteLine();
        }
    }
}
