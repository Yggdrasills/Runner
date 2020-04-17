using TRex.Controllers.Messaging;
using TRex.Utils.Messaging;
using UnityEngine;
using UnityEngine.EventSystems;

namespace TRex.Controllers
{
    public class TouchInput : MonoBehaviour, IPointerClickHandler
    {
        public void OnPointerClick(PointerEventData eventData)
        {
            Signals.Get<JumpSignal>().Dispatch();
        }
    }
}