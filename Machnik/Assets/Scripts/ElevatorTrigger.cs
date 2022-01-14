using System.Collections;
using UnityEngine;

public class ElevatorTrigger : MonoBehaviour {
    [SerializeField] private GameObject elevator;

    private void OnTriggerStay(Collider other) {
        if (other.tag == "Player" && Input.GetKeyDown(KeyCode.C)) {
            StartCoroutine(elevator.GetComponent<ElevatorScript>().Move(new Vector3(transform.position.x - 0.85f, transform.position.y + 17f, transform.position.z), 5f));
        }

        if (other.tag == "Player" && Input.GetKeyDown(KeyCode.V)) {
            StartCoroutine(elevator.GetComponent<ElevatorScript>().Move(new Vector3(transform.position.x + 0.85f, transform.position.y - 17f, transform.position.z), 5f));
        }
    }

    // Доделать так, чтобы лифт оставался на втором этаже, а когда ты входишь в него снова, то ехал на низ
}
