﻿using System;

namespace SwissTransport
{
    public interface ITransport
    {
        Stations GetStations(string query);
        StationBoardRoot GetStationBoard(string station, string id,string date);
        Connections GetConnections(string fromStation, string toStattion, string date);
    }
}