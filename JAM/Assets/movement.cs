using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime;

public class movement : MonoBehaviour
{
    Player jatekos;
    
    // Start is called before the first frame update
    void Start()
    {
        jatekos = new Player(GetComponent<Rigidbody2D>());
    }

    // Update is called once per frame
    void Update()
    {
        jatekos.Update();
        shot();
    }
    public GameObject BulletPrefab;

    private void Shooting()
    {
        Rigidbody2D Bulletrigid = BulletPrefab.GetComponent<Rigidbody2D>();
        float x = jatekos.directionx;
        float y = jatekos.directiony;
        Bulletrigid.velocity = new Vector2(x, y);
        GameObject Bullet = Instantiate(BulletPrefab) as GameObject;
        Bullet.transform.position = new Vector2(jatekos.getBody.position.x, jatekos.getBody.position.y);
        while (true) { Bulletrigid.velocity = new Vector2(x, y); }
       
   
    }
    void shot() {
        if (Input.GetButtonDown("Fire1")/*&&(jatekos.directionx!=0||jatekos.directiony!=0)*/)
        {
            Shooting();
        }
        
    }
  
}
