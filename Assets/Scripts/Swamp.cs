using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Swamp : MonoBehaviour, IInteractable
{
    Reindeer reindeer = new Reindeer();
    Snake snake = new Snake();
    Frog frog = new Frog();
    Gorilla gorilla = new Gorilla();
    
    // Start is called before the first frame update
    void Start()
    {
        reindeer.hunger = 0;
        snake.hunger = 1;
        frog.hunger = 1;
        gorilla.hunger = 1;

        reindeer.isSleepy = false;
        snake.isSleepy = true;
        frog.isSleepy = true;
        gorilla.isSleepy = true;
    }

    public void CheckDeer() 
    {
        reindeer.Dig();
    }

    public void Interact()
    {
        CheckDeer();
    }
}
