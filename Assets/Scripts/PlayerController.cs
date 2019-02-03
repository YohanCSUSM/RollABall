using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerController : MonoBehaviour {

    public float speed;
    public Text countText;
    public Text winText;
    public Button playAgainBtn;
    public Button menuBtn;

    private Rigidbody rb;
    private int count;

    void Start ()
    {
        rb = GetComponent<Rigidbody>();
        count = 0;
        SetCountText ();
        winText.text = "";
    }

    void FixedUpdate ()
    {
        float moveHorizontal = Input.GetAxis ("Horizontal");
        float moveVertical = Input.GetAxis ("Vertical");

        Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);

         rb.AddForce (movement * speed);
    }

    void OnTriggerEnter(Collider other) 
    {
        if (other.gameObject.CompareTag ( "Pick Up"))
        {
            other.gameObject.SetActive (false);
            count = count + 1;
            SetCountText ();
        }
    }

    void SetCountText ()
    {
        countText.text = "Count: " + count.ToString ();
        if (count >= 12)
        {
            winText.text = "You Win!";
            playAgainBtn.gameObject.SetActive(true);
            menuBtn.gameObject.SetActive(true);
        }
    }

    public void ResetPlayerSettings()
    {
        count = 0;
        SetCountText();
        winText.text = "";
        playAgainBtn.gameObject.SetActive(false);
        menuBtn.gameObject.SetActive(false);
        transform.position = new Vector3(0f, 0.5f, 0f);
        rb.velocity = Vector3.zero;
        rb.angularVelocity = Vector3.zero;
    }
}