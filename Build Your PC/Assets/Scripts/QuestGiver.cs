using UnityEngine;

public class QuestGiver : MonoBehaviour
{
    //public Rigidbody rb;
    //public float speed = 420f;
    // Start is called before the first frame update
    /*void Start()
    {
        rb.AddForce(new Vector3(-10, 0, 0), ForceMode.VelocityChange);
    }*/
    public Order order;


    public GameObject orderWindow;
    public TMPro.TextMeshPro titleText;
    public TMPro.TextMeshPro descriptionText;
    public TMPro.TextMeshPro rewardText;

}
