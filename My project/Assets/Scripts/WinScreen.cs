using UnityEngine;
using UnityEngine.SceneManagement;

public class WinScreen : MonoBehaviour
{
    [SerializeField] private string _playerTag = "Player";

    //Als de speler tegen de portal aan loopt dan worden ze naar het win scherm gebracht

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag(_playerTag))
        {
            SceneManager.LoadScene("WinScreen");
        }
    }
}
