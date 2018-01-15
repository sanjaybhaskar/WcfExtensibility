using System;
using System.Collections.Generic;
using System.Text;
using System.ServiceModel.Description;

namespace Extensions
{
    public class ZipCodeParameterValidation : Attribute, IOperationBehavior
    {
        int index = 0;

        public ZipCodeParameterValidation() : this(0) { }
        public ZipCodeParameterValidation(int index) { this.index = index; }

        #region IOperationBehavior Members

        public void AddBindingParameters(OperationDescription operationDescription, System.ServiceModel.Channels.BindingParameterCollection bindingParameters)
        {
        }

        public void ApplyClientBehavior(OperationDescription operationDescription, System.ServiceModel.Dispatcher.ClientOperation clientOperation)
        {
            clientOperation.ParameterInspectors.Add(
                new ZipCodeInspector(index));
        }

        public void ApplyDispatchBehavior(OperationDescription operationDescription, System.ServiceModel.Dispatcher.DispatchOperation dispatchOperation)
        {
            dispatchOperation.ParameterInspectors.Add(
               new ZipCodeInspector(index));       
        }

        public void Validate(OperationDescription operationDescription)
        {
        }

        #endregion
    }
}
