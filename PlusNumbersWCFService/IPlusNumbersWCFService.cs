using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace PlusNumbersWCFService
{
    [ServiceContract]
    public interface IPlusNumbersWCFService
    {

        [OperationContract]
        int PlusNumbers(int a, int b);    
    }
  
}
