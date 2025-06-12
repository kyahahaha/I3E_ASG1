using UnityEngine;

public class Collectible : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // Add score or inventory logic here
            Debug.Log("Collected!");

            // Destroy the collectible object
            Destroy(gameObject);
        }
    }
}
