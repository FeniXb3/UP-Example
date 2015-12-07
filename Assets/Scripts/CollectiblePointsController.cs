using UnityEngine;

public class CollectiblePointsController : MonoBehaviour
{
    public int points = 10;

    private AudioSource audioSource;
    private PlayerPointsController playerPointsController;
    private SpriteRenderer spriteRenderer;
    private bool isCollected;

    void Start()
    {
        playerPointsController = GameObject.FindGameObjectWithTag("GameController").GetComponent<PlayerPointsController>();
        audioSource = gameObject.GetComponent<AudioSource>();
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        if(isCollected && !audioSource.isPlaying)
        {
            gameObject.SetActive(false);
        }
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player") && !isCollected)
        {
            audioSource.Play();
            playerPointsController.AddPoints(points);
            spriteRenderer.enabled = false;
            isCollected = true;
        }
    }
}
