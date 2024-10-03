using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeContoller : MonoBehaviour
{
    public Enemycontroller enemy;
    public playercontroller player;

    bool activated;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //so the contgroller has to access the bool in the enemy. best thought is have it access a global variable that is technically local to the idea.
        //past coding projects from school has some examples.
        //havr a base character class that moves depending on a bool that bool can then be referenced by a greater controller as the method itself and pass the parameter
        if (player.timestopactivated)
        {
            enemy.abletomove = false;
        }
        else
        {
            enemy.abletomove = true;
        }
    }
}
