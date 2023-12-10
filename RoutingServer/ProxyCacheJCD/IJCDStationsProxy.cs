﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ProxyCacheJCD
{
    [ServiceContract]
    public interface IJCDStationsProxy
    {
        [OperationContract]
        List<Station> GetallStations();
    }
}