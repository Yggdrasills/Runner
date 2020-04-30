using BunnyHop.Controllers.Messaging;
using BunnyHop.Utils.Messaging;
using UnityEngine;
using UnityEngine.EventSystems;

namespace BunnyHop.Controllers
{
    public class TouchInput : MonoBehaviour, IPointerClickHandler
    {
        public void OnPointerClick(PointerEventData eventData)
        {
            Signals.Get<JumpSignal>().Dispatch();
        }
    }
}