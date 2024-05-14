using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteractor : MonoBehaviour
{
    [SerializeField] private Transform cam;
    [SerializeField] private float range;

    private Player player;
    private IInteractable last;

    private void Start()
    {
        player = GetComponent<Player>(); 
    }

    private void Update()
    {
        if (Physics.Raycast(cam.position, cam.forward, out RaycastHit hit))
        {
            if (hit.collider.TryGetComponent(out IInteractable interactable))
            {
                if (last != interactable)
                { 
                    interactable.Enter(player);
                    last?.Exit(player);
                    last = interactable;
                } 
            }
        } 
    } 

    public bool Interact<T>() where T : IInteractable
    {
        RaycastHit[] hits = Physics.RaycastAll(cam.position, cam.forward, range);
        if (hits.Length > 0)
        { 
            foreach (RaycastHit hit in hits)
            {
                if (hit.collider.TryGetComponent(out IInteractable interactable) && interactable is T)
                {
                    interactable.Interact(player);
                    return true;
                }
            }
        }
        return false;
    }
}
