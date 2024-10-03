using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeContoller : MonoBehaviour
{
    public GameObject enemy;
    public GameObject player;

    bool activated;
    float duration;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //so the contgroller has to access the bool in the enemy. best thought is have it access a global variable that is technically local to the idea.
        //past coding projects from school has some examples.
    }
}
