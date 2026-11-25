// ArchNet · ScrollRect Extension
// Extension methods for scroll views: jump to the top or bottom, lock scrolling,
// tell a horizontal drag from a vertical one, fade a scroll view.
// Docs: https://archnet-plateform.fr/#ScrollRectExtension

using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace ArchNet.Extension
{
    public static class ScrollRectExtensions
    {
        public static void ScrollToTop(this ScrollRect scrollRect) => scrollRect.verticalNormalizedPosition = 1f;
        public static void ScrollToBottom(this ScrollRect scrollRect) => scrollRect.verticalNormalizedPosition = 0f;
        public static void ScrollToLeft(this ScrollRect scrollRect) => scrollRect.horizontalNormalizedPosition = 0f;
        public static void ScrollToRight(this ScrollRect scrollRect) => scrollRect.horizontalNormalizedPosition = 1f;

        /// <summary>Stops the scroll view from moving (its content stays where it is).</summary>
        public static void LockScroll(this ScrollRect scrollRect)
        {
            scrollRect.StopMovement();
            scrollRect.enabled = false;
        }

        public static void UnlockScroll(this ScrollRect scrollRect) => scrollRect.enabled = true;

        /// <summary>True when the drag moves more sideways than up or down.</summary>
        public static bool IsHorizontalDrag(this PointerEventData eventData) =>
            Mathf.Abs(eventData.delta.x) > Mathf.Abs(eventData.delta.y);

        /// <summary>True when the drag moves more up or down than sideways.</summary>
        public static bool IsVerticalDrag(this PointerEventData eventData) =>
            Mathf.Abs(eventData.delta.y) > Mathf.Abs(eventData.delta.x);

        /// <summary>Sets the opacity of a scroll view's CanvasGroup, clamped between 0 and 1.</summary>
        public static void SetOpacity(this CanvasGroup group, float opacity) => group.alpha = Mathf.Clamp01(opacity);
    }
}
