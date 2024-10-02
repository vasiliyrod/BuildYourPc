using UnityEngine;
using UnityEngine.SceneManagement;
public class LoadBuildScreen : MonoBehaviour
{
    [SerializeField]
    private string scene = "BuildScreen";

    private bool isTriggered = false;

    private void Update()
    {
        if (isTriggered && Input.GetKey("e"))
        {
            Debug.Log("load scene");
            SceneManager.LoadScene(scene);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player" )
        {
            isTriggered = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            isTriggered = false;
        }
    }    
}
