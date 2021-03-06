/**
 * Autogenerated by Thrift Compiler (0.9.1)
 *
 * DO NOT EDIT UNLESS YOU ARE SURE THAT YOU KNOW WHAT YOU ARE DOING
 *  @generated
 */
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Thrift;
using Thrift.Collections;
using System.Runtime.Serialization;
using Thrift.Protocol;
using Thrift.Transport;

namespace ImpalaSharp.Thrift.Hive
{

  #if !SILVERLIGHT
  [Serializable]
  #endif
  public partial class Order : TBase
  {
    private string _col;
    private int _order_direction;

    public string Col
    {
      get
      {
        return _col;
      }
      set
      {
        __isset.col = true;
        this._col = value;
      }
    }

    public int Order_direction
    {
      get
      {
        return _order_direction;
      }
      set
      {
        __isset.order_direction = true;
        this._order_direction = value;
      }
    }


    public Isset __isset;
    #if !SILVERLIGHT
    [Serializable]
    #endif
    public struct Isset {
      public bool col;
      public bool order_direction;
    }

    public Order() {
    }

    public void Read (TProtocol iprot)
    {
      TField field;
      iprot.ReadStructBegin();
      while (true)
      {
        field = iprot.ReadFieldBegin();
        if (field.Type == TType.Stop) { 
          break;
        }
        switch (field.ID)
        {
          case 1:
            if (field.Type == TType.String) {
              Col = iprot.ReadString();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 2:
            if (field.Type == TType.I32) {
              Order_direction = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          default: 
            TProtocolUtil.Skip(iprot, field.Type);
            break;
        }
        iprot.ReadFieldEnd();
      }
      iprot.ReadStructEnd();
    }

    public void Write(TProtocol oprot) {
      TStruct struc = new TStruct("Order");
      oprot.WriteStructBegin(struc);
      TField field = new TField();
      if (Col != null && __isset.col) {
        field.Name = "col";
        field.Type = TType.String;
        field.ID = 1;
        oprot.WriteFieldBegin(field);
        oprot.WriteString(Col);
        oprot.WriteFieldEnd();
      }
      if (__isset.order_direction) {
        field.Name = "order_direction";
        field.Type = TType.I32;
        field.ID = 2;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(Order_direction);
        oprot.WriteFieldEnd();
      }
      oprot.WriteFieldStop();
      oprot.WriteStructEnd();
    }

    public override string ToString() {
      StringBuilder sb = new StringBuilder("Order(");
      sb.Append("Col: ");
      sb.Append(Col);
      sb.Append(",Order_direction: ");
      sb.Append(Order_direction);
      sb.Append(")");
      return sb.ToString();
    }

  }

}
