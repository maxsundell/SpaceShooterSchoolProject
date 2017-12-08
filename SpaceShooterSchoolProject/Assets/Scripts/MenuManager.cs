using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour 
{
	
	public void RestartGame()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

    }

    public void PlayGame()
    {

        SceneManager.LoadScene(1);
        print("Playing...");

    }

    public void QuitGame()
    {

        QuitGame();
        print("Quitting...");

    }
	
}
