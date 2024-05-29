using UnityEngine;

public class Enemy05 : MonoBehaviour
{
    public WinMan3 winMan3;

    void Die()
    {
        winMan3.EnemyKilled();
    }
}
