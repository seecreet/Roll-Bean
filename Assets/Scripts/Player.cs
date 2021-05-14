using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;

public class Player : MonoBehaviour
{
    public int health;
    public int speed;
    public int height;

    public string race;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void SetAll(int hp, int sp, int hei, string rac)
    {
        health = hp;
        speed = sp;
        height = hei;
        race = rac;
    }

    public void SetHealth(int hp)
    {
        health = hp;
    }

    public void SetSpeed(int sp)
    {
        speed = sp;
    }

    public void SetHeight(int hei)
    {
        height = hei;
    }

    public void SetRace(string rac)
    {
        race = rac;
    }

}
