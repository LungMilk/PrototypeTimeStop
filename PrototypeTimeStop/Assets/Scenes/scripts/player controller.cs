using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class playercontroller : MonoBehaviour
{
    public TextMeshProUGUI durationnumber;
    public Rigidbody2D rb;

    float x;
    public bool timestopactivated = false;

    public float duration =5;
    float charge;
    // Start is called before the first frame update
    void Start()
    {
        charge = duration;
    }

    // Update is called once per frame
    void Update()
    {
        x = Input.GetAxis("Horizontal");
        rb.AddForce(new Vector2(x *2,0));
    }

    private void FixedUpdate()
    {
        //and it can still recharge little values and be activated at such time.
        //programming load is too much and i think thats the issue that slows the processing down.
        if (Input.GetKey(KeyCode.Space) && charge <= duration * 50)
        {
            //fixed update is 50 every second so if i add +1 to a counter for every iteration in the frame then divide it by 50 that should make a second conversion
 
                timestopactivated = true;
                charge += 1;
                Debug.Log(charge/50);
        }
        else
        {
            timestopactivated = false;
            //everyframe your not holding space regen starts to climb
            charge--;
            if (charge < 0)
            {
                charge = 0;
            }
        }
        //
        durationnumber.text = Convert.ToInt64(5 - charge / 50) + "s";
    }
}
