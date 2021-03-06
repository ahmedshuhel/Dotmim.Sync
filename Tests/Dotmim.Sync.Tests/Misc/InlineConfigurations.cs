﻿using System;
using System.Collections.Generic;

namespace Dotmim.Sync.Test.Misc
{
    public static class TestConfigurations
    {

        /// <summary>
        /// Always return a new list of configurations.
        /// To be sure that no tests will update a property that will be used (instead of default property) in the next test
        /// </summary>
        public static List<Action<SyncConfiguration>> GetConfigurations()
        {
            var Configurations = new List<Action<SyncConfiguration>>
            {
                new Action<SyncConfiguration>( sc => {
                    sc.ConflictResolutionPolicy = Enumerations.ConflictResolutionPolicy.ServerWins;
                    sc.Filters.Clear();
                    sc.ScopeInfoTableName = "scope_info";
                    sc.SerializationFormat = Enumerations.SerializationFormat.Json;
                    sc.StoredProceduresPrefix = "";
                    sc.StoredProceduresSuffix = "";
                    sc.TrackingTablesPrefix = "";
                    sc.TrackingTablesSuffix = "";
                    sc.TriggersPrefix = "";
                    sc.TriggersSuffix = "";
                }),

                new Action<SyncConfiguration>( sc => {
                    sc.ConflictResolutionPolicy = Enumerations.ConflictResolutionPolicy.ServerWins;
                    sc.Filters.Clear();
                    sc.ScopeInfoTableName = "scope_info";
                    sc.SerializationFormat = Enumerations.SerializationFormat.Binary;
                    sc.StoredProceduresPrefix = "";
                    sc.StoredProceduresSuffix = "";
                    sc.TrackingTablesPrefix = "";
                    sc.TrackingTablesSuffix = "";
                    sc.TriggersPrefix = "";
                    sc.TriggersSuffix = "";
                }),
            };

            return Configurations;
        }
    }
}