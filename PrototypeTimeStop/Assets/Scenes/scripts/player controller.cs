using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class playercontroller : MonoBehaviour
{
    public Rigidbody2D rb;

    float x;
    public bool timestopactivated = false;

    public float duration =5;
    float charge;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        x = Input.GetAxis("Horizontal");
        rb.AddForce(new Vector2(x *2,0));
    }

    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            Debug.Log("Timestop");
            StartCoroutine(Timestop());
        }

    }

    IEnumerator Timestop()
    {
        timestopactivated = true;
        yield return new WaitForSeconds(duration);
        timestopactivated = false;
    }
}
