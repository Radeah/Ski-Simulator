using UnityEngine;

public class DestroyOnTouch : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // Assuming "Player" is the tag of the GameObject that represents the player

            // Destroy the game object when the player touches it
            Destroy(gameObject);
        }
    }
}