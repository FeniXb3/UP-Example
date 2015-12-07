using UnityEngine;

public class RestartController : MonoBehaviour
{
    public void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            Application.LoadLevel(Application.loadedLevel);
        }
    }
}
