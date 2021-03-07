using UnityEngine;

namespace Player
{
    /// <include file='../../Docs/PlayerInputDocs.xml' path='docs/members[@name="playerInput"]/PlayerInput/*'/>
    public class PlayerInput : MonoBehaviour
    {
        /// <include file='../../Docs/PlayerInputDocs.xml' path='docs/members[@name="playerInput"]/HorizontalInput/*'/>
        internal float Horizontal;

        private void Update()
        {
            UpdateHorizontalInput();
        }

        /// <include file='../../Docs/PlayerInputDocs.xml' path='docs/members[@name="playerInput"]/UpdateHorizontalInput/*'/>
        private void UpdateHorizontalInput()
        {
            Horizontal = Input.GetAxis("Horizontal");
        }
    }
}
