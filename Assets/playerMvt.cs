using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class playerMvt : MonoBehaviour
{
    PlayerInputs controls;
    [SerializeField] float speed = 10;

    Vector2 move;

    private void Awake()
    {
        controls = new PlayerInputs();

        controls.PlayerMouvement.Jump.performed += ctx => Jump();

        controls.PlayerMouvement.Move.performed += ctx => move = ctx.ReadValue<Vector2>();
        controls.PlayerMouvement.Move.canceled += ctx => move = Vector2.zero;



    }

    void Jump() {

    }

    private void Update()
    {
        Vector2 m = new Vector2(move.x, move.y) * Time.deltaTime * speed;
        transform.Translate(m, Space.World);
    }

    private void OnEnable()
    {
        controls.PlayerMouvement.Enable();
    }
    private void OnDisable()
    {
        controls.PlayerMouvement.Disable();
    }

}
