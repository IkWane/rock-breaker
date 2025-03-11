using UnityEngine;
using UnityEngine.SceneManagement;

public class MainButtons : MonoBehaviour
{
  public void PlayGame() {
    SceneManager.LoadScene(1);
  }
  public void QuitGame() {
    Application.Quit();
  }

  // public void ToMainMenu() {
  //   SceneManager.LoadScene("MainMenu");
  // }
  // public void ToSettingsMenu() {
  //   SceneManager.LoadScene("SettingsMenu");
  // }
}
