using UnityEngine;

[RequireComponent(typeof(HingeJoint))]
public class Swing : MonoBehaviour
{
    [SerializeField] private float _swingForce;
    [SerializeField] private float _force;

    private HingeJoint _hingeJoint;
    private JointMotor _jointMotor;

    private readonly KeyCode SwingKey = KeyCode.Space;

    private void Start()
    {
        _hingeJoint = GetComponent<HingeJoint>();
        _jointMotor = _hingeJoint.motor;
    }

    private void Update()
    {
        Ride();
    }

    private void Ride()
    {
        if (Input.GetKeyDown(SwingKey))
        {
            _jointMotor.targetVelocity = _swingForce;
            _jointMotor.force = _force;
            _hingeJoint.useMotor = true;

            _hingeJoint.motor = _jointMotor;
        }

        if (_hingeJoint.angle >= _hingeJoint.limits.max || _hingeJoint.angle <= _hingeJoint.limits.min)
        {
            _jointMotor.force = 0;
            _jointMotor.targetVelocity = 0;
            _hingeJoint.motor = _jointMotor;
        }
    }
}
