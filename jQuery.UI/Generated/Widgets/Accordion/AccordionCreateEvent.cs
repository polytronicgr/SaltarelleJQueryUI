using System;
using System.Html;
using System.Runtime.CompilerServices;

namespace jQueryApi.UI.Widgets {

    [Imported]
    [IgnoreNamespace]
    [Serializable]
    public sealed class AccordionCreateEvent {

        public jQueryObject Header {
            get; set;
        }

        public jQueryObject Panel {
            get; set;
        }
    }
}
