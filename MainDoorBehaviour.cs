using UnityEngine;

public class MainDoorBehaviour : MonoBehaviour
{
    public int requiredCoins = 5;
    private bool isOpen = false;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && !isOpen)
        {
            if (CoinManager.Instance.HasEnoughCoins(requiredCoins))
            {
                OpenDoor();
                Debug.Log("You made it!");
            }
            else
            {
                Debug.Log("Not enough coins!");
            }
        }
    }

    void OpenDoor()
    {
        transform.position += new Vector3(0, 3f, 0);
        isOpen = true;
    }
}
