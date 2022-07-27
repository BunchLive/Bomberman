// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

using global::System;
using global::System.Collections.Generic;
using global::FlatBuffers;

public struct Colors : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_2_0_0(); }
  public static Colors GetRootAsColors(ByteBuffer _bb) { return GetRootAsColors(_bb, new Colors()); }
  public static Colors GetRootAsColors(ByteBuffer _bb, Colors obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public Colors __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public Color? SharedColor { get { int o = __p.__offset(4); return o != 0 ? (Color?)(new Color()).__assign(o + __p.bb_pos, __p.bb) : null; } }

  public static void StartColors(FlatBufferBuilder builder) { builder.StartTable(1); }
  public static void AddSharedColor(FlatBufferBuilder builder, Offset<Color> sharedColorOffset) { builder.AddStruct(0, sharedColorOffset.Value, 0); }
  public static Offset<Colors> EndColors(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<Colors>(o);
  }
  public static void FinishColorsBuffer(FlatBufferBuilder builder, Offset<Colors> offset) { builder.Finish(offset.Value); }
  public static void FinishSizePrefixedColorsBuffer(FlatBufferBuilder builder, Offset<Colors> offset) { builder.FinishSizePrefixed(offset.Value); }
};
