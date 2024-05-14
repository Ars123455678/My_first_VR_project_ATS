using System.Collections.Generic;
using System.Net.Sockets;
using TMPro;
using UnityEngine;
using UnityEngine.UI; 

public class InformationComponent : MonoBehaviour, IInteractable
{
    private GameObject textGo;
    private Player player;
    
    public string componentName;

    private bool isActive;

    private void Start()
    { 
        textGo = transform.GetChild(0).gameObject;
        textGo.SetActive(false);

        Vector3 scale = textGo.transform.localScale;
        scale.x *= -1f;
        textGo.transform.localScale = scale;
    }

    private void Update()
    {
        if (isActive)
        {
            textGo?.transform.LookAt(player.transform.position);
        }
    }

    public void Interact(Player player)
    {

    }

    public void Enter(Player player)
    {
        this.player = player;
        isActive = true;
        textGo.SetActive(true);
        textGo.transform.LookAt(player.transform.position);
    }

    public void Exit(Player player)
    {
        isActive = false;
        textGo.SetActive(false);
    }
}