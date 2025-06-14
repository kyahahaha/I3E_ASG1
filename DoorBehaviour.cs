using UnityEngine;

public class DoorBehaviour : MonoBehaviour
{
    public Transform door;
    public Vector3 openPositionOffset = new Vector3(0, 5, 0);
    private Vector3 closedPosition;
    private bool isOpen = false;

    void Start()
    {
        closedPosition = door.position;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            PlayerInventory inventory = other.GetComponent<PlayerInventory>();

            if (inventory != null && inventory.hasBlackKeycard)
            {
                OpenDoor();
                Debug.Log("Door opened.");
            }
            else
            {
                Debug.Log("You need a red keycard to open this door.");
            }
        }
    }

    void OpenDoor()
    {
        if (!isOpen)
        {
            door.position = closedPosition + openPositionOffset;
            isOpen = true;
        }
    }
}
