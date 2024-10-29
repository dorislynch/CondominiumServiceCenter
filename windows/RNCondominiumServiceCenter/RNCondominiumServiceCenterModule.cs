using ReactNative.Bridge;
using System;
using System.Collections.Generic;
using Windows.ApplicationModel.Core;
using Windows.UI.Core;

namespace Condominium.Service.Center.RNCondominiumServiceCenter
{
    /// <summary>
    /// A module that allows JS to share data.
    /// </summary>
    class RNCondominiumServiceCenterModule : NativeModuleBase
    {
        /// <summary>
        /// Instantiates the <see cref="RNCondominiumServiceCenterModule"/>.
        /// </summary>
        internal RNCondominiumServiceCenterModule()
        {

        }

        /// <summary>
        /// The name of the native module.
        /// </summary>
        public override string Name
        {
            get
            {
                return "RNCondominiumServiceCenter";
            }
        }
    }
}
