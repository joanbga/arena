using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] InputReader _inputReader;

    private Camera cam;

    public float targetHeight = 1.7f;
    public float distance = 5.0f;
    public float offsetFromWall = 0.1f;

    public float maxDistance = 20;
    public float minDistance = .6f;
    public float speedDistance = 5;

    public float xSpeed = 200.0f;
    public float ySpeed = 200.0f;

    public int yMinLimit = -40;
    public int yMaxLimit = 80;

    public int zoomRate = 40;

    public float rotationDampening = 3.0f;
    public float zoomDampening = 5.0f;

    public LayerMask collisionLayers = -1;

    private float xDegOffset = 0f;
    private float xDeg = 0.0f;
    private float yDeg = 0.0f;
    private float currentDistance;
    private float desiredDistance;
    private float correctedDistance;

    void Start()
    {
        cam = Camera.main;
        Vector3 angles = cam.transform.eulerAngles;
        xDeg = angles.x;
        yDeg = angles.y;

        currentDistance = distance;
        desiredDistance = distance;
        correctedDistance = distance;

        // Make the rigid body not change rotation
        if (cam.gameObject.GetComponent<Rigidbody>())
            cam.gameObject.GetComponent<Rigidbody>().freezeRotation = true;
    }

    private void OnEnable()
    {
        _inputReader.lookEvent += OnLook;
        _inputReader.zoomEvent += OnZoom;
    }

    private void OnDisable()
    {
        _inputReader.lookEvent -= OnLook;
        _inputReader.zoomEvent -= OnZoom;
    }

    private void OnLook(Vector2 delta)
    {
        xDeg += delta.x * xSpeed * Time.deltaTime;
        yDeg -= delta.y * ySpeed * Time.deltaTime;
    }

    private void OnZoom(float zoom)
    {
        desiredDistance -= zoom * Time.deltaTime * zoomRate * Mathf.Abs(desiredDistance) * speedDistance;
    }

    /**
     * Camera logic on LateUpdate to only update after all character movement logic has been handled.
     */
    void LateUpdate()
    {
        Vector3 vTargetOffset;

        // If either mouse buttons are down, let the mouse govern camera position
        if (_inputReader.LeftMouseDown() || _inputReader.RightMouseDown())
        {
            xDegOffset = cam.transform.eulerAngles.y - transform.eulerAngles.y;
        }
        // Otherwise, rotate with the player
        else
        {
            xDeg = transform.eulerAngles.y + xDegOffset;
        }


        // calculate the desired distance
        desiredDistance = Mathf.Clamp(desiredDistance, minDistance, maxDistance);

        yDeg = ClampAngle(yDeg, yMinLimit, yMaxLimit);

        // set camera rotation
        Quaternion rotation = Quaternion.Euler(yDeg, xDeg, 0);
        correctedDistance = desiredDistance;

        // calculate desired camera position
        vTargetOffset = new Vector3(0, -targetHeight, 0);
        Vector3 position = transform.position - (rotation * Vector3.forward * desiredDistance + vTargetOffset);

        // check for collision using the true target's desired registration point as set by user using height
        RaycastHit collisionHit;
        Vector3 trueTargetPosition = new Vector3(transform.position.x, transform.position.y, transform.position.z) - vTargetOffset;

        // if there was a collision, correct the camera position and calculate the corrected distance
        bool isCorrected = false;
        if (Physics.Linecast(trueTargetPosition, position, out collisionHit, collisionLayers.value))
        {
            // calculate the distance from the original estimated position to the collision location,
            // subtracting out a safety "offset" distance from the object we hit.  The offset will help
            // keep the camera from being right on top of the surface we hit, which usually shows up as
            // the surface geometry getting partially clipped by the camera's front clipping plane.
            correctedDistance = Vector3.Distance(trueTargetPosition, collisionHit.point) - offsetFromWall;
            isCorrected = true;
        }

        // For smoothing, lerp distance only if either distance wasn't corrected, or correctedDistance is more than currentDistance
        currentDistance = !isCorrected || correctedDistance > currentDistance ? Mathf.Lerp(currentDistance, correctedDistance, Time.deltaTime * zoomDampening) : correctedDistance;

        // keep within legal limits
        currentDistance = Mathf.Clamp(currentDistance, minDistance, maxDistance);

        // recalculate position based on the new currentDistance
        position = transform.position - (rotation * Vector3.forward * currentDistance + vTargetOffset);

        cam.transform.rotation = rotation;
        cam.transform.position = position;

        if (_inputReader.RightMouseDown())
            transform.rotation = Quaternion.Euler(0f, rotation.eulerAngles.y, 0f);
    }

    private static float ClampAngle(float angle, float min, float max)
    {
        if (angle < -360)
            angle += 360;
        if (angle > 360)
            angle -= 360;
        return Mathf.Clamp(angle, min, max);
    }
}
