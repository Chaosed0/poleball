using UnityEngine;

public class ball : MonoBehaviour
{
    public pole pole;
    public socket socket;

    private Vector3 axis;
    private float angle;
    
    private void Awake()
    {
    }

    private void Update()
    {
        transform.position = pole.transform.position + pole.transform.forward * 3f;

        Vector3 toSocketLocal = socket.transform.localPosition;
        Vector3 toPoleLocal = Vector3.forward;
        axis = Vector3.Cross(toSocketLocal, toPoleLocal);
        angle = Vector3.Angle(toSocketLocal, toPoleLocal);

        transform.rotation =
            Quaternion.LookRotation(-pole.transform.forward) *
            Quaternion.AngleAxis(angle, axis);
    }

    private void OnDrawGizmos()
    {
        Gizmos.DrawLine(transform.position, transform.position + axis);
        UnityEditor.Handles.Label(transform.position + axis, angle.ToString());
    }
}
