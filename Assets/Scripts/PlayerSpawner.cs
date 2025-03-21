using UnityEngine;

public class PlayerSpawner : MonoBehaviour
{
    public GameObject playerPrefab;
    public Transform spawnPoint; 
    public string[] skinNames = {"Skin_1", "Skin_2" };
    private int selectedSkinIndex = 0;

    void Start()
    {
        Debug.Log("PlayerSpawner Start() called");
        SpawnPlayer();
    }


    void SpawnPlayer()
    {
        GameObject player = Instantiate(playerPrefab, spawnPoint.position, Quaternion.identity);

        // Find the child object that has the SpriteRenderer
        SpriteRenderer playerRenderer = player.GetComponentInChildren<SpriteRenderer>();
        if (playerRenderer != null && selectedSkinIndex < skinNames.Length)
        {
            Sprite newSkin = Resources.Load<Sprite>("Skins/" + skinNames[selectedSkinIndex]);
            if (newSkin != null)
            {
                playerRenderer.sprite = newSkin;
            }
        }
    }


    // Call this method when the player selects a skin from UI
    public void SetSkin(int index)
    {
        PlayerPrefs.SetInt("SelectedSkin", index);
        PlayerPrefs.Save();
    }
    // public void OnSkinSelected(int skinIndex)
    // {
    //     FindObjectOfType<PlayerSpawner>().SetSkin(skinIndex);
    // }

}
