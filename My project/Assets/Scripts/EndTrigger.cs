
using UnityEngine;

public class Colision_Player : MonoBehaviour
{
    public GameManager gamemanager;

    void OnTriggerEnter ()
    {
        Debug.Log("enter Collision.");
    }
}
