﻿using NetACS.CWMP.Models;
using System.ServiceModel;

namespace NetACS.CWMP.Interfaces
{
    [ServiceContract(Namespace = "urn:dslforum-org:cwmp-1-0")]
    public interface ICWMPService
    {
        [OperationContract]
        Inform Inform(Inform model);
    }
}