using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu]
public class GameAction : ScriptableObject
{
   public UnityAction raise;

   public void RaiseAction()
   {
      raise?.Invoke();
   }
}
