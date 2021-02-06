using UnityEngine;
using UnityEngine.EventSystems;

namespace ArchNet.Extension.ScrollRect
{
    /// <summary>
    /// [EXTENSION] - [ARCH NET] - [SCROLL_RECT] Extension to manage ScrollRect component
    /// author : LOUIS PAKEL
    /// </summary>
    public static class ScrollRectExtensions
    {

        #region Moving Scroll 

        /// <summary>
        /// Description : Scroll Extension to manage scroll rect
        /// </summary>
        /// <param name="pScrollRect">Scrollrect</param>
        public static void ScrollToTop(this UnityEngine.UI.ScrollRect pScrollRect)
        {
            pScrollRect.normalizedPosition = new Vector2(0, 1);
        }

        /// <summary>
        /// Description : Scroll to the bottom of a scroll rect
        /// </summary>
        /// <param name="pScrollRect">Scrollrect</param>
        public static void ScrollToBottom(this UnityEngine.UI.ScrollRect pScrollRect)
        {
            pScrollRect.normalizedPosition = new Vector2(0, 0);
        }


        #endregion

        #region Opactity

        /// <summary>
        /// Description : Manage ScrolLRect opacity
        /// </summary>
        /// <param name="pScrollRectCanvas">Scrollrect Canavs Group</param>
        /// <param name="pOpacity">Opacity to apply on the scroll rect</param>
        public static void ScrollOpacity(this CanvasGroup pScrollRectCanvas, float pOpacity)
		{
            // Opacitiy in correct range
            if(pOpacity >= 0 && pOpacity <= 1)
			{
                // Apply new alpha
                pScrollRectCanvas.alpha = pOpacity;
            }
        }


        #endregion

        #region Manage Scroll

        /// <summary>
        /// Description : Stop scrolling system from a scroll view
        /// </summary>
        public static void StopScroll(this UnityEngine.UI.ScrollRect pScrollRect)
        {
            pScrollRect.enabled = false;
        }

        /// <summary>
        /// Description : Start or Resume scrolling system from a scroll view
        /// </summary>
        public static void ResumeScroll(this UnityEngine.UI.ScrollRect pScrollRect)
        {
            if (pScrollRect.isActiveAndEnabled)
                return;

            pScrollRect.enabled = true;
        }

        /// <summary>
        /// Description : Check if a Scroll Rect event is scrolling
        /// </summary>
        /// <returns></returns>
        public static bool IsScrolling(this UnityEngine.UI.ScrollRect pScrollRect, PointerEventData pEvent)
        {
            bool lResult = false;

            if (pScrollRect != null && pEvent.delta.y < 0.08f && pEvent.delta.y > -0.08f)
            {
                lResult = true;
            }

            return lResult;
        }

        /// <summary>
        /// Description : Check if a Scroll Rect event is scrolling
        /// </summary>
        /// <returns></returns>
        public static bool IsDragging(this UnityEngine.UI.ScrollRect pScrollRect, PointerEventData pEvent)
        {
            bool lResult = false;

            if (pScrollRect != null && pEvent.delta.x > 1f && pEvent.delta.y < 3f )
            {
                lResult = true;
            }

            return lResult;
        }
        #endregion
    }
}
