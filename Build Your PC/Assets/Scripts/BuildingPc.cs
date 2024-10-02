using UnityEngine;

public class BuildingPc : MonoBehaviour
{
    public GameObject processor;
    public GameObject motherboard;
    public GameObject ram;
    public GameObject hardDrive;
    public GameObject videoCard;
    public GameObject powerSupply;
    public GameObject pcCase;
    public GameObject cooler;


    private void Update()
    {
        if (pcCase.activeInHierarchy && motherboard.activeInHierarchy)
        {
            motherboard.GetComponent<Animator>().enabled = true;
            videoCard.GetComponent<Animator>().enabled = true;
            powerSupply.GetComponent<Animator>().enabled = true;
        }
        /*if (motherboard.activeInHierarchy)
        {
            cooler.GetComponent<Animator>().enabled = true;
        }*/
    }

}
