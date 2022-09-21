using UnityEngine;
using Tooltip.Core;

namespace Tooltip.View
{

    /// <summary>
    /// Contr�le l'apparition du Tooltip � l'�cran
    /// quand on survole un �l�ment de la sc�ne
    /// </summary>
    public class TooltipView : SingletonBehaviour<TooltipView>
    {
        #region Public Fields

        [field: Space(10)]
        [field: Header("Tooltip")]
        [field: SerializeField]
        private Tooltip Tooltip { get; set; }

        #endregion

        #region Mono

        protected override sealed void OnAwake()
        {
            Hide();
        }

        #endregion

        #region Static Methods

        public static void Show(string header = "", string content = "")
        {
            Instance.Tooltip.SetText(header, content);
            Instance.Tooltip.gameObject.SetActive(true);
        }

        public static void Hide()
        {
            Instance.Tooltip.gameObject.SetActive(false);
        }

        #endregion
    }
}