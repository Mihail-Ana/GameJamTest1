using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move1 : MonoBehaviour
{
    public int Variable1;
    // Start is called before the first frame update
    public void Start()
    {
        //Variable1 = 50; - MA This does that
    }

    // Update is called once per frame
    public void FixedUpdate()
    {
        print(Variable1);
    }
}
