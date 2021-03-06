﻿// <copyright file="IProvideMetrics.cs" company="Allan Hardy">
// Copyright (c) Allan Hardy. All rights reserved.
// </copyright>

using App.Metrics.Abstractions.Metrics;
using App.Metrics.Abstractions.MetricTypes;
using App.Metrics.Apdex.Abstractions;
using App.Metrics.Counter.Abstractions;
using App.Metrics.Gauge.Abstractions;
using App.Metrics.Histogram.Abstractions;
using App.Metrics.Meter.Abstractions;
using App.Metrics.Registry.Abstractions;
using App.Metrics.Timer.Abstractions;

// ReSharper disable CheckNamespace
namespace App.Metrics.Core.Interfaces
    // ReSharper restore CheckNamespace
{
    /// <summary>
    ///     Provides access to APIs which get or add metrics to the <see cref="IMetricsRegistry" /> and return the instance.
    /// </summary>
    public interface IProvideMetrics
    {
        /// <summary>
        ///     Gets the Apdex API to register and retrieve <see cref="IApdexMetric" />s to be measured.
        /// </summary>
        /// <value>
        ///     The Apdex API for registering and retrieving <see cref="IApdexMetric" />s to be measured
        /// </value>
        IProvideApdexMetrics Apdex { get; }

        /// <summary>
        ///     Gets the Counter API to register and retrieve <see cref="ICounterMetric" />s to be measured.
        /// </summary>
        /// <value>
        ///     The Counter API for registering and retrieving <see cref="ICounterMetric" />s to be measured
        /// </value>
        IProvideCounterMetrics Counter { get; }

        /// <summary>
        ///     Gets the Gauge API to register and retrieve <see cref="IGaugeMetric" />s to be measured.
        /// </summary>
        /// <value>
        ///     The Gauge API for registering and retrieving <see cref="IGaugeMetric" />s to be measured
        /// </value>
        IProvideGaugeMetrics Gauge { get; }

        /// <summary>
        ///     Gets the Histogram API to register and retrieve <see cref="IHistogramMetric" />s to be measured.
        /// </summary>
        /// <value>
        ///     The Histogram API for registering and retrieving <see cref="IHistogramMetric" />s to be measured
        /// </value>
        IProvideHistogramMetrics Histogram { get; }

        /// <summary>
        ///     Gets the Meter API to register and retrieve <see cref="IMeterMetric" />s to be measured.
        /// </summary>
        /// <value>
        ///     The Meter API for registering and retrieving <see cref="IMeterMetric" />s to be measured
        /// </value>
        IProvideMeterMetrics Meter { get; }

        /// <summary>
        ///     Gets the Timer API to register and retrieve <see cref="ITimerMetric" />s to be measured.
        /// </summary>
        /// <value>
        ///     The Timer API for registering and retrieving <see cref="ITimerMetric" />s to be measured
        /// </value>
        IProvideTimerMetrics Timer { get; }
    }
}