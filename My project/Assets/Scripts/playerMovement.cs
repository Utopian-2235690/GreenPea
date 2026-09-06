using UnityEngine;

public class playerMovement : MonoBehaviour
{
    [SerializeField] private playerInput _playerInput;
    [SerializeField] private Rigidbody _rb;
    [SerializeField] private float _speed;

    public void MovePlayer(Vector2 direction)
    {
        transform.position += new Vector3(direction.x, direction.y, 0) * _speed * Time.deltaTime;
    }

    public void Start()
    {
        _playerInput.OnPlayerInputRecieved.AddListener(MovePlayer);
    }
}