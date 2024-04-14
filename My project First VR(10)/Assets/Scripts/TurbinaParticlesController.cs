using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurbinaParticlesController : MonoBehaviour
{
    private int state;

    public GameObject particles;
    public GameObject fireParticles;
    public GameObject airParticles;

    public void OnFuelButtonClicked()
    {
        if (state == 0)
        {
            particles.SetActive(true);
            state = 1;
        }
    }
    public void OnAirButtonClicked()
    {
        if (state == 0)
        {
            airParticles.SetActive(true);
            state = 1;
        }
    }

    public void OnFireFuelButtonClicked()
    {
        if (state == 1)
        {
            fireParticles.SetActive(true);
            particles.SetActive(false);
            state = 2;
        }
    }

    public void OnStopButtonClicked()
    {
        if (state == 1 || state == 2)
        {
            fireParticles.SetActive(false);
            particles.SetActive(false);
            airParticles.SetActive(false);
            state = 0;
        }
    }
}
