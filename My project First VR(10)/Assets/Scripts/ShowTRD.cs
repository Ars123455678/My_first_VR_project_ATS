using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowTRD : MonoBehaviour
{
    private int state;

    public GameObject particles;
    public GameObject airParticles;

    public void OnFuelButtonClicked()
    {
        if (state == 0)
        {
            particles.SetActive(true);
            airParticles.SetActive(false);
            state = 1;
        }
    }
    public void OnAirButtonClicked()
    {
        if (state == 1)
        {
            airParticles.SetActive(true);
            particles.SetActive(false);
            state = 0;
        }
    }
}