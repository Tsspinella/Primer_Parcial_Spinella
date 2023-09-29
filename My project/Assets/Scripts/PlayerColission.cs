using UnityEngine;

public class PlayerColission : MonoBehaviour
{

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("enter Collision.");
    }
}
