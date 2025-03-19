using UnityEngine;
using UnityEngine.SceneManagement;

public class MainButtons : MonoBehaviour
{
  public GameObject Settings;
  public GameObject MainMenu;
  public GameObject Title;
  
  public void PlayGame() 
  {
    SceneManager.LoadScene(1);
  }
  public void QuitGame() 
  {
    Application.Quit();
  }

  public void FromMainMenuToSettings() 
  {
    MainMenu.SetActive(false);
    Settings.SetActive(true);
    Title.SetActive(false);
  }
  public void FromSettingsToMainMenu() 
  {
    Settings.SetActive(false);
    MainMenu.SetActive(true);
    Title.SetActive(true);
  }
}
