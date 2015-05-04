using System;
using UnityEngine;

namespace ComponentInsight {

    [Serializable]
    public sealed class InsightSlot {

        // todo seems like the same as `sourceFieldName`
        /// <summary>
        /// Component field which value will be displayed in the window.
        /// </summary>
        [SerializeField]
        private string field;

#pragma warning disable 0414

        /// <summary>
        ///     How many rows should be displayed in the inspector.
        /// </summary>
        [SerializeField]
        private int rows = 1;

#pragma warning restore 0414
        /// <summary>
        ///     Selected source component.
        /// </summary>
        [SerializeField]
        private Component sourceCo;

        [SerializeField]
        private int sourceComponentIndex;

        /// <summary>
        ///     Selected source game object.
        /// </summary>
        [SerializeField]
        private GameObject sourceGO;

        [SerializeField]
        private int sourceFieldIndex;

        [SerializeField]
        private string sourceFieldName;

        public string Field {
            get { return field; }
            set { field = value; }
        }

        /// <summary>
        ///     Selected source component.
        /// </summary>
        public Component SourceCo {
            get { return sourceCo; }
        }

        /// <summary>
        ///     Selected source game object.
        /// </summary>
        public GameObject SourceGO {
            get { return sourceGO; }
        }

        public string SourceFieldName {
            get { return sourceFieldName; }
        }

    }

}