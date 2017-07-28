using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class playercontroller : MonoBehaviour
{
    public Text counttext;
    public Text wintext;
    public float speed;
    private int count;

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        count = 0;
        wintext.text = "";
        updatecount();
    }

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        rb.AddForce(movement * speed);
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("pickup"))
        {
            other.gameObject.SetActive(false);
            count = count + 1;
            updatecount();
            if (count >= 12)
            {
                wintext.text = "You Win";
            }
        }
    }
    void updatecount()
    {
        counttext.text = "count: " + count.ToString();
    }
}
