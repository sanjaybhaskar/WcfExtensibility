using System;
using System.Collections.Generic;
using System.Text;
using System.ServiceModel.Dispatcher;
using System.Text.RegularExpressions;
using System.ServiceModel;

namespace Extensions
{
    public class ZipCodeInspector : IParameterInspector
    {
        int index = 0;

        public ZipCodeInspector() : this(0) { }
        public ZipCodeInspector(int index) { this.index = index; }

        #region IParameterInspector Members

        public void AfterCall(string operationName, object[] outputs, object returnValue, object correlationState)
        {
        }

        public object BeforeCall(string operationName, object[] inputs)
        {
            MyStateContainer sc =
                OperationContext.Current.Host.Extensions.Find<MyStateContainer>();
            Console.WriteLine("*** ParameterInspector: {0} ***", sc.MyState);
            sc.MyState = "baz";

            if (!Regex.IsMatch(inputs[index] as string, @"\d{5}-\d{4}"))
                throw new FaultException("Invalid zip code format...please use ddddd-dddd");
            return null;
        }

        #endregion
    }
}
