using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AgentMovement : MonoBehaviour
{

    [SerializeField] float speed;
    //private Animator _animator;

    private Vector3 moveDirection;

    //private void Start() {
    //    _animator = GetComponent<Animator>();
    //}

    void Update()
    {
        moveDirection = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical")).normalized;

        GetComponent<Rigidbody>().MovePosition(GetComponent<Rigidbody>().position + transform.TransformDirection(moveDirection) * speed * Time.deltaTime);

        //_animator.SetFloat("Speed", moveDirection.sqrMagnitude);
    }
}
