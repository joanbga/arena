using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class PlayerMovement : MonoBehaviour
{
    #region Serialized fields
    [Header("Input")]
    [SerializeField] private InputReader    _inputReader;

    [Header("Movement")]
    [SerializeField] private float          _movementSpeed;
    [SerializeField] private float          _rotationSpeed;
    [SerializeField] private float          _jumpForce;
    [SerializeField] private float          _gravity = 6f;

    #endregion

    #region Private fields
    private CharacterController _controller;

    private Vector3 _velocity;
    private float _rotation;
    private bool _mustStrafe = false;

    #endregion

    #region MonoBehaviour Callbacks
    private void Awake()
    {
        _controller = GetComponent<CharacterController>();
    }

    private void OnEnable()
    {
        _inputReader.jumpEvent += Jump;
        _inputReader.moveEvent += Move;
        _inputReader.strafeEvent += Strafe;
        _inputReader.rotateEvent += Rotate;
        _inputReader.rightButtonEvent += (bool press) => { _mustStrafe = press; };
    }

    private void OnDisable()
    {
        _inputReader.jumpEvent -= Jump;
        _inputReader.moveEvent -= Move;
        _inputReader.strafeEvent -= Strafe;
        _inputReader.rotateEvent -= Rotate;
    }

    private void FixedUpdate()
    {
        ApplyGravity();
        PerformRotation();
        PerformMovement();
    }
    #endregion

    #region Input Callbacks
    public void Jump()
    {
        if (!_controller.isGrounded)
            return;
        _velocity.y = _jumpForce;
    }

    public void Move(Vector2 dir)
    {
        _velocity = new Vector3(dir.x, _velocity.y, dir.y);
    }

    public void Strafe(float value)
    {
        _velocity = new Vector3(value, _velocity.y, _velocity.z);
    }

    public void Rotate(float value)
    {
            _rotation = value;
    }
    #endregion

    #region Private Methods
    private void PerformRotation()
    {
        if (_mustStrafe)
        {
            _velocity.x = _rotation;
            return;
        }
        transform.Rotate(0, _rotation * _rotationSpeed * Time.fixedDeltaTime, 0);
    }

    private void PerformMovement()
    {
        _controller.Move(transform.TransformDirection(_velocity) * _movementSpeed * Time.fixedDeltaTime);
    }

    private void ApplyGravity()
    {
        _velocity.y -= _gravity * Time.fixedDeltaTime;
    }
    #endregion
}
