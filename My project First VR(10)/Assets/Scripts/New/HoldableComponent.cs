using System.ComponentModel;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class HoldableComponent : MonoBehaviour, IInteractable
{
    public Rigidbody rb;
    public Collider col;
    public Transform ts;
    public Transform parent;
    public Vector3 startPos;
    public Quaternion rotation;

    public int num;

    public bool isSet;

    private void Start()
    {
        ts = transform;
        rb = GetComponent<Rigidbody>(); 
        col = GetComponent<Collider>();
        parent = transform.parent;
        startPos = transform.position;
        rotation = transform.rotation;
        isSet = true;
    }

    public void Enter(Player player)
    {

    }

    public void Exit(Player player)
    {

    }

    public void Interact(Player player)
    {
        if (!isSet)
            player.componentHolder.Hold(this);
    }


    public void OnPut()
    { 
        rb.isKinematic = false;
        rb.useGravity = true;
        col.isTrigger = false;

        ts.SetParent(null);

        isSet = false;
    }
    public void OnSet()
    {
        ts.SetParent(parent);
        ts.position = startPos;
        ts.rotation = rotation; 
        rb.isKinematic = false;
        rb.useGravity = false;
        rb.velocity = Vector3.zero;
        rb.angularVelocity = Vector3.zero;
        col.isTrigger = true;

        isSet = true;
    }
    public void OnHold(PlayerComponentHolder player)
    {
        ts.SetParent(player.holdPoint);
        rb.isKinematic = true;
        rb.useGravity = false;
        rb.velocity = Vector3.zero;
        rb.angularVelocity = Vector3.zero;
        col.isTrigger = true;
        ts.localPosition = Vector3.zero;
    }
}