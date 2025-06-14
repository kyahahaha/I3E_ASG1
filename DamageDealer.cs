using UnityEngine;

public class DamageDealer : MonoBehaviour
{
    public int damageAmount = 5;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            PlayerHealth playerHealth = other.GetComponent<PlayerHealth>();

            if (playerHealth != null)
            {
                playerHealth.TakeDamage(damageAmount);
                Debug.Log("You have taken damage! Avoid red tiles!");
            }
        }
    }
}
