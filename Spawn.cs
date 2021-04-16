using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{

    public GameObject item;
    private Transform player;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectsWithTag("Player").transform;
    }
    public void SpawnDroppedItem()
    {
        Vector2 playerPos = new Vector2(player.position.x + 3, player.position.y - 2);
        Instantiate(item, playerPos, Quaternion.identity);
    }


}
