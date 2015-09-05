using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour
{
    public enum EnemyState {Idle, TakeDamage, Disabled, Dead, Reborn}
    private EnemyState _enemyState;

    public static Enemy current;

    public float maxHp;
    public float currentHp;
    public float gold;
    //public float 

    // Use this for initialization
    void Start()
    {
        current = this;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void StateIdle()
    {
        

        SetState(EnemyState.Idle);
    }

    public void SetState(EnemyState value)
    {
        switch (_enemyState)
        {
            case EnemyState.Idle:
                //Логика выхода из состояния

                break;
            case EnemyState.TakeDamage:
                break;
            case EnemyState.Dead:
                break;
        }

        _enemyState = value;
    }

    public void InitializeEnemy()
    {
        transform.localPosition = Vector3.zero;
        transform.localRotation = Quaternion.identity;
        transform.localScale = Vector3.one;

        maxHp = Player.player.level + Player.player.level*10;
        currentHp = maxHp;
    }
}
