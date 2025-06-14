using UnityEngine;

public class Keycard : MonoBehaviour
{
    public string keycardColor;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            PlayerInventory inventory = other.GetComponent<PlayerInventory>();
            if (inventory != null)
            {
                inventory.AddKeycard(keycardColor);
                Destroy(gameObject);
            }
        }
    }
}
