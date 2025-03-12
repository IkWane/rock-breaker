using UnityEngine;
using UnityEngine.SceneManagement;

public class PausePanel : MonoBehaviour
{
    public GameObject PauseMenu;
    public void Pause() {
      PauseMenu.SetActive(true);
      Time.timeScale = 0;
    }
    public void Resume() {
      PauseMenu.SetActive(false);
      Time.timeScale = 1;
    }
    public void ToMainMenu() {
      SceneManager.LoadScene("MainMenu");
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
