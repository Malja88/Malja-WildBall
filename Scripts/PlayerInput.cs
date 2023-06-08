using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace WildBall.Inputs
{
    [RequireComponent(typeof(Rigidbody))]
    public class PlayerInput : MonoBehaviour
    {
        private Rigidbody playerRigidbody;
        private Vector3 movement;
        [SerializeField] private float speed;
        private void Awake()
        {
            playerRigidbody = GetComponent<Rigidbody>();
        }
        void Update()
        {
            float horizontal = Input.GetAxis(GlobalString.HORIZONTAL_AXIS);
            float vertical = Input.GetAxis(GlobalString.VERTICAL_AXIS);
            movement = new Vector3(horizontal, 0, vertical).normalized;
        }
        private void FixedUpdate()
        {
            MoveCharacter();
        }
        private void MoveCharacter()
        {
            playerRigidbody.AddForce(movement * speed);
        }

    }
}
