using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleMode: MonoBehaviour
{
    public bool battleModeTrue = false;
    public IEnumerator battle()
    {
        yield return new WaitForSeconds(15);
        battleModeTrue = false;
    }
    public void startBattleMode()
    {
        StartCoroutine(battle());
        battleModeTrue = true;
    }
}
