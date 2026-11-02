/*
Student ID :1690701709
Name       :Aditap Suksamran
Section    :129B
No.        :29
Course     :GI113 Computer Programming (GI)
*/
using Unity.VisualScripting;
using UnityEngine;

public class Arrays : MonoBehaviour
{
    //part A
    [SerializeField] int[] numbers = { 12, 7, 30, 4, 19, 25, 9, 18 };
    void Start()
    {
        for (int i = 0; i < numbers.Length; i++)
        {
            Debug.Log("Number " + (i + 1) + ": " + numbers[i]);
        }
        int sum;
        float average;
        sum = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            sum += numbers[i];
        }
        average = (float)sum / numbers.Length;
        Debug.Log("Sum: " + sum);
        Debug.Log("Average: " + average);
        int maximum;
        int minimum;
        maximum = numbers[0];
        minimum = numbers[0];
        for (int i = 1; i < numbers.Length; i++)
        {
            if (numbers[i] > maximum)
            {
                maximum = numbers[i];
            }
            if (numbers[i] < minimum)
            {
                minimum = numbers[i];
            }
        }
        Debug.Log("Maximum: " + maximum);
        Debug.Log("Minimum: " + minimum);
        System.Array.Sort(numbers);
        foreach (int n in numbers)
        {
            Debug.Log("Sorted: " + n);
            //part B

        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
