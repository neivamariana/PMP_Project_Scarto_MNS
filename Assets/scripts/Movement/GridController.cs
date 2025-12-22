using UnityEngine;
using System.Collections;

//this is the grid controller, it has the rules of how to move in the grid for th player and NPC, it's like a chess board ig

public class GridController : MonoBehaviour
{
    public float tileSize = 2f;
    public float movementSpeed = 2f;

    private bool isMoving;
    public bool  IsMoving => isMoving;

    private  Vector3 targetPosition;

    private void Start()
    {
        targetPosition = transform.position;

    }
    
    //this bool is checking if the player or npc can move to the tile they want to 

    public bool MoveCheck(Vector3 direction)
    {
        if (IsMoving) return false;

        Vector3 newTarget = transform.position + direction * tileSize;

        //tenho que meter collisions check aqui 

        targetPosition = newTarget;
        StartCoroutine(MoveRoutine());
        return true;

    }

    private IEnumerator MoveRoutine()
    {
        isMoving = true;

        while(Vector3.Distance(transform.position, targetPosition) > 0.01f)
        {
            transform.position = Vector3.MoveTowards(transform.position, targetPosition, movementSpeed * Time.deltaTime);
            
            yield return null;


        }

        transform.position = targetPosition;
        isMoving = false;
        
    }
}
