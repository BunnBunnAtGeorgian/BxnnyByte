using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewMob : EnemyAbstract
{
    void Start()
    {
        EnemyGetComponents();

    }

    // Update is called once per frame
    void Update()
    {
        EnemyUpdate();

    }

    public override void EnemyDie()
    {
        ScoreManager.AddToScore(18, 0.22f);
        Destroy(gameObject);
    }
}
