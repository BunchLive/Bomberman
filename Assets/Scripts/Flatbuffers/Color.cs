// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

using global::System;
using global::System.Collections.Generic;
using global::FlatBuffers;

public struct Color : IFlatbufferObject
{
  private Struct __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public void __init(int _i, ByteBuffer _bb) { __p = new Struct(_i, _bb); }
  public Color __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public float Red { get { return __p.bb.GetFloat(__p.bb_pos + 0); } }
  public float Green { get { return __p.bb.GetFloat(__p.bb_pos + 4); } }
  public float Blue { get { return __p.bb.GetFloat(__p.bb_pos + 8); } }

  public static Offset<Color> CreateColor(FlatBufferBuilder builder, float Red, float Green, float Blue) {
    builder.Prep(4, 12);
    builder.PutFloat(Blue);
    builder.PutFloat(Green);
    builder.PutFloat(Red);
    return new Offset<Color>(builder.Offset);
  }
};

