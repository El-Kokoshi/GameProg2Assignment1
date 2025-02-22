using UnityEngine;

public class Taiga : MonoBehaviour, IInteractable
{
    public bool canInteract = false;
    
    Reindeer reindeer = new Reindeer();
    Snake snake = new Snake();
    Frog frog = new Frog();
    Gorilla gorilla = new Gorilla();
    
    // Start is called before the first frame update
    public void Start()
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

    public void Update() 
    {
        if(Input.GetKeyDown(KeyCode.I))
        {
            
        }
    }

    public void CheckDeer() 
    {
        reindeer.Dig();
    }

    public void Interact()
    {
        CheckDeer();
    }

    public void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.gameObject.tag == "Player")
        {
            canInteract = true;
        }
    }

    public void OnTriggerExit2D(Collider2D other) 
    {
        if(other.gameObject.tag == "Player")
        {
            canInteract = false;
        }
    }

    

    

    
}
