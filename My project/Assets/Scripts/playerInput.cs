using System;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.Events;

public class playerInput : MonoBehaviour
{
    public UnityEvent<Vector2> OnPlayerInputRecieved = new UnityEvent<Vector2>();

    [SerializeField] private playerMovement _playerMovement;
    [SerializeField] private Rigidbody2D _rb;

    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            print("Links");
            OnPlayerInputRecieved.Invoke(Vector2.left);
        }

        if (Input.GetKey(KeyCode.D))
        {
            print("Rechts");
            OnPlayerInputRecieved.Invoke(Vector2.right);
        }

        if (Input.GetKey(KeyCode.S))
        {
            print("Beneden");
            OnPlayerInputRecieved.Invoke(Vector2.down);
        }

        if (Input.GetKey(KeyCode.W))
        {
            print("Boven");
            OnPlayerInputRecieved.Invoke(Vector2.up);
        }
    }
}
