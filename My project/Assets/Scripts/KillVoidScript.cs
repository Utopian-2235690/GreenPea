using UnityEngine;
using UnityEngine.SceneManagement;

public class KillVoidScript : MonoBehaviour
{
    [SerializeField] private string _playerTag = "Player";
    [SerializeField] private float _killVoidSpeed = 14;
    [SerializeField] private Rigidbody2D _rb;

    void Update()
    {
        _rb.linearVelocityY = _killVoidSpeed;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag(_playerTag))
        {
            print("test");
            SceneManager.LoadScene("LoseScreen");
        }
    }
}
