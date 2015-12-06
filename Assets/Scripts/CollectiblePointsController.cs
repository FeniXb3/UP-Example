using UnityEngine;

public class CollectiblePointsController : MonoBehaviour
{
    public int points = 10;

    private PlayerPointsController playerPointsController;

    void Start()
    {
        playerPointsController = GameObject.FindGameObjectWithTag("GameController").GetComponent<PlayerPointsController>();
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            playerPointsController.AddPoints(points);
            gameObject.SetActive(false);
        }
    }
}
