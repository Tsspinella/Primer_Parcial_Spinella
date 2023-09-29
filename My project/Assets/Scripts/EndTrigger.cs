
using UnityEngine;
using UnityEngine.SceneManagement;



public class Colision_Player : MonoBehaviour
{
    

    void OnTriggerEnter ()
    {
        Debug.Log("Salida");
        SceneManager.LoadScene(3);
    }
}
