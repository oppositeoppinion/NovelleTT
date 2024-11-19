using Naninovel;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Naninovel.Command;

[CommandAlias("getAttestate")]
public class GetItems : Command
{
    public override async UniTask ExecuteAsync(AsyncToken asyncToken)
    {
        ItemsHandler.Instance.GetItem("Attestate");
    }
}
[CommandAlias("giveAttestate")]
public class GiveItems : Command
{
    public override async UniTask ExecuteAsync(AsyncToken asyncToken)
    {
        ItemsHandler.Instance.GiveItem();
    }
}

