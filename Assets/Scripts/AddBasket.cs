using UnityEngine;
using TMPro;

public class AddBasket : MonoBehaviour
{

    [SerializeField]
    [Tooltip("Add the GameManager GameObject here")]
    private CountBaskets countBaskets;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.layer != 3)
        {
            countBaskets.IncreaseScore();
        }
    }
}
