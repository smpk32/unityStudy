using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMove : MonoBehaviour
{
    public float moveSpeed = 10.0f;
    private MeshRenderer render;

    public Rigidbody rigidbody2;

    // Start is called before the first frame update
    void Start()
    {
        GameObject ground = GameObject.Find("ground");

        
        render = ground.GetComponent<MeshRenderer>();
        render.material.color = Color.blue;
        Debug.Log(render);

        

        Debug.Log(render.GetComponent<Transform>().position);
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.LeftControl))
        {
            rigidbody2.AddForce(0, 500, 0);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
          transform.Translate(Vector3.left * moveSpeed * Time.deltaTime);
            render.material.color = new Color(0f,0f,1f,1f);
        }
        if(Input.GetKey(KeyCode.RightArrow))
        {
           transform.Translate(Vector3.right * moveSpeed * Time.deltaTime);
            render.material.color = new Color(1f, 0.92f, 0.016f, 1f);
        }
        if(Input.GetKey(KeyCode.UpArrow))
        {
           transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
            render.material.color = new Color(1f, 0f, 0f, 1f);
        }
        if(Input.GetKey(KeyCode.DownArrow))
        {
           transform.Translate(Vector3.back * moveSpeed * Time.deltaTime);
            render.material.color = new Color(0.5f, 0.5f, 0.5f, 1f);
        }

        Debug.Log(gameObject.GetComponent<Transform>().position);
    }
}
