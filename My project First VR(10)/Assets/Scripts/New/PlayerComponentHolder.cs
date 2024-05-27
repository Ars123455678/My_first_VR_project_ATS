using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Transactions;
using UnityEngine;

public class PlayerComponentHolder : MonoBehaviour
{
    public Transform holdPoint;
    [SerializeField] private TRDSeparationContorller sepController;

    private PlayerInteractor interactor;

    public HoldableComponent currentComponent;

    private void Start()
    {
        interactor = GetComponent<PlayerInteractor>();
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (currentComponent != null)
            {
                interactor.Interact<TRDSeparationContorller>();
            }
            else
            {
                interactor.Interact<HoldableComponent>();
            }
        }
        else if (Input.GetMouseButtonDown(1))
        {
            if (currentComponent != null)
            {
                Put();
            }
        }
    }

    public void Hold(HoldableComponent component)
    {        
        currentComponent = component;
        component.OnHold(this);
    } 

    public void Set()
    {
        currentComponent.OnSet();
        currentComponent = null;
    }

    public void Put()
    {
        currentComponent.OnPut();
        currentComponent = null;
    }
}
