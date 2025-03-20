using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ObjectMovement : MonoBehaviour
{
    private Color color = Color.white;
    public int speed = 1;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        playerMovement();

    }
    private void playerMovement()
    {

        if (Input.GetKey(KeyCode.W))
        {
            gameObject.transform.position += new Vector3(speed, 0, 0) * Time.deltaTime;
        };
        if (Input.GetKey(KeyCode.A))
        {
            gameObject.transform.position += new Vector3(0, 0, speed) * Time.deltaTime;
        };
        if (Input.GetKey(KeyCode.S))
        {
            gameObject.transform.position += new Vector3(-speed, 0, 0) * Time.deltaTime;
        };
        if (Input.GetKey(KeyCode.D))
        {
            gameObject.transform.position += new Vector3(0, 0, -speed) * Time.deltaTime;
        };


    }
    //En este caso, la colisión está metida en el player, y se le pone tag a los objetos que se quieran destruir
    private void OnCollisionEnter(Collision coll) //que empiece a tocar
    {
        //forma 1 de hacer colisiones: Utilizando tags
        if (coll.gameObject.CompareTag("destruible"))
        {
            GetComponent<Renderer>().material.color = Color.red;
            Destroy(coll.gameObject);
        }
    }
    private void OnCollisionStay(Collision collision) //que siga tocando
    {

    }

    private void OnCollisionExit(Collision collision) //que acabe de tocar
    {

    }

    //Colliders con triggers, funcionan de la misma manera que los de arriba, pero el bloque es un "fantasma"
    private void OnTriggerEnter(Collider coll)
    {
        if (coll.gameObject.CompareTag("destruible"))
        {
            GetComponent<Renderer>().material.color = Color.green;
            Destroy(coll.gameObject);
        }
    }
    private void OnTriggerStay(Collider other)
    {

    }
    private void OnTriggerExit(Collider other)
    {

    }
}
