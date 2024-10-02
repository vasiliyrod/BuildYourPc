using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadShopScreen : MonoBehaviour
{
    [SerializeField]
    string scene = "Shop";
    public void LoadShop()
    {
        SceneManager.LoadScene(scene);
    }
}
