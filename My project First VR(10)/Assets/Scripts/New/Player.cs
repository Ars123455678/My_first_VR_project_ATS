using UnityEngine;

public class Player : MonoBehaviour
{
    public PlayerInteractor interactor;
    public PlayerComponentHolder componentHolder;

    private void Start()
    {
        Cursor.visible = false;
    }

    public void Teleport(Transform ts)
    {
        transform.position = ts.position;
    }
}