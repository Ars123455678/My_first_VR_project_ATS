using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instruction : MonoBehaviour
{
    [SerializeField] private GameObject[] lists;

    private int pointer = 0;

    public void Next()
    {
        lists[pointer].SetActive(false);
        pointer++;
        if (pointer >= lists.Length)
        {
            pointer = lists.Length - 1;
        }
        lists[pointer].SetActive(true);
    }
    public void Previous()
    {
        lists[pointer].SetActive(false);
        pointer--;
        if (pointer < 0)
        {
            pointer = 0;
        }
        lists[pointer].SetActive(true);
    }
}
