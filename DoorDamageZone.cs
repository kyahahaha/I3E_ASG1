using UnityEngine;

public class DoorDamageZone : MonoBehaviour
{
    public int damageAmount = 20;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            PlayerInventory inventory = other.GetComponent<PlayerInventory>();
            PlayerHealth health = other.GetComponent<PlayerHealth>();

            if (inventory != null && health != null)
            {
                if (!inventory.hasRedKeycard)
                {
                    health.TakeDamage(damageAmount);
                    Debug.Log("Player damaged by door! Missing red keycard.");
                }
                else
                {
                    Debug.Log("Player has red keycard. Safe from damage.");
                }
            }
        }
    }
}
