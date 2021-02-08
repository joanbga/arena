using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class PlayerMovement : MonoBehaviour
{
    #region Serialized fields
    [Header("Input")]
    [SerializeField] private InputReader    _inputReader;

    [Header("Movement")]
    [SerializeField] private float          _movementSpeed;
    [SerializeField] private float          _rotationSpeed;
    [SerializeField] private float          _jumpForce;

    #endregion

    #region Private fields
    private Rigidbody rb;

    private Vector3 _velocity;
    private float _rotation;

    #endregion

    #region MonoBehaviour Callbacks
    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void OnEnable()
    {
        _inputReader.jumpEvent += Jump;
        _inputReader.moveEvent += Move;
        _inputReader.strafeEvent += Strafe;
        _inputReader.rotateEvent += Rotate;
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
        PerformRotation();
        PerformMovement();
    }
    #endregion

    #region Input Callbacks
    public void Jump()
    {
        Debug.Log("Jump");
    }

    public void Move(Vector2 dir)
    {
        _velocity = new Vector3(dir.x * _movementSpeed * Time.fixedDeltaTime, rb.velocity.y, dir.y * _movementSpeed * Time.fixedDeltaTime);
    }

    public void Strafe(float value)
    {
        _velocity = new Vector3(value * Time.fixedDeltaTime, rb.velocity.y, rb.velocity.z);
    }

    public void Rotate(float value)
    {
        _rotation = value;
    }
    #endregion

    #region Private Methods
    private void PerformRotation()
    {
        transform.Rotate(0, _rotation * _rotationSpeed * Time.fixedDeltaTime, 0);
    }

    private void PerformMovement()
    {
        transform.Translate(_velocity);
    }
    #endregion
}
