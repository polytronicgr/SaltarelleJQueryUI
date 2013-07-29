using System;
using System.Html;
using System.Runtime.CompilerServices;

namespace jQueryApi.UI.Widgets {

    [Imported]
    [IgnoreNamespace]
    [Serializable]
    public sealed class DialogDragStopEvent {

        public object Offset {
            get; set;
        }

        public object Position {
            get; set;
        }
    }
}
