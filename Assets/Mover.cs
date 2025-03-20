using UnityEngine;

public class ObjectMovement : MonoBehaviour
{
    public int speed = 5;
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
}