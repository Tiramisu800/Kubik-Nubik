using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform name;
    public float speed = 8;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //WASD
        if (Input.GetKey(KeyCode.A)) { //A - лева
            name.Translate(-name.right * speed * Time.deltaTime); 
        } 
        if (Input.GetKey(KeyCode.D)) //D - права
        {
            name.Translate(name.right * speed * Time.deltaTime); 
        }
        if (Input.GetKey(KeyCode.W)) //W - вперед
        {
            name.Translate(name.forward * speed * Time.deltaTime); 
        }
        if (Input.GetKey(KeyCode.S)) //S - назад
        {
            name.Translate(-name.forward * speed * Time.deltaTime); 
        }

    }
}
