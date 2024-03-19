using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class DialogueLine
{ 
    [TextArea] public string dialogue;
}
[System.Serializable]
public class DialogueOwner
{ 
    [TextArea] public Image portrait;
}
[System.Serializable]
public class DialogueOwnerName
{
    [TextArea] public string name;
}

[CreateAssetMenu(menuName = "Dialogue/DialogueObject")]
public class DialogueObject : ScriptableObject
{
    public DialogueLine[] dialogueLines;
    public DialogueOwner[] dialogueOwners;
    public DialogueOwnerName[] dialogueOwnerNames;
}