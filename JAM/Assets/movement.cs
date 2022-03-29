using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime;
public class movement : MonoBehaviour
{
    private Rigidbody2D Test;
    // Start is called before the first frame update
    void Start()
    {
        Test = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float directionx = Input.GetAxisRaw("Horizontal");
        float directiony = Input.GetAxisRaw("Vertical");
        Test.velocity = new Vector2(directionx * 7f, Test.velocity.y);
        Test.velocity = new Vector2(Test.velocity.x, directiony*7f);
        if (Input.GetButtonDown("Jump"))
        {
            Test.position +=new Vector2(Random.Range(-3, 3),Random.Range(-3, 3));
        }
        
    }
}
