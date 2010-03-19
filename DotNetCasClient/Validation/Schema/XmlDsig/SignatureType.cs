﻿using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace DotNetCasClient.Validation.Schema.XmlDsig
{
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategory("code")]
    [XmlType(Namespace="http://www.w3.org/2000/09/xmldsig#")]
    [XmlRoot("Signature", Namespace="http://www.w3.org/2000/09/xmldsig#", IsNullable=false)]
    public class SignatureType {
        [XmlElement]
        public SignedInfoType SignedInfo
        {
            get;
            set;
        }

        [XmlElement]
        public SignatureValueType SignatureValue
        {
            get;
            set;
        }

        [XmlElement]
        public KeyInfoType KeyInfo
        {
            get;
            set;
        }

        [XmlElement("Object")]
        public ObjectType[] Object
        {
            get;
            set;
        }

        [XmlAttribute(DataType="ID")]
        public string Id
        {
            get;
            set;
        }
    }
}