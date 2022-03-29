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
    }
}
