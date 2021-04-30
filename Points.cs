using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Points : MonoBehaviour
{
    public Enemy enemy;
    private SpawnEnemies spawner;
    private void Start()
    {
        spawner = FindObjectOfType<SpawnEnemies>();
        Instantiate(enemy, transform.position, transform.rotation);
        enemy.health = Mathf.RoundToInt(spawner.enemyHealth);
        enemy.damage = Mathf.RoundToInt(spawner.enemyDamage);

    }
}
