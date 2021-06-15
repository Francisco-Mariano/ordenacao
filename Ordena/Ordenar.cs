using System;
using System.Collections.Generic;
using System.Text;

namespace Ordena
{
    public class Ordenar
    {
        private int Bigger(int[] v, int tam)
        {
            int bigger = int.MinValue;
            for (int i = 0; i <= tam; i++)
                bigger = Math.Max(bigger, v[i]);
            return bigger;
        }

        private int Qsort(int[] v, int left, int right, int cont)
        {
            int i = left, j = right;
            int pivotIndex = (i+j) / 2;
            int pivot = v[pivotIndex];                         

            while(i<=j)
            {
                while (v[i] < pivot)
                {
                    i++;
                   // if (i == right) break;
                }

                while (v[j] > pivot)
                {
                    j--;
                    //if (j == left - 1) break;
                }
                

                if (i <= j)
                {                    
                    cont = v[i] == v[j]? cont : cont + 1;
                    int aux = v[i];
                    v[i] = v[j];
                    v[j] = aux;
                    j--;
                    i++;
                }

            } 

            //if (i == j) 
            //    return 0;
            if (left < j)
                cont = Qsort(v, left, j, cont);
            if (right > i)
                cont = Qsort(v, i, right, cont);

            return cont;
                       
        }

        private void Msort(int[] v, int begin, int end)
        {
            if(begin == end) return;
            int m = (begin + end) / 2;            

            Msort(v, begin, m);
            Msort(v, m+1, end);

            int l = begin;
            int r = m+1;
            int[] vtemp = new int[v.Length];

            for (int i = begin; i < end + 1; i++)
            {
                if (r > end || (l <= m && v[l] <= v[r]))
                {
                    vtemp[i] = v[l];
                    l++;
                }
                else
                {
                    vtemp[i] = v[r];
                    r++;
                }
            }

            for (int i = begin; i < end + 1; i++)
                v[i] = vtemp[i]; ;

        }

        // Método Bolha
        public void BubbleOrder(int[] v)
        {
            bool swap = true;
            while (swap)
            {
                swap = false;
                for (int i = 0; i < v.Length - 1; i++)
                {
                    if (v[i] > v[i + 1])
                    {
                        swap = true;
                        int aux = v[i];
                        v[i] = v[i + 1];
                        v[i + 1] = aux;
                    }
                }
            } //while

        }

        // Inserção
        public void InsertOrder(int[] v)
        {
            for (int i = 1; i < v.Length; i++)
            {
                int j = i - 1;
                int key = v[i];
                while (j >= 0 && v[j] > key)
                {
                    v[j + 1] = v[j];
                    j -= 1;
                }
                v[j + 1] = key;
            }
        }

        // Seleção
        public void SelectionOrder(int[] v)
        {
            for (int i = v.Length - 1; i >= 0; i--)
                v[i] = Bigger(v, i);
        }

        // Quick Sort
        public int QuickSortOrder(int[] v)
        {
            return Qsort(v, 0, v.Length -1 , 0);
        }

        // Merge Sort
        public void MergeSortOrder(int[] v)
        {
            Msort(v, 0, v.Length - 1);
        }

        public int QuickSortOrderNinja(int[] dados)
        {
            int m = dados.Length / 2,  cont =0;            
            return Qsort2(dados, 0, dados.Length - 1, 0);
        }

        private int Qsort2(int[] v, int left, int right, int cont)
        {
            int i = left, j = right;
            int pivotIndex = (i + j) / 2;
            int pivot = v[pivotIndex];

            do
            {
                while (v[i] < pivot)
                {
                    i++;                    
                }

                while (v[j] > pivot)
                {
                    j--;                    
                }                                

                if (i < j)
                {                    
                    int aux = v[i];
                    v[i] = v[j];
                    v[j] = aux;
                    j--;
                    i++;
                }
                else if (i == j)
                {
                    j++;
                    i--;
                }

            } while (i < j);

            if (left < j)
                cont = Qsort(v, left, j, cont);
            if (right > i)
                cont = Qsort(v, i, right, cont);

            return cont;

        }
    }
}