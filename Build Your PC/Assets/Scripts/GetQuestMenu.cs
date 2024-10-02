using UnityEngine;

public class GetQuestMenu : MonoBehaviour
{
    private bool isTriggered = false;
    public static bool questMenuOpen = false;
    public GameObject questMenuUI;
    public GameObject endQuestMenuUI;

    private void Update()
    {
        if (isTriggered && Input.GetKey("e"))
        {
            if (GlobalVar.gotQuest == false)
            {
                Debug.Log("GetQuest");
                
                EnterQuestMenu();
            }
            else
            {
                EndQuestMenu();
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
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

    public void Resume()
    {
        questMenuUI.SetActive(false);
        endQuestMenuUI.SetActive(false);
        questMenuOpen = false;
        Time.timeScale = 1f;
        GlobalVar.gotQuest = true;
    }

    public void EnterQuestMenu()
    {
        questMenuUI.SetActive(true);
        questMenuOpen = true;
        Time.timeScale = 0f;

    }

    public void EndQuestMenu()
    {
        endQuestMenuUI.SetActive(true);
        questMenuOpen = true;
        Time.timeScale = 0f;
    }
}