using UnityEngine;
using UnityEngine.UI;

public class PlayerPointsController : MonoBehaviour
{
    public Text pointsLabel;
    private int points;
    
    public void AddPoints(int pointsToAdd)
    {
        points += pointsToAdd;

        pointsLabel.text = string.Format("Points: {0}", points);
    }
}
