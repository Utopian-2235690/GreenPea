using System;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playerMovement : MonoBehaviour
{
    [SerializeField] private playerInput _playerInput;
    [SerializeField] private Rigidbody _rb;
    [SerializeField] private float _speed;
    [SerializeField] private string _goodFood;
    [SerializeField] private string _badFood;

    public void MovePlayer(Vector2 direction)
    {
        transform.position += new Vector3(direction.x, direction.y, 0) * _speed * Time.deltaTime;
    }

    public void Start()
    {
        _playerInput.OnPlayerInputRecieved.AddListener(MovePlayer);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag(_goodFood))
        {
            _speed += 1;
        }
        else if (collision.gameObject.CompareTag(_badFood))
        {
            TempBuff(2f,TimeSpan.FromSeconds(2));
        }
    }

    private async Task TempBuff(float amount, TimeSpan duration)
    {
        _speed += amount;

        await Task.Delay(duration);

        _speed -= amount;
        _speed --;
    }
}