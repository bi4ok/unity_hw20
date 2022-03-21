using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = System.Random;

public class HomeworkSorting : MonoBehaviour
{
    void Start()
    {
        int[] rndArray = SetArray(50);
        Debug.Log(string.Join(" ", rndArray));
        int[] sortedArray = ChooseSorting(rndArray);
        Debug.Log("===================");
        Debug.Log(string.Join(" ", sortedArray));

    }

    private int[] SetArray(int length)
    {
        int[] arr = new int[length];
        Random rnd = new Random();

        for (int i = 0; i < length; i++)
        {
            arr[i] = rnd.Next(-100, 100);
        }

        return arr;
    }


    private int[] ChooseSorting(int[] arrayToSort)
    {

        for (int i = 0; i < arrayToSort.Length - 1; i++)
        {
            var min_i_value = arrayToSort[i];
            var min_i_index = i;
            for (int j = i + 1; j < arrayToSort.Length; j++)
            {
                if (arrayToSort[j] < min_i_value)
                {
                    min_i_value = arrayToSort[j];
                    min_i_index = j;
                }
            }

            if (min_i_index != i)
            {

                var buffer = arrayToSort[i];
                arrayToSort[i] = arrayToSort[min_i_index];
                arrayToSort[min_i_index] = buffer;
            }

        }

        return arrayToSort;
    }
}
