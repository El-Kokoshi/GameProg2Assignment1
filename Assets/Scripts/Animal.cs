using UnityEngine;

public abstract class Animal 
{
    public bool isHappy = false;
    public bool isSleepy;
    public float hunger;


    public abstract void Pet();
    public abstract void Feed();
}

public class Reindeer : Animal
{
    public override void Pet()
    {
        isHappy = true;
        Debug.Log("Appreciate it!");
        if(hunger >= 1)
        {
            Debug.Log("Gib food plz!");
        }
    }

    public override void Feed()
    {
        Debug.Log("Thanks bossman!");
    }

    public void Dig()
    {
        Debug.Log("Any grass here?");
    }
    
}

public class Snake : Animal
{
    public override void Pet()
    {
        isHappy = true;
        Debug.Log("Appreciate it!");
    }

    public override void Feed()
    {
        Debug.Log("Thankssss!");
    }

    public void Rattle()
    {
        Debug.Log("I am not a snake like that");
    }
}

public class Frog : Animal
{
    public override void Pet()
    {
        isHappy = false;
        Debug.Log("Squeeeek!");
        Debug.Log("Please stop!");
    }

    public override void Feed()
    {
        isHappy = true;
        Debug.Log("Very reasonable decision");
    }

    public void Ribbit()
    {
        Debug.Log("RRRRRIIIIIIBBBBBBBBIT");
    }
}

public class Gorilla : Animal
{
    public override void Pet()
    {
        isHappy = false;
        Debug.Log("Whoa there, take it easy!");
    }

    public override void Feed()
    {
        isHappy = true;
        Debug.Log("Whoa, thanks bro!");
    }

    public void Bench()
    {
        Debug.Log("I still haven't found one.");
    }
}
