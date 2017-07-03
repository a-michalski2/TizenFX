/** Copyright (c) 2017 Samsung Electronics Co., Ltd.
*
* Licensed under the Apache License, Version 2.0 (the "License");
* you may not use this file except in compliance with the License.
* You may obtain a copy of the License at
*
* http://www.apache.org/licenses/LICENSE-2.0
*
* Unless required by applicable law or agreed to in writing, software
* distributed under the License is distributed on an "AS IS" BASIS,
* WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
* See the License for the specific language governing permissions and
* limitations under the License.
*
*/

namespace Tizen.NUI.UIComponents
{

    /// <summary>
    /// A RadioButton provides a radio button which two states \e selected or \e unselected.<br>
    /// Radio buttons are designed to select one of many option at the same time.<br>
    /// RadioButton can change its current state using Selected.<br>
    /// <br>
    /// RadioButtons can be grouped.<br>
    /// Two or more RadioButtons are in one group when they have this same parent.<br>
    /// In each groups only one RadioButton can be \e selected at a given time.<br>
    /// So when RadioButton is set to \e selected, other RadioButtons in its group are set to \e unselected.<br>
    /// When \e selected RadioButton is set to \e unselected no other RadioButtons in his group is set to \e selected.<br>
    /// <br>
    ///  A StateChanged Event is emitted when the RadioButton change its state to \e selected or \e unselected.<br>
    /// </summary>
    public class RadioButton : Button
    {
        private global::System.Runtime.InteropServices.HandleRef swigCPtr;

        internal RadioButton(global::System.IntPtr cPtr, bool cMemoryOwn) : base(NDalicPINVOKE.RadioButton_SWIGUpcast(cPtr), cMemoryOwn)
        {
            swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
        }

        internal static global::System.Runtime.InteropServices.HandleRef getCPtr(RadioButton obj)
        {
            return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
        }

        /// <summary>
        /// To make RadioButton instance be disposed.
        /// </summary>
        protected override void Dispose(DisposeTypes type)
        {
            if (disposed)
            {
                return;
            }

            if (type == DisposeTypes.Explicit)
            {
                //Called by User
                //Release your own managed resources here.
                //You should release all of your own disposable objects here.

            }

            //Release your own unmanaged resources here.
            //You should not access any managed member here except static instance.
            //because the execution order of Finalizes is non-deterministic.

            if (swigCPtr.Handle != global::System.IntPtr.Zero)
            {
                if (swigCMemOwn)
                {
                    swigCMemOwn = false;
                    NDalicPINVOKE.delete_RadioButton(swigCPtr);
                }
                swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
            }

            base.Dispose(type);
        }
        /// <summary>
        /// Creates an uninitialized RadioButton
        /// </summary>
        public RadioButton() : this(NDalicPINVOKE.RadioButton_New__SWIG_0(), true)
        {
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();

        }

        /// <summary>
        /// Creates an uninitialized RadioButton with Label
        /// </summary>
        /// <param name="label">Label text</param>
        public RadioButton(string label) : this(NDalicPINVOKE.RadioButton_New__SWIG_1(label), true)
        {
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();

        }
    }
}
