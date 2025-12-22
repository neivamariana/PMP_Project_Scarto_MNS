using UnityEngine;

[RequireComponent(typeof(GridController))]

public class NPC_Movement : MonoBehaviour
{
    private GridController npcMove;
    private float moveTimer;

    public float moveInterval = 1.5f;

    void Awake()
    {
        npcMove = GetComponent<GridController>();

    }

    // Update is called once per frame
    void Update()
    {
        if (npcMove.IsMoving) return;

        moveTimer -= Time.deltaTime;

        if(moveTimer > 0f) return;

        moveTimer = moveInterval;

        Vector3[] direction =
        {
            Vector3.forward,
            Vector3.back,
            Vector3.left,
            Vector3.right
        };

        Vector3 chosenDirection = direction[Random.Range(0, direction.Length)];
        npcMove.MoveCheck(chosenDirection);
                
    }
}
