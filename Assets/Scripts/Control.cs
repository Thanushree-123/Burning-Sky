using System.Collections;
using UnityEngine.UI;
using UnityEngine;

public class Control : MonoBehaviour
{
public Text scoreText, gameOverText; // Note we declare two text elements here
int playerScore = 0;
public void AddScore () 
{
playerScore++;
scoreText.text = playerScore.ToString();
}
public void PlayerDied ()
{
gameOverText.enabled = true; // Display the Game Over! Text
Time.timeScale = 0; // This freezes the game
}
}
