using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemycontroller : MonoBehaviour
{
    public Transform posl;
    public Transform posr;

    public Rigidbody2D Enemyrb;
    Vector3 direction;

    bool active = true;
    // Start is called before the first frame update
    void Start()
    {
        direction = Vector3.right;
    }

    private void Update()
    {
        if (active)
        {
            //still works with gravity and rb
            // i want it to function with partolling between 2 points but
            if (transform.position.x >= 8)
            {
                direction = Vector3.left;
            }

            if (transform.position.x <= 0)
            {
                direction = Vector3.right;
                Debug.Log(direction);
            }
            transform.position += direction * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.Space))
        {
            //works but boring
            active = false;

        }
    }

}
