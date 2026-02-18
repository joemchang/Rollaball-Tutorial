using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonScript : MonoBehaviour
{
    public void LoadLevel()
	{
		SceneManager.LoadScene("Minigame");
        
    }
}
