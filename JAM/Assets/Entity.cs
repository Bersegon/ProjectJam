using System.Collections;
using System.Collections.Generic;
using UnityEngine;





public class Entity : MonoBehaviour
{
    protected int hp;   //karakter hp-ja
    public int HP{ get { return hp; } set { hp = value; } }
    protected int maxhp;  //karakter maxhp-ja
    public int MaxHP { get { return maxhp; } set { maxhp = value; } }

    protected Rigidbody2D Body;
    public Rigidbody2D getBody { get{ return Body; } }
    
}

public class Player : Entity
{    public Player(Rigidbody2D P) { Body = P; }
    public float directiony;
    public float directionx;
    public void Update()
    {
        directionx = Input.GetAxisRaw("Horizontal");
        directiony = Input.GetAxisRaw("Vertical");
        Body.velocity = new Vector2(directionx * 7f, Body.velocity.y);
        Body.velocity = new Vector2(Body.velocity.x, directiony * 7f);
    }
    
}



