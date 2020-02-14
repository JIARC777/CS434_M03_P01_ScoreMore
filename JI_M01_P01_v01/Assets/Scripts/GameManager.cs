
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
	bool gameOver = false;
	public float restartDelay = 1f;
	public GameObject completeLevelUI;
    public GameObject mileStoneUI;
    public void CompleteLevel()
	{
		Debug.Log("LEVEL WON");
		completeLevelUI.SetActive(true);
		//SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1 );
	}
    public void Start()
    {
        Score.OnMilestone += displayMilestone;
    }
    public void EndGame()
	{
		if (gameOver == false)
		{
			gameOver = true;
			Debug.Log("Game Over");
			Invoke("Restart", restartDelay);
		}
		
	}
    public void displayMilestone()
    {
        StartCoroutine(ActivateMileStoneText());
    }

    IEnumerator ActivateMileStoneText()
    {
        mileStoneUI.SetActive(true);
        yield return new WaitForSeconds(3);
        mileStoneUI.SetActive(false);
    }
	void Restart()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().name);
	}
}
