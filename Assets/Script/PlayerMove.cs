using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float move = 2.5f;
    private Vector3 targetPosition;

    void Start() {
        targetPosition = transform.position;
    }

    void Update() {
        if (Input.GetKeyDown(KeyCode.LeftArrow)) {
            targetPosition = new(transform.position.x - move, transform.position.y, transform.position.z);
        }
        if (Input.GetKeyDown(KeyCode.RightArrow)) {
            targetPosition = new(transform.position.x + move, transform.position.y, transform.position.z);
        }
        transform.position = Vector3.MoveTowards(transform.position, targetPosition, move * Time.deltaTime);
    }
}
