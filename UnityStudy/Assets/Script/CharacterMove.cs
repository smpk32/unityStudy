using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMove : MonoBehaviour
{
    public float moveSpeed = 2.0f;


    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("111");
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.LeftArrow))
    {
      transform.Translate(Vector3.left * moveSpeed * Time.deltaTime);
    }
    if(Input.GetKey(KeyCode.RightArrow))
    {
       transform.Translate(Vector3.right * moveSpeed * Time.deltaTime);
    }
    if(Input.GetKey(KeyCode.UpArrow))
    {
       transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);    
    }
    if(Input.GetKey(KeyCode.DownArrow))
    {
       transform.Translate(Vector3.back * moveSpeed * Time.deltaTime);
    }
    }
}
