using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ElfFactory : KingdomFactory
{
    public InputField armyInput;
    public GameObject soldier;
    public GameObject castle;
    public GameObject king;

    public void Army()
    {
        createArmy(soldier, int.Parse(armyInput.text));
    }

    public void Castle()
    {
        createCastle(castle);
    }

    public void King()
    {
        createKing(king);
    }
}
