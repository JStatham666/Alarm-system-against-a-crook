using UnityEngine;

public class PlayerMover : MonoBehaviour
{
    public readonly string Horizontal = "Horizontal";
    public readonly string Vertical = "Vertical";

    [SerializeField] private float _rotateSpeed = 5;
    [SerializeField] private float _moveSpeed = 80;

    private void Update()
    {
        Rotate();
        Move();
    }

    private void Rotate()
    {
        float rotation = Input.GetAxis(Horizontal);

        transform.Rotate(rotation * _rotateSpeed * Time.deltaTime * Vector3.up);
    }

    private void Move()
    {
        float direction = Input.GetAxis(Vertical);
        float distance = direction * _moveSpeed * Time.deltaTime;

        transform.Translate(distance * Vector3.forward);
    }
}