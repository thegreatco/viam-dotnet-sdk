﻿using System;
using System.ComponentModel;
using System.Linq;

using Viam.Component.Camera.V1;

namespace Viam.Core.Resources
{
    public record CloudMetadata(
        string PrimaryOrgId,
        string LocationId,
        string MachineId,
        string MachinePartId,
        string RobotPartId)
    {
        public override string ToString() => $"{nameof(PrimaryOrgId)}:{PrimaryOrgId}, {nameof(LocationId)}:{LocationId}, {nameof(MachineId)}:{MachineId}, {nameof(MachinePartId)}:{MachinePartId}, {nameof(RobotPartId)}:{RobotPartId}";
    }

    public record DistortionParameters(string model, double[] parameters)
    {
        public static DistortionParameters
            FromGrpc(Viam.Component.Camera.V1.DistortionParameters distortionParameters) =>
            new(distortionParameters.Model, distortionParameters.Parameters.ToArray());

        public Viam.Component.Camera.V1.DistortionParameters ToGrpc() => new() { Model = model, Parameters = { parameters } };
    }

    public record IntrinsicParameters(
        double centerXPx,
        double centerYPx,
        double focalXPx,
        double focalYPx,
        uint heightPx,
        uint widthPx)
    {
        public static IntrinsicParameters FromGrpc(Viam.Component.Camera.V1.IntrinsicParameters parameters) =>
            new(parameters.CenterXPx,
                parameters.CenterYPx,
                parameters.FocalXPx,
                parameters.FocalYPx,
                parameters.HeightPx,
                parameters.WidthPx);

        public Viam.Component.Camera.V1.IntrinsicParameters ToGrpc() => new()
        {
            CenterXPx = centerXPx,
            CenterYPx = centerYPx,
            FocalXPx = focalXPx,
            FocalYPx = focalYPx,
            HeightPx = heightPx,
            WidthPx = widthPx
        };
    }

    public record CameraProperties(
        DistortionParameters DistortionParameters,
        IntrinsicParameters IntrinsicParameters,
        MimeType[] MimeTypes,
        bool SupportsPcd);

    public enum MimeType
    {
        [Description("unsupported")]
        Unsupported,
        [Description("unspecified")]
        Unspecified,
        [Description("image/vnd.viam.rgba")]
        ViamRgba,
        [Description("image/vnd.viam.dep")]
        ViamRawDepth,
        [Description("image/jpeg")]
        Jpeg,
        [Description("image/png")]
        Png,
        [Description("pointcloud/pcd")]
        Pcd
    }

    public static class MimeTypeExtensions
    {
        public static MimeType FromGrpc(string name) =>
            name switch
            {
                nameof(MimeType.Unsupported) => MimeType.Unsupported,
                nameof(MimeType.ViamRgba) => MimeType.ViamRgba,
                nameof(MimeType.ViamRawDepth) => MimeType.ViamRawDepth,
                nameof(MimeType.Jpeg) => MimeType.Jpeg,
                nameof(MimeType.Png) => MimeType.Png,
                nameof(MimeType.Pcd) => MimeType.Pcd,
                _ => throw new ArgumentOutOfRangeException(nameof(name), name, "Unknown MimeType")
            };

        public static MimeType FromGrpc(Viam.Component.Camera.V1.Format mimeType) => FromGrpc(mimeType.ToString());

        public static string ToGrpc(this MimeType mimeType) => mimeType.ToString();
        public static Format ToGrpcFormat(this MimeType mimeType) => mimeType switch
                                                                     {
                                                                         MimeType.Png          => Format.Png,
                                                                         MimeType.Jpeg         => Format.Jpeg,
                                                                         MimeType.ViamRawDepth => Format.RawDepth,
                                                                         MimeType.ViamRgba     => Format.RawRgba,
                                                                         MimeType.Unspecified => Format.Unspecified,
                                                                         _ => throw new ArgumentOutOfRangeException(nameof(mimeType), mimeType, "Unsupported image format")
                                                                     };
    }

    public record ViamImage(ReadOnlyMemory<byte> bytes, MimeType mimeType, int width, int height, string? sourceName = null);

    /// <summary>
    /// Various dimensions of the base
    /// </summary>
    /// <param name="TurningRadius">The turning radius of the base, in meters</param>
    /// <param name="WheelCircumference">The circumference of the wheels on the base, in meters. It is assumed all wheels have the same circumference</param>
    /// <param name="Width">The width of the base, in meters</param>
    public record BaseProperties(double TurningRadius, double WheelCircumference, double Width)
    {
        public override string ToString() => $"{nameof(TurningRadius)}: {TurningRadius}, {nameof(WheelCircumference)}: {WheelCircumference}, {nameof(Width)}: {Width}";
    }

    public record EncoderProperties(bool AngleDegreesSupported, bool TicksCountSupported);
}
