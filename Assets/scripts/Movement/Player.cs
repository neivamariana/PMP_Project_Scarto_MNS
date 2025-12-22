using UnityEngine;

[RequireComponent(typeof(GridController))]
public class Player : MonoBehaviour
{
    private GridController PlayerMovement;

    void Start()
    {
        PlayerMovement = GetComponent<GridController>();

        
    }

    // Update is called once per frame
    void Update()
    {
        if(PlayerMovement.IsMoving) return;

        Vector3 direction = Vector3.zero;

        if (Input.GetKeyDown(KeyCode.W)) direction = Vector3.forward;

        else if (Input.GetKeyDown(KeyCode.S)) direction = Vector3.back;

        else if (Input.GetKeyDown(KeyCode.A)) direction = Vector3.left;

        else if (Input.GetKeyDown(KeyCode.D)) direction = Vector3.right;

        if (direction != Vector3.zero)
        
        PlayerMovement.MoveCheck(direction);

        
    }
}
