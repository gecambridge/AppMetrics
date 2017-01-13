﻿// Copyright (c) Allan hardy. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.

using System;
using App.Metrics.Data;
using App.Metrics.Extensions;
using Newtonsoft.Json;

namespace App.Metrics.Formatters.Json.Converters
{
    public class ApdexConverter : JsonConverter
    {
        public override bool CanConvert(Type objectType) { return typeof(ApdexValueSource) == objectType; }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            var source = serializer.Deserialize<ApdexScore>(reader);
            return source.ToMetricValueSource();
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            var source = (ApdexValueSource)value;

            var target = source.ToMetric();

            serializer.Serialize(writer, target);
        }
    }
}