using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenClosePanel : MonoBehaviour
{
    public GameObject panel;
    private int state;


    public void OnPanel()
    {
        if (state == 0)
        {
            panel.SetActive(true);
            state = 1;
        }
        if (state == 1)
        {
            panel.SetActive(false);
            state = 0;
        }
    }
}