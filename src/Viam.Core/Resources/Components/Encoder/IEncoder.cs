﻿using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Viam.Common.V1;
using Viam.Component.Encoder.V1;

namespace Viam.Core.Resources.Components.Encoder
{
    public interface IEncoder : IComponentBase
    {
        ValueTask ResetPosition(IDictionary<string, object?>? extra = null,
            TimeSpan? timeout = null,
            CancellationToken cancellationToken = default);

        ValueTask<(float Position, PositionType PositionType)> GetPosition(PositionType? positionType = null,
            IDictionary<string, object?>? extra = null,
            TimeSpan? timeout = null,
            CancellationToken cancellationToken = default);

        ValueTask<EncoderProperties> GetProperties(IDictionary<string, object?>? extra = null,
            TimeSpan? timeout = null,
            CancellationToken cancellationToken = default);

        ValueTask<Geometry[]> GetGeometries(IDictionary<string, object?>? extra = null,
            TimeSpan? timeout = null,
            CancellationToken cancellationToken = default);
    }

    public interface IEncoderClient : IEncoder;
}