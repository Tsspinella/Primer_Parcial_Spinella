using UnityEngine;
using UnityEngine.SceneManagement;



public class PlayerColission : MonoBehaviour
{

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("enter Collision.");
        if (collision.collider.tag == "Obstaculo")
        {
            SceneManager.LoadScene(4);
        }
    }
}
