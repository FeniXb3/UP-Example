using System;
using DG.Tweening;
using UnityEngine;

public class CollectiblePointsController : MonoBehaviour
{
    public int points = 10;

    private AudioSource audioSource;
    private PlayerPointsController playerPointsController;
    private Transform pointsTargetTransform;
    private bool isCollected;

    void Start()
    {
        playerPointsController = GameObject.FindGameObjectWithTag("GameController").GetComponent<PlayerPointsController>();
        audioSource = gameObject.GetComponent<AudioSource>();
        pointsTargetTransform = GameObject.FindGameObjectWithTag("Finish").transform;
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player") && !isCollected)
        {
            audioSource.Play();
            playerPointsController.AddPoints(points);
            isCollected = true;
            transform.DOMove(pointsTargetTransform.position, 1f).SetEase(Ease.InOutSine).OnComplete(OnCollected);
        }
    }

    private void OnCollected()
    {
        gameObject.SetActive(false);
    }
}
