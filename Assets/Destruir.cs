using UnityEngine;

public class DestroyOnCollision : MonoBehaviour
{
    
    void OnCollisionEnter(Collision collision)
    {
        // Destruye el objeto
        Destroy(gameObject);
    }
}