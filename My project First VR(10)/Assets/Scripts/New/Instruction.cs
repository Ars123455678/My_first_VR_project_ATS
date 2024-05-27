using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Instruction : MonoBehaviour
{
    [SerializeField] private InstructionList[] lists;

    [SerializeField] private string[] texts;
    [SerializeField] private Texture[] screens;

    private int pointer = 0;

    private void Start()
    {
        for (int i = 0; i < lists.Length; i++)
        {
            lists[i].gameObject.SetActive(true);
            lists[i].Setup(texts[i], screens[i], i + 1);
            lists[i].gameObject.SetActive(false);
        }
        lists[0].gameObject.SetActive(true);
    }


    public void Next()
    {
        lists[pointer].gameObject.SetActive(false);
        pointer++;
        if (pointer >= lists.Length)
        {
            pointer = lists.Length - 1;
        }
        lists[pointer].gameObject.SetActive(true);
    }
    public void Previous()
    {
        lists[pointer].gameObject.SetActive(false);
        pointer--;
        if (pointer < 0)
        {
            pointer = 0;
        }
        lists[pointer].gameObject.SetActive(true);
    }
}
