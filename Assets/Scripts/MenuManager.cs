using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine;

public class MenuManager : MonoBehaviour {

	public PlayerController playerController;
	public PickUps pickUps;
	public void LoadGameScene()
	{
		SceneManager.LoadScene("MiniGame");
	}

	public void QuitGame()
	{
		Application.Quit();
	}

	public void PlayAgain()
	{
		ResetGame();
	}

	public void ReturnMenu()
	{
		ResetGame();
		SceneManager.LoadScene("Menu");
	}

	private void ResetGame()
	{
		if (playerController != null)
		{
			playerController.ResetPlayerSettings();
		}
		if (pickUps != null)
		{
			pickUps.ResetPickUps();
		}
	}
}
